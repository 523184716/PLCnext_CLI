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
using System.Globalization;
using System.Text;
using PlcNext.Common.Tools;

namespace PlcNext.Common.Templates
{
    internal class RelationshipMultiplicityMismatchException : FormattableException
    {
        public RelationshipMultiplicityMismatchException(string relationshipName, string name, bool isType=true):base(string.Format(CultureInfo.InvariantCulture, ExceptionTexts.RelationshipMultiplicityMismatch, relationshipName, isType?$"the type '{name}'":$"the template '{name}'"))
        {
            
        }
    }
}
