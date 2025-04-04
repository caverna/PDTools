﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

using Syroot.BinaryData;

namespace PDTools.Files.Models.PS2.RenderCommands;

/// <summary>
/// Sets GS TEST register bit 15 - DATM (Destination Alpha Test Mode)
/// </summary>
public class Cmd_pglSetDestinationAlphaFunc : ModelSetupPS2Command
{
    public override ModelSetupPS2Opcode Opcode => ModelSetupPS2Opcode.pglSetDestinationAlphaFunc;

    /// <summary>
    /// 2 = Set GS_TEST DATM bit to 0 - Pixels with destination equal to 0 pass
    /// 5 = Set GS_TEST DATM bit to 1 - Pixels with destination equal to 1 pass
    /// </summary>
    public DestinationAlphaFunction Func { get; set; }

    public Cmd_pglSetDestinationAlphaFunc()
    {

    }

    public Cmd_pglSetDestinationAlphaFunc(DestinationAlphaFunction func)
    {
        Func = func;
    }

    public override void Read(BinaryStream bs, int commandsBaseOffset)
    {
        Func = (DestinationAlphaFunction)bs.Read1Byte();
    }

    public override void Write(BinaryStream bs)
    {
        bs.WriteByte((byte)Func);
    }

    public override string ToString()
    {
        return $"{nameof(Cmd_pglSetDestinationAlphaFunc)}";
    }
}

public enum DestinationAlphaFunction
{
    /// <summary>
    /// 2 = Set GS_TEST DATM bit to 0 - Pixels with destination equal to 0 pass
    /// </summary>
    EQUAL_ZERO = 2,

    /// <summary>
    /// 5 = Set GS_TEST DATM bit to 1 - Pixels with destination equal to 1 pass
    /// </summary>
    EQUAL_ONE = 5,
}
