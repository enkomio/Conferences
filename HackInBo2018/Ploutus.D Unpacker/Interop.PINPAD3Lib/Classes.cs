using System;
using System.Collections.Generic;
using System.Text;

namespace PINPAD3Lib
{
    public interface IPINFunctionKeys
    {
        Boolean FK_0 { get; set; }
        Boolean FK_1 { get; set; }
        Boolean FK_2 { get; set; }
        Boolean FK_3 { get; set; }
        Boolean FK_4 { get; set; }
        Boolean FK_5 { get; set; }
        Boolean FK_6 { get; set; }
        Boolean FK_7 { get; set; }
        Boolean FK_8 { get; set; }
        Boolean FK_9 { get; set; }
        Boolean FK_CANCEL { get; set; }
        Boolean FK_ENTER { get; set; }
        Boolean FK_OEM1 { get; set; }
        Boolean FK_OEM2 { get; set; }
    }

    public class PINFunctionKeys : IPINFunctionKeys
    {
        public Boolean FK_0 { get; set; }
        public Boolean FK_1 { get; set; }
        public Boolean FK_2 { get; set; }
        public Boolean FK_3 { get; set; }
        public Boolean FK_4 { get; set; }
        public Boolean FK_5 { get; set; }
        public Boolean FK_6 { get; set; }
        public Boolean FK_7 { get; set; }
        public Boolean FK_8 { get; set; }
        public Boolean FK_9 { get; set; }
        public Boolean FK_CANCEL { get; set; }
        public Boolean FK_ENTER { get; set; }
        public Boolean FK_OEM1 { get; set; }
        public Boolean FK_OEM2 { get; set; }
    }

    public class PINFunctionKeysClass : PINFunctionKeys
    {

    }

    public interface IPINFDKeys
    {
        Boolean FDK_01 { get; set; }
        Boolean FDK_02 { get; set; }
        Boolean FDK_03 { get; set; }
        Boolean FDK_04 { get; set; }
        Boolean FDK_05 { get; set; }
        Boolean FDK_06 { get; set; }
        Boolean FDK_07 { get; set; }
        Boolean FDK_08 { get; set; }
    }

    public class PINFDKeys : IPINFDKeys
    {
        public Boolean FDK_01 { get; set; }
        public Boolean FDK_02 { get; set; }
        public Boolean FDK_03 { get; set; }
        public Boolean FDK_04 { get; set; }
        public Boolean FDK_05 { get; set; }
        public Boolean FDK_06 { get; set; }
        public Boolean FDK_07 { get; set; }
        public Boolean FDK_08 { get; set; }
    }

    public class PINFDKeysClass : PINFDKeys
    {

    }

    public interface IPINReadData
    {
        PINFDKeys ActiveFDKs { get; set; }
        PINFunctionKeys ActiveKeys { get; set; }
        Boolean AutoEnd { get; set; }
        Int16 MaxLength { get; set; }
        Int16 MinLength { get; set; }
        String ReplacementCharacter { get; set; }
        PINFDKeys TerminateFDKs { get; set; }
        PINFunctionKeys TerminateKeys { get; set; }
    }

    public class PINReadData : IPINReadData
    {
        public PINFDKeys ActiveFDKs { get; set; }
        public PINFunctionKeys ActiveKeys { get; set; }
        public Boolean AutoEnd { get; set; }
        public Int16 MaxLength { get; set; }
        public Int16 MinLength { get; set; }
        public String ReplacementCharacter { get; set; }
        public PINFDKeys TerminateFDKs { get; set; }
        public PINFunctionKeys TerminateKeys { get; set; }
    }
    
    public class PINReadDataClass : PINReadData
    {
        
    }
}
