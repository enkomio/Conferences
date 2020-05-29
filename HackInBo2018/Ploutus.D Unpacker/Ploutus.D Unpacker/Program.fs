open System
open System.Linq
open System.Reflection
open System.Runtime.CompilerServices
open System.Collections
open System.Collections.Generic
open System.Diagnostics
open Microsoft.Diagnostics.Runtime
open dnlib.DotNet
open dnlib.DotNet.Emit
open dnlib.IO

let runAllStaticConstructor(assembly: Assembly) =
    assembly.GetTypes()
    |> Seq.iter(fun assemblyType -> 
        RuntimeHelpers.RunClassConstructor(assemblyType.TypeHandle)
    )

let getMsilStorage(assembly: Assembly) =
    let assemblyType = assembly.GetType("yasttpQOrHx2jEkiUL.P9ZBIKXMsRMxLdTfcG")
    let storageField = assemblyType.GetField("k6dbsY0qhy",  BindingFlags.NonPublic ||| BindingFlags.Static)
    let hashTable = storageField.GetValue(null) :?> Hashtable
    hashTable.Cast<DictionaryEntry>()
    |> Seq.map(fun kv -> 
        // extract bytes array
        let bytesField = 
            kv.Value.GetType().GetFields(BindingFlags.Instance ||| BindingFlags.NonPublic) |> Seq.toList
            |> Seq.find(fun field -> field.FieldType.IsArray)
        let msilBytes = bytesField.GetValue(kv.Value) :?> Byte array        
        (kv.Key :?> Int64, msilBytes))
    |> Map.ofSeq
    
let getAssemblyBaseAddress(assembly: Assembly) =
    let pid = Process.GetCurrentProcess().Id
    let dataTarget = DataTarget.AttachToProcess(pid, uint32 5000, AttachFlag.Passive)
    let runtime = dataTarget.ClrVersions.[0].CreateRuntime()    
    let assemblyModule = runtime.Modules |> Seq.find(fun m -> m.Name.Equals(assembly.Location))
    let baseAddress = int32 assemblyModule.ImageBase
    dataTarget.Dispose()
    baseAddress

let assembleInstructions(dnModule: ModuleDefMD, bytes: Byte array) =
    let reader = MemoryImageStream.Create(bytes)
    let bodyReader = new MethodBodyReader(dnModule, reader, new List<Parameter>())
    let readInstructionMethod = bodyReader.GetType().GetMethod("ReadInstructionsNumBytes", BindingFlags.Instance ||| BindingFlags.NonPublic)
    readInstructionMethod.Invoke(bodyReader, [|uint32 bytes.Length|]) |> ignore
    bodyReader.Instructions
    
[<EntryPoint>]
let main argv = 
    let fullPath = @"C:\Users\malwlab\Desktop\BLOG\UNLOCKED_PloutusD_d93342bd12ef44d92bf58ed2f0f88443385a0192804a5d0976352484c0d37685.exe"
    let assembly = Assembly.LoadFile(fullPath)

    // run all static constructor to fill the protection dictionary containing the real MSIL bytecode
    runAllStaticConstructor(assembly)

    // retrieve the dictionary via reflection. This is higly dependant to a specific sample, the field name may change from sample to sample
    let msilStorage = getMsilStorage(assembly)     

    // get the malware base addres in order to calculate the method body address
    let baseAddress = getAssemblyBaseAddress(assembly)

    // use a modified version of dnlib in order to set the real MSIL bytecode
    let dnModule = ModuleDefMD.Load(fullPath)    
    dnModule.Types
    |> Seq.map(fun t -> t.Methods)
    |> Seq.concat
    |> Seq.iter(fun dnMethod ->
        if dnMethod.HasBody then
            dnMethod.Body.KeepOldMaxStack <- true
            let offset = int32 dnMethod.Body.HeaderSize        
            let ilAddress = int32 dnMethod.RVA + baseAddress + offset
            if msilStorage.ContainsKey(int64 ilAddress) then
                let realMsilBytes = msilStorage.[int64 ilAddress]
                dnMethod.Body.MaxStack <- uint16 50
                dnMethod.Body.InitLocals <- true
                
                // set the body via raw buffer. This property is not present in the real dnlib code :P
                dnMethod.Body.RawBody <- new List<Byte>(realMsilBytes)
                
                // via instruction (this method doesn't work well due to not calid opcode
                //let newBodyInstruction = assembleInstructions(dnModule, realMsilBytes)
                //dnMethod.Body.Instructions.Clear()                
                //newBodyInstruction |> Seq.iter(dnMethod.Body.Instructions.Add)

                Console.WriteLine("Rebuilded: " + dnMethod.FullName)
    )

    // finally write back the new assembly
    dnModule.Write(fullPath + "_rebuilded")
    0
