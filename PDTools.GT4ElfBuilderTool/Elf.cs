﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PDTools.GT4ElfBuilderTool;

public class ElfEnums
{
    public enum e_type32_e
    {
        ET_NONE = 0x0,
        ET_REL = 0x1,
        ET_EXEC = 0x2,
        ET_DYN = 0x3,
        ET_CORE = 0x4,
        ET_LOOS = 0xfe00,
        ET_HIOS = 0xfeff,
        ET_LOPROC = 0xff00,
        ET_HIPROC = 0xffff
    };

    public enum SymbolVisibility
    {
        Default = 0,
        Internal = 1,
        Hidden = 2,
        Protected = 3,
        Exported = 4,
        Singleton = 5,
        Eliminate = 6,
    }

    public enum SymbolBinding
    {
        Local = 0,
        GlobalSymbol = 1,
        Weak = 2,
        Os10 = 10,
        Os11 = 11,
        Os12 = 12,
        Proc13 = 13,
        Proc14 = 14,
        Proc15 = 15,
    }

    public enum Endian
    {
        Le = 1,
        Be = 2,
    }

    public enum ShType
    {
        NullType = 0,
        Progbits = 1,
        Symtab = 2,
        Strtab = 3,
        Rela = 4,
        Hash = 5,
        Dynamic = 6,
        Note = 7,
        Nobits = 8,
        Rel = 9,
        Shlib = 10,
        Dynsym = 11,
        InitArray = 14,
        FiniArray = 15,
        PreinitArray = 16,
        Group = 17,
        SymtabShndx = 18,
        SunwSymnsort = 1879048172,
        SunwPhname = 1879048173,
        SunwAncillary = 1879048174,
        SunwCapchain = 1879048175,
        SunwCapinfo = 1879048176,
        SunwSymsort = 1879048177,
        SunwTlssort = 1879048178,
        SunwLdynsym = 1879048179,
        SunwDof = 1879048180,
        SunwCap = 1879048181,
        SunwSignature = 1879048182,
        SunwAnnotate = 1879048183,
        SunwDebugstr = 1879048184,
        SunwDebug = 1879048185,
        SunwMove = 1879048186,
        SunwComdat = 1879048187,
        SunwSyminfo = 1879048188,
        SunwVerdef = 1879048189,
        SunwVerneed = 1879048190,
        SunwVersym = 1879048191,
        SparcGotdata = 1879048192,
        Amd64Unwind = 1879048193,
        ArmPreemptmap = 1879048194,
        ArmAttributes = 1879048195,
        ArmDebugoverlay = 1879048196,
        ArmOverlaysection = 1879048197,
    }

    public enum OsAbi
    {
        SystemV = 0,
        HpUx = 1,
        Netbsd = 2,
        Gnu = 3,
        Solaris = 6,
        Aix = 7,
        Irix = 8,
        Freebsd = 9,
        Tru64 = 10,
        Modesto = 11,
        Openbsd = 12,
        Openvms = 13,
        Nsk = 14,
        Aros = 15,
        Fenixos = 16,
        Cloudabi = 17,
        Openvos = 18,
    }

    public enum Machine
    {
        NoMachine = 0,
        M32 = 1,
        Sparc = 2,
        X86 = 3,
        M68k = 4,
        M88k = 5,
        Iamcu = 6,
        I860 = 7,
        Mips = 8,
        S370 = 9,
        MipsRs3Le = 10,
        Parisc = 15,
        Vpp500 = 17,
        Sparc32plus = 18,
        I960 = 19,
        Powerpc = 20,
        Powerpc64 = 21,
        S390 = 22,
        Spu = 23,
        V800 = 36,
        Fr20 = 37,
        Rh32 = 38,
        Rce = 39,
        Arm = 40,
        Alpha = 41,
        Superh = 42,
        SparcV9 = 43,
        Tricore = 44,
        Arc = 45,
        H8300 = 46,
        H8300h = 47,
        H8s = 48,
        H8500 = 49,
        Ia64 = 50,
        MipsX = 51,
        Coldfire = 52,
        M68hc12 = 53,
        Mma = 54,
        Pcp = 55,
        Ncpu = 56,
        Ndr1 = 57,
        Starcore = 58,
        Me16 = 59,
        St100 = 60,
        Tinyj = 61,
        X8664 = 62,
        Pdsp = 63,
        Pdp10 = 64,
        Pdp11 = 65,
        Fx66 = 66,
        St9plus = 67,
        St7 = 68,
        Mc68hc16 = 69,
        Mc68hc11 = 70,
        Mc68hc08 = 71,
        Mc68hc05 = 72,
        Svx = 73,
        St19 = 74,
        Vax = 75,
        Cris = 76,
        Javelin = 77,
        Firepath = 78,
        Zsp = 79,
        Mmix = 80,
        Huany = 81,
        Prism = 82,
        Avr = 83,
        Fr30 = 84,
        D10v = 85,
        D30v = 86,
        V850 = 87,
        M32r = 88,
        Mn10300 = 89,
        Mn10200 = 90,
        Picojava = 91,
        Openrisc = 92,
        ArcCompact = 93,
        Xtensa = 94,
        Videocore = 95,
        TmmGpp = 96,
        Ns32k = 97,
        Tpc = 98,
        Snp1k = 99,
        St200 = 100,
        Ip2k = 101,
        Max = 102,
        CompactRisc = 103,
        F2mc16 = 104,
        Msp430 = 105,
        Blackfin = 106,
        SeC33 = 107,
        Sep = 108,
        Arca = 109,
        Unicore = 110,
        Excess = 111,
        Dxp = 112,
        AlteraNios2 = 113,
        Crx = 114,
        Xgate = 115,
        C166 = 116,
        M16c = 117,
        Dspic30f = 118,
        FreescaleCe = 119,
        M32c = 120,
        Tsk3000 = 131,
        Rs08 = 132,
        Sharc = 133,
        Ecog2 = 134,
        Score7 = 135,
        Dsp24 = 136,
        Videocore3 = 137,
        Latticemico32 = 138,
        SeC17 = 139,
        TiC6000 = 140,
        TiC2000 = 141,
        TiC5500 = 142,
        TiArp32 = 143,
        TiPru = 144,
        MmdspPlus = 160,
        CypressM8c = 161,
        R32c = 162,
        Trimedia = 163,
        Qdsp6 = 164,
        I8051 = 165,
        Stxp7x = 166,
        Nds32 = 167,
        Ecog1x = 168,
        Maxq30 = 169,
        Ximo16 = 170,
        Manik = 171,
        Craynv2 = 172,
        Rx = 173,
        Metag = 174,
        McstElbrus = 175,
        Ecog16 = 176,
        Cr16 = 177,
        Etpu = 178,
        Sle9x = 179,
        L10m = 180,
        K10m = 181,
        Aarch64 = 183,
        Avr32 = 185,
        Stm8 = 186,
        Tile64 = 187,
        Tilepro = 188,
        Microblaze = 189,
        Cuda = 190,
        Tilegx = 191,
        Cloudshield = 192,
        Corea1st = 193,
        Corea2nd = 194,
        Arcv2 = 195,
        Open8 = 196,
        Rl78 = 197,
        Videocore5 = 198,
        Renesas78kor = 199,
        Freescale56800ex = 200,
        Ba1 = 201,
        Ba2 = 202,
        Xcore = 203,
        MchpPic = 204,
        Intelgt = 205,
        Intel206 = 206,
        Intel207 = 207,
        Intel208 = 208,
        Intel209 = 209,
        Km32 = 210,
        Kmx32 = 211,
        Kmx16 = 212,
        Kmx8 = 213,
        Kvarc = 214,
        Cdp = 215,
        Coge = 216,
        Cool = 217,
        Norc = 218,
        CsrKalimba = 219,
        Z80 = 220,
        Visium = 221,
        Ft32 = 222,
        Moxie = 223,
        AmdGpu = 224,
        Riscv = 243,
        Lanai = 244,
        Ceva = 245,
        CevaX2 = 246,
        Bpf = 247,
        GraphcoreIpu = 248,
        Img1 = 249,
        Nfp = 250,
        Ve = 251,
        Csky = 252,
        ArcCompact364 = 253,
        Mcs6502 = 254,
        ArcCompact3 = 255,
        Kvx = 256,
        Wdc65816 = 257,
        Loongarch = 258,
        Kf32 = 259,
    }

    public enum SymbolType
    {
        NoType = 0,
        Object = 1,
        Func = 2,
        Section = 3,
        File = 4,
        Common = 5,
        Tls = 6,
        Relc = 8,
        Srelc = 9,
        GnuIfunc = 10,
        Os11 = 11,
        Os12 = 12,
        Proc13 = 13,
        Proc14 = 14,
        Proc15 = 15,
    }

    public enum DynamicArrayTags
    {
        Null = 0,
        Needed = 1,
        Pltrelsz = 2,
        Pltgot = 3,
        Hash = 4,
        Strtab = 5,
        Symtab = 6,
        Rela = 7,
        Relasz = 8,
        Relaent = 9,
        Strsz = 10,
        Syment = 11,
        Init = 12,
        Fini = 13,
        Soname = 14,
        Rpath = 15,
        Symbolic = 16,
        Rel = 17,
        Relsz = 18,
        Relent = 19,
        Pltrel = 20,
        Debug = 21,
        Textrel = 22,
        Jmprel = 23,
        BindNow = 24,
        InitArray = 25,
        FiniArray = 26,
        InitArraysz = 27,
        FiniArraysz = 28,
        Runpath = 29,
        Flags = 30,
        PreinitArray = 32,
        PreinitArraysz = 33,
        SymtabShndx = 34,
        DeprecatedSparcRegister = 117440513,
        SunwAuxiliary = 1610612749,
        SunwRtldinf = 1610612750,
        SunwFilter = 1610612751,
        SunwCap = 1610612752,
        SunwSymtab = 1610612753,
        SunwSymsz = 1610612754,
        SunwSortent = 1610612755,
        SunwSymsort = 1610612756,
        SunwSymsortsz = 1610612757,
        SunwTlssort = 1610612758,
        SunwTlssortsz = 1610612759,
        SunwCapinfo = 1610612760,
        SunwStrpad = 1610612761,
        SunwCapchain = 1610612762,
        SunwLdmach = 1610612763,
        SunwSymtabShndx = 1610612764,
        SunwCapchainent = 1610612765,
        SunwDeferred = 1610612766,
        SunwCapchainsz = 1610612767,
        SunwPhname = 1610612768,
        SunwParent = 1610612769,
        SunwSxAslr = 1610612771,
        SunwRelax = 1610612773,
        SunwKmod = 1610612775,
        SunwSxNxheap = 1610612777,
        SunwSxNxstack = 1610612779,
        SunwSxAdiheap = 1610612781,
        SunwSxAdistack = 1610612783,
        SunwSxSsbd = 1610612785,
        SunwSymnsort = 1610612786,
        SunwSymnsortsz = 1610612787,
        GnuFlags1 = 1879047668,
        GnuPrelinked = 1879047669,
        GnuConflictsz = 1879047670,
        GnuLiblistsz = 1879047671,
        Checksum = 1879047672,
        Pltpadsz = 1879047673,
        Moveent = 1879047674,
        Movesz = 1879047675,
        Feature1 = 1879047676,
        Posflag1 = 1879047677,
        Syminsz = 1879047678,
        Syminent = 1879047679,
        GnuHash = 1879047925,
        TlsdescPlt = 1879047926,
        TlsdescGot = 1879047927,
        GnuConflict = 1879047928,
        GnuLiblist = 1879047929,
        Config = 1879047930,
        Depaudit = 1879047931,
        Audit = 1879047932,
        Pltpad = 1879047933,
        Movetab = 1879047934,
        Syminfo = 1879047935,
        Versym = 1879048176,
        Relacount = 1879048185,
        Relcount = 1879048186,
        Flags1 = 1879048187,
        Verdef = 1879048188,
        Verdefnum = 1879048189,
        Verneed = 1879048190,
        Verneednum = 1879048191,
        SparcRegister = 1879048193,
        Auxiliary = 2147483645,
        Used = 2147483646,
        Filter = 2147483647,
    }

    public enum Bits
    {
        B32 = 1,
        B64 = 2,
    }

    public enum PhType
    {
        NullType = 0,
        Load = 1,
        Dynamic = 2,
        Interp = 3,
        Note = 4,
        Shlib = 5,
        Phdr = 6,
        Tls = 7,
        GnuEhFrame = 1685382480,
        GnuStack = 1685382481,
        GnuRelro = 1685382482,
        GnuProperty = 1685382483,
        PaxFlags = 1694766464,
        PT_LOPROC = 1879048192,
        ArmExidx = 1879048193,
    }

    public enum ObjType
    {
        NoFileType = 0,
        Relocatable = 1,
        Executable = 2,
        Shared = 3,
        Core = 4,
    }

    public enum SectionHeaderIdxSpecial
    {
        Undefined = 0,
        Before = 65280,
        After = 65281,
        Amd64Lcommon = 65282,
        SunwIgnore = 65343,
        Abs = 65521,
        Common = 65522,
        Xindex = 65535,
    }
}

