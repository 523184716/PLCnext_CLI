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

namespace PlcNext {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class MessageResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal MessageResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("PlcNext.MessageResources", typeof(MessageResources).Assembly);
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
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Message received:.
        /// </summary>
        public static string ClientMessageReceived {
            get {
                return ResourceManager.GetString("ClientMessageReceived", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Sending message....
        /// </summary>
        public static string ClientSendingMessage {
            get {
                return ResourceManager.GetString("ClientSendingMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Server disconnected..
        /// </summary>
        public static string ClientServerDisconnectedMessage {
            get {
                return ResourceManager.GetString("ClientServerDisconnectedMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Connected to server..
        /// </summary>
        public static string ClientStarted {
            get {
                return ResourceManager.GetString("ClientStarted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Starting client listening to {0}.
        /// </summary>
        public static string ClientStarting {
            get {
                return ResourceManager.GetString("ClientStarting", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Client connected..
        /// </summary>
        public static string ServerStartedMessage {
            get {
                return ResourceManager.GetString("ServerStartedMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Server was stopped or client disconnected..
        /// </summary>
        public static string ServerStopped {
            get {
                return ResourceManager.GetString("ServerStopped", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Starting named pipe server on {0}. Waiting for client....
        /// </summary>
        public static string StartingServerMessage {
            get {
                return ResourceManager.GetString("StartingServerMessage", resourceCulture);
            }
        }
    }
}
