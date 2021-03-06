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
using System.Text;

namespace PlcNext.Common.Tools.UI
{
    public interface IOutputFormatter
    {
        bool CanFormat(FormatterParameters parameters);

        IUserInterface Format(IUserInterface wrappedUserInterface);
    }
}
