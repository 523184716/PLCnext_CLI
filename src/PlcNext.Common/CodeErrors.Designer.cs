﻿#region Copyright
///////////////////////////////////////////////////////////////////////////////
//
//  Copyright (c) Phoenix Contact GmbH & Co KG
//  This software is licensed under Apache-2.0
//
///////////////////////////////////////////////////////////////////////////////
#endregion

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PlcNext.Common {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class CodeErrors {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal CodeErrors() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("PlcNext.Common.CodeErrors", typeof(CodeErrors).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The restriction for the values of the attribute &apos;{0}&apos; does not allow the value &apos;{1}&apos;. {2}.
        /// </summary>
        internal static string ARP0001 {
            get {
                return ResourceManager.GetString("ARP0001", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No fields definied for the specified type..
        /// </summary>
        internal static string CPP0001 {
            get {
                return ResourceManager.GetString("CPP0001", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The type is already defined in the same namespace..
        /// </summary>
        internal static string CPP0002 {
            get {
                return ResourceManager.GetString("CPP0002", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No type name defined..
        /// </summary>
        internal static string CPP0003 {
            get {
                return ResourceManager.GetString("CPP0003", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to File could not be parsed..
        /// </summary>
        internal static string CPP0004 {
            get {
                return ResourceManager.GetString("CPP0004", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A parsing exception was thrown.{0}.
        /// </summary>
        internal static string CPP0005 {
            get {
                return ResourceManager.GetString("CPP0005", resourceCulture);
            }
        }
    }
}
