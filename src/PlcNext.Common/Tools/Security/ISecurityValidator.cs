﻿#region Copyright
///////////////////////////////////////////////////////////////////////////////
//
//  Copyright (c) Phoenix Contact GmbH & Co KG
//  This software is licensed under Apache-2.0
//
///////////////////////////////////////////////////////////////////////////////
#endregion

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace PlcNext.Common.Tools.Security
{
    internal interface ISecurityValidator
    {
        void ValidateSignature(Stream dataStream, Stream signatureStream, Stream publicKeyStream);
        void ValidateHash(Stream dataStream, byte[] hash, string hashAlgorithmName);
    }
}
