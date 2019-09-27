﻿#region Copyright
///////////////////////////////////////////////////////////////////////////////
//
//  Copyright (c) Phoenix Contact GmbH & Co KG
//  This software is licensed under Apache-2.0
//
///////////////////////////////////////////////////////////////////////////////
#endregion


// This file is used by Code Analysis to maintain SuppressMessage 
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given 
// a specific target and scoped to a namespace, type, member, etc.

[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA1031:Modify 'SendUpdate' to catch a more specific exception type, or rethrow the exception.", Justification = "Exception is purposefully logged and ignored.", Scope = "member", Target = "~M:PlcNext.CliNamedPipeMediator.UpdateMessagesMediator.SendUpdate(System.Action{PlcNext.NamedPipeServer.Communication.IInstanceMessageSender,Nito.AsyncEx.AsyncAutoResetEvent})~System.Threading.Tasks.Task")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA1031:Modify 'ConstructHelp' to catch a more specific exception type, or rethrow the exception.", Justification = "Exception is purposefully logged and ignored.", Scope = "member", Target = "~M:PlcNext.CommandLine.CommandLineParser.ConstructHelp(CommandLine.ParserResult{System.Object},PlcNext.CommandLine.ParserTypeInfo)~System.String")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA1308:In method 'ConstructHelp', replace the call to 'ToLowerInvariant' with 'ToUpperInvariant'.", Justification = "Command name must be lower case.", Scope = "member", Target = "~M:PlcNext.CommandLine.CommandLineParser.ConstructHelp(CommandLine.ParserResult{System.Object},PlcNext.CommandLine.ParserTypeInfo)~System.String")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA1031:Modify 'CreateHeadingInfo' to catch a more specific exception type, or rethrow the exception.", Justification = "Exception is purposefully logged and ignored.", Scope = "member", Target = "~M:PlcNext.CommandLine.CommandLineParser.CreateHeadingInfo~CommandLine.Text.HeadingInfo")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA1031:Modify 'Execute' to catch a more specific exception type, or rethrow the exception.", Justification = "Exception is purposefully logged and ignored.", Scope = "member", Target = "~M:PlcNext.CommandLine.ShowLogVerb.Execute(PlcNext.Common.Commands.ICommandManager)~System.Threading.Tasks.Task{System.Int32}")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA1031:Modify 'AddInitialLog' to catch a more specific exception type, or rethrow the exception.", Justification = "Exception is purposefully logged and ignored.", Scope = "member", Target = "~M:PlcNext.LogHelper.AddInitialLog(PlcNext.Common.Tools.UI.ILog,System.String[])")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA1031:Modify 'Execute' to catch a more specific exception type, or rethrow the exception.", Justification = "Exception is purposefully logged and ignored.", Scope = "member", Target = "~M:PlcNext.Migration.MigrationChain.Execute~System.Boolean")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA1031:Modify 'MainAsync' to catch a more specific exception type, or rethrow the exception.", Justification = "Exception is purposefully logged and ignored.", Scope = "member", Target = "~M:PlcNext.Program.MainAsync(System.String[])~System.Threading.Tasks.Task{System.Int32}")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA1812:UpdateMessagesMediator is an internal class that is apparently never instantiated. If so, remove the code from the assembly. If this class is intended to contain only static members, make it static (Shared in Visual Basic).", Justification = "Create by DI container.", Scope = "type", Target = "~T:PlcNext.CliNamedPipeMediator.UpdateMessagesMediator")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA1812:BuildVerb is an internal class that is apparently never instantiated. If so, remove the code from the assembly. If this class is intended to contain only static members, make it static (Shared in Visual Basic).", Justification = "Create by DI container.", Scope = "type", Target = "~T:PlcNext.CommandLine.BuildVerb")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA1812:CollectiveDynamicVerbsFactory is an internal class that is apparently never instantiated. If so, remove the code from the assembly. If this class is intended to contain only static members, make it static (Shared in Visual Basic).", Justification = "Create by DI container.", Scope = "type", Target = "~T:PlcNext.CommandLine.CollectiveDynamicVerbsFactory")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA1812:CommandLineParser is an internal class that is apparently never instantiated. If so, remove the code from the assembly. If this class is intended to contain only static members, make it static (Shared in Visual Basic).", Justification = "Create by DI container.", Scope = "type", Target = "~T:PlcNext.CommandLine.CommandLineParser")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA1812:DynamicVerb is an internal class that is apparently never instantiated. If so, remove the code from the assembly. If this class is intended to contain only static members, make it static (Shared in Visual Basic).", Justification = "Create by DI container.", Scope = "type", Target = "~T:PlcNext.CommandLine.DynamicVerb")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA1812:GenerateLibraryVerb is an internal class that is apparently never instantiated. If so, remove the code from the assembly. If this class is intended to contain only static members, make it static (Shared in Visual Basic).", Justification = "Create by DI container.", Scope = "type", Target = "~T:PlcNext.CommandLine.GenerateLibraryVerb")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA1812:GetCompilerSpecificationsVerb is an internal class that is apparently never instantiated. If so, remove the code from the assembly. If this class is intended to contain only static members, make it static (Shared in Visual Basic).", Justification = "Create by DI container.", Scope = "type", Target = "~T:PlcNext.CommandLine.GetCompilerSpecificationsVerb")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA1812:GetComponentsVerb is an internal class that is apparently never instantiated. If so, remove the code from the assembly. If this class is intended to contain only static members, make it static (Shared in Visual Basic).", Justification = "Create by DI container.", Scope = "type", Target = "~T:PlcNext.CommandLine.GetComponentsVerb")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA1812:GetIncludePathsVerb is an internal class that is apparently never instantiated. If so, remove the code from the assembly. If this class is intended to contain only static members, make it static (Shared in Visual Basic).", Justification = "Create by DI container.", Scope = "type", Target = "~T:PlcNext.CommandLine.GetIncludePathsVerb")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA1812:GetProgramsVerb is an internal class that is apparently never instantiated. If so, remove the code from the assembly. If this class is intended to contain only static members, make it static (Shared in Visual Basic).", Justification = "Create by DI container.", Scope = "type", Target = "~T:PlcNext.CommandLine.GetProgramsVerb")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA1812:GetProjectInformationVerb is an internal class that is apparently never instantiated. If so, remove the code from the assembly. If this class is intended to contain only static members, make it static (Shared in Visual Basic).", Justification = "Create by DI container.", Scope = "type", Target = "~T:PlcNext.CommandLine.GetProjectInformationVerb")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA1812:GetProjectSdksVerb is an internal class that is apparently never instantiated. If so, remove the code from the assembly. If this class is intended to contain only static members, make it static (Shared in Visual Basic).", Justification = "Create by DI container.", Scope = "type", Target = "~T:PlcNext.CommandLine.GetProjectSdksVerb")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA1812:GetProjectTargetsVerb is an internal class that is apparently never instantiated. If so, remove the code from the assembly. If this class is intended to contain only static members, make it static (Shared in Visual Basic).", Justification = "Create by DI container.", Scope = "type", Target = "~T:PlcNext.CommandLine.GetProjectTargetsVerb")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA1812:GetSdksVerb is an internal class that is apparently never instantiated. If so, remove the code from the assembly. If this class is intended to contain only static members, make it static (Shared in Visual Basic).", Justification = "Create by DI container.", Scope = "type", Target = "~T:PlcNext.CommandLine.GetSdksVerb")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA1812:GetSettingVerb is an internal class that is apparently never instantiated. If so, remove the code from the assembly. If this class is intended to contain only static members, make it static (Shared in Visual Basic).", Justification = "Create by DI container.", Scope = "type", Target = "~T:PlcNext.CommandLine.GetSettingVerb")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA1812:GetTargetsVerb is an internal class that is apparently never instantiated. If so, remove the code from the assembly. If this class is intended to contain only static members, make it static (Shared in Visual Basic).", Justification = "Create by DI container.", Scope = "type", Target = "~T:PlcNext.CommandLine.GetTargetsVerb")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA1812:GetUpdateVersionsVerb is an internal class that is apparently never instantiated. If so, remove the code from the assembly. If this class is intended to contain only static members, make it static (Shared in Visual Basic).", Justification = "Create by DI container.", Scope = "type", Target = "~T:PlcNext.CommandLine.GetUpdateVersionsVerb")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA1812:InstallSdkVerb is an internal class that is apparently never instantiated. If so, remove the code from the assembly. If this class is intended to contain only static members, make it static (Shared in Visual Basic).", Justification = "Create by DI container.", Scope = "type", Target = "~T:PlcNext.CommandLine.InstallSdkVerb")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA1812:ScanSdksVerb is an internal class that is apparently never instantiated. If so, remove the code from the assembly. If this class is intended to contain only static members, make it static (Shared in Visual Basic).", Justification = "Create by DI container.", Scope = "type", Target = "~T:PlcNext.CommandLine.ScanSdksVerb")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA1812:SetSettingsVerb is an internal class that is apparently never instantiated. If so, remove the code from the assembly. If this class is intended to contain only static members, make it static (Shared in Visual Basic).", Justification = "Create by DI container.", Scope = "type", Target = "~T:PlcNext.CommandLine.SetSettingsVerb")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA1812:SetTargetsVerb is an internal class that is apparently never instantiated. If so, remove the code from the assembly. If this class is intended to contain only static members, make it static (Shared in Visual Basic).", Justification = "Create by DI container.", Scope = "type", Target = "~T:PlcNext.CommandLine.SetTargetsVerb")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA1812:StartServerVerb is an internal class that is apparently never instantiated. If so, remove the code from the assembly. If this class is intended to contain only static members, make it static (Shared in Visual Basic).", Justification = "Create by DI container.", Scope = "type", Target = "~T:PlcNext.CommandLine.StartServerVerb")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA1812:UpdateCliVerb is an internal class that is apparently never instantiated. If so, remove the code from the assembly. If this class is intended to contain only static members, make it static (Shared in Visual Basic).", Justification = "Create by DI container.", Scope = "type", Target = "~T:PlcNext.CommandLine.UpdateCliVerb")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA1812:UpdateProjectTargetsVerb is an internal class that is apparently never instantiated. If so, remove the code from the assembly. If this class is intended to contain only static members, make it static (Shared in Visual Basic).", Justification = "Create by DI container.", Scope = "type", Target = "~T:PlcNext.CommandLine.UpdateProjectTargetsVerb")]