# HackInbBo Safe Edition - May 2020
Questa directory contiene le informazioni e il materiale presentato durante la demo online di [HackInbo](https://www.hackinbo.it/) [Safe Edition 2020](https://www.linkedin.com/feed/update/urn:li:activity:6667490582480330753/).

La demo avra' una parte iniziale in cui introdurro' alcuni concetti di base per poi proseguire con la parte pratica che avra' un taglio prettamente tecnico. La parte iniziale puo' essere seguita anche da chi ha conoscenze base di informatica. Nella seconda parte mostrero' un'analisi su un esempio piu' avanzato.

## Slides
* <a href="https://github.com/enkomio/Conferences/blob/master/HackInBoSafeEditionMay2020/HackInBo%20Safe%20Edition%20May%202020.pdf">Slide</a>

## Materiale per seguire la demo
* Software di virtualizzazione: Suggerito VMWare ma va benissimo anche un'alternativa. E' importante far eseguire i sample analizzati all'interno di una Virtual Machine in quanto sono esempi di malware reali e possono causare molti danni al vostro computer.

* Process inspector: Consigliato [ProcessHacker](https://processhacker.sourceforge.io/) per ispezionare i processi eseguiti sul sistema.

* Debugger: Consigliato [x64dbg](https://x64dbg.com/) ma anche [OllyDbg](http://www.ollydbg.de/version2.html) va bene. Il debugger verra' utilizzato per l'analisi dinamica del sample.

* Disassembler: Consigliato [IDA Pro](https://www.hex-rays.com/products/ida/support/download_freeware/). Durante la demo utilizzero' anche il decompiler di IDA Pro il quale e' a pagamento. Chi vuole puo' usare l'alternativa gratuita [Ghidra](https://ghidra-sre.org/) il quale comprende anche un ottimo decompiler.

* IDA Script: 
    * [crypt_helper.py](https://gist.github.com/alexander-hanel/3d2fbf9b15d34964416f592b60b47d2e) per l'analisi delle funzioni di cifratura.

* PE Editor: Utilizzero' un PE editor per modificare alcune caratteristiche del binario. Io utilizzero' [CFF Explorer](https://ntcore.com/?page_id=388), ma anche [pestudio Free](https://www.winitor.com/features) edition va bene.

## Samples
Di seguito i sample che verranno analizzati durante la demo. Tutti i samples sono malware reali e si possono trovare su VirusTotal. Possono anche essere scaricati da questo repository. La password del file zip e': *infected*

* [c5fedb78ca5799fed3010812941f0da7222803a444efea0594bec67c6eca1254](https://github.com/enkomio/Conferences/blob/master/HackInBoSafeEditionMay2020/samples/c5fedb78ca5799fed3010812941f0da7222803a444efea0594bec67c6eca1254.zip)
* [aaa9268b4a80f75eeb58b61cbd745523b1823d5adf54c615ad9ddf6b8fa0e806](https://github.com/enkomio/Conferences/blob/master/HackInBoSafeEditionMay2020/samples/aaa9268b4a80f75eeb58b61cbd745523b1823d5adf54c615ad9ddf6b8fa0e806.zip)
