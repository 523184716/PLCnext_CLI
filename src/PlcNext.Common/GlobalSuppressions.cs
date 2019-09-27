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

[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA1308:In method 'GenerateCommandOptions', replace the call to 'ToLowerInvariant' with 'ToUpperInvariant'.", Justification = "Lower case is not used as comparsion but as value.", Scope = "member", Target = "~M:PlcNext.Common.Build.EngineeringLibraryBuilderExecuter.GenerateCommandOptions(PlcNext.Common.Project.ProjectEntity,System.Collections.Generic.Dictionary{PlcNext.Common.DataModel.Entity,PlcNext.Common.Tools.FileSystem.VirtualFile})~System.String")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA1308:In method 'DeployFiles', replace the call to 'ToLowerInvariant' with 'ToUpperInvariant'.", Justification = "Lower case is not used as comparsion but as value.", Scope = "member", Target = "~M:PlcNext.Common.Deploy.DeployService.DeployFiles(PlcNext.Common.DataModel.Entity)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA1031:Modify 'FindAllEntities' to catch a more specific exception type, or rethrow the exception.", Justification = "Exception is purposefully logged and ignored.", Scope = "member", Target = "~M:PlcNext.Common.Project.ProjectSettingsProvider.FindAllEntities(System.String,PlcNext.Common.DataModel.Entity)~System.Collections.Generic.IEnumerable{PlcNext.Common.DataModel.Entity}")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA1031:Modify 'Resolve' to catch a more specific exception type, or rethrow the exception.", Justification = "Exception is purposefully logged and ignored.", Scope = "member", Target = "~M:PlcNext.Common.Project.RootEntityContentProvider.Resolve(PlcNext.Common.DataModel.Entity,System.String,System.Boolean)~PlcNext.Common.DataModel.Entity")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA1308:In method 'GenerateNewCommandDefinition', replace the call to 'ToLowerInvariant' with 'ToUpperInvariant'.", Justification = "Lower case is not used as comparsion but as value.", Scope = "member", Target = "~M:PlcNext.Common.Templates.TemplateCommandBuilder.GenerateNewCommandDefinition(PlcNext.Common.DataModel.Entity,PlcNext.Common.Templates.Description.TemplateDescription,PlcNext.Common.Tools.DynamicCommands.CommandDefinition,System.Collections.Generic.IEnumerable{PlcNext.Common.Templates.Description.TemplateDescription})~PlcNext.Common.Tools.DynamicCommands.CommandDefinition")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA1308:In method 'ParseExample', replace the call to 'ToLowerInvariant' with 'ToUpperInvariant'.", Justification = "Lower case is not used as comparsion but as value.", Scope = "member", Target = "~M:PlcNext.Common.Templates.TemplateCommandBuilder.ParseExample(PlcNext.Common.Templates.Description.TemplateDescription,PlcNext.Common.Templates.Description.templateExample,System.Text.StringBuilder,System.Boolean)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA1308:In method 'GetCommands', replace the call to 'ToLowerInvariant' with 'ToUpperInvariant'.", Justification = "Lower case is not used as comparsion but as value.", Scope = "member", Target = "~M:PlcNext.Common.Templates.TemplateCommandProvider.GetCommands(System.Collections.Generic.IEnumerable{System.String})~System.Collections.Generic.IEnumerable{PlcNext.Common.Tools.DynamicCommands.CommandDefinition}")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA1308:In method 'Resolve', replace the call to 'ToLowerInvariant' with 'ToUpperInvariant'.", Justification = "Lower case is not used as comparsion but as value.", Scope = "member", Target = "~M:PlcNext.Common.Templates.TemplateContentProvider.Resolve(PlcNext.Common.DataModel.Entity,System.String,System.Boolean)~PlcNext.Common.DataModel.Entity")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA1308:In method 'GenerateFiles', replace the call to 'ToLowerInvariant' with 'ToUpperInvariant'.", Justification = "Lower case is not used as comparsion but as value.", Scope = "member", Target = "~M:PlcNext.Common.Templates.TemplateFileGenerator.GenerateFiles(PlcNext.Common.DataModel.Entity,System.String,System.String,System.Boolean,PlcNext.Common.Tools.Events.ChangeObservable)~System.Threading.Tasks.Task")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA1308:In method 'ResolveTextControlSequences', replace the call to 'ToLowerInvariant' with 'ToUpperInvariant'.", Justification = "Lower case is not used as comparsion but as value.", Scope = "member", Target = "~M:PlcNext.Common.Templates.TemplateResolver.ResolveTextControlSequences(System.String)~System.String")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA1308:In method 'ToPropertyName', replace the call to 'ToLowerInvariant' with 'ToUpperInvariant'.", Justification = "Lower case is not used as comparsion but as value.", Scope = "member", Target = "~M:PlcNext.Common.Tools.Extensions.ToPropertyName(System.String)~System.String")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA2208:Method Create passes 'T' as the paramName argument to a ArgumentException constructor. Replace this argument with one of the method's parameter names. Note that the provided parameter name should have the exact casing as declared on the method.", Justification = "Is generic argument.", Scope = "member", Target = "~M:PlcNext.Common.Tools.FileSystem.DirectoryInfoContentResolver.Create``1(System.String)~``0")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA1031:Modify 'CheckAccess' to catch a more specific exception type, or rethrow the exception.", Justification = "Exception is purposefully logged and ignored.", Scope = "member", Target = "~M:PlcNext.Common.Tools.FileSystem.FileInfoContentResolver.CheckAccess~System.Boolean")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA1031:Modify 'EnsureMemento' to catch a more specific exception type, or rethrow the exception.", Justification = "Exception is purposefully logged and ignored.", Scope = "member", Target = "~M:PlcNext.Common.Tools.FileSystem.FileInfoContentResolver.EnsureMemento")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA1031:Modify 'Dispose' to catch a more specific exception type, or rethrow the exception.", Justification = "Exception is purposefully logged and ignored.", Scope = "member", Target = "~M:PlcNext.Common.Tools.IO.PageBuffer.Dispose(System.Boolean)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA1814:Compute uses a multidimensional array of int[*,*]. Replace it with a jagged array if possible.", Justification = "Not necessary with this array as it never gets to big.", Scope = "member", Target = "~M:PlcNext.Common.Tools.LevenshteinDistance.Compute(System.String,System.String)~System.Int32")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA1031:Modify '.ctor' to catch a more specific exception type, or rethrow the exception.", Justification = "Exception is purposefully logged and ignored.", Scope = "member", Target = "~M:PlcNext.Common.Tools.Process.ProcessFacade.#ctor(System.String,System.String,System.String,PlcNext.Common.Tools.ExecutionContext,System.Boolean,System.Boolean,System.Boolean,System.Runtime.InteropServices.OSPlatform,System.Threading.CancellationToken)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA1031:Modify 'Dispose' to catch a more specific exception type, or rethrow the exception.", Justification = "Exception is purposefully logged and ignored.", Scope = "member", Target = "~M:PlcNext.Common.Tools.Process.ProcessFacade.Dispose")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA1031:Modify '.ctor' to catch a more specific exception type, or rethrow the exception.", Justification = "Exception is purposefully logged and ignored.", Scope = "member", Target = "~M:PlcNext.Common.Tools.UI.ConsoleUserInterface.#ctor(PlcNext.Common.Tools.Settings.ISettingsProvider,PlcNext.Common.Tools.IEnvironmentService,PlcNext.Common.Tools.UI.ILog)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA1031:Modify 'Create' to catch a more specific exception type, or rethrow the exception.", Justification = "Exception is purposefully logged and ignored.", Scope = "member", Target = "~M:PlcNext.Common.Tools.UI.FileLog.Create(System.String)~PlcNext.Common.Tools.UI.FileLog")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA1031:Modify 'CreateNewLog' to catch a more specific exception type, or rethrow the exception.", Justification = "Exception is purposefully logged and ignored.", Scope = "member", Target = "~M:PlcNext.Common.Tools.UI.LogCatalog.CreateNewLog(System.String,System.String)~PlcNext.Common.Tools.UI.ILog")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA1716:Rename virtual/interface member IType.Namespace so that it no longer conflicts with the reserved language keyword 'Namespace'. Using a reserved keyword as the name of a virtual/interface member makes it harder for consumers in other languages to override/implement the member.", Justification = "It is a namespace.", Scope = "member", Target = "~P:PlcNext.Common.CodeModel.IType.Namespace")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA1308:In method 'get_Item', replace the call to 'ToLowerInvariant' with 'ToUpperInvariant'.", Justification = "Lower case is not used as comparsion but as value.", Scope = "member", Target = "~P:PlcNext.Common.DataModel.Entity.Item(System.String)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA1710:Rename PlcNext.Common.Build.BuildEntity to end in 'Collection'.", Justification = "It is no collection.", Scope = "type", Target = "~T:PlcNext.Common.Build.BuildEntity")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA1710:Rename PlcNext.Common.CodeModel.CodeEntity to end in 'Collection'.", Justification = "It is no collection.", Scope = "type", Target = "~T:PlcNext.Common.CodeModel.CodeEntity")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA1710:Rename PlcNext.Common.Commands.CommandEntity to end in 'Collection'.", Justification = "It is no collection.", Scope = "type", Target = "~T:PlcNext.Common.Commands.CommandEntity")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA1710:Rename PlcNext.Common.DataModel.Entity to end in 'Collection'.", Justification = "It is no collection.", Scope = "type", Target = "~T:PlcNext.Common.DataModel.Entity")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA1710:Rename PlcNext.Common.DataModel.EntityBaseDecorator to end in 'Collection'.", Justification = "It is no collection.", Scope = "type", Target = "~T:PlcNext.Common.DataModel.EntityBaseDecorator")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA1710:Rename PlcNext.Common.DataModel.IEntityBase to end in 'Collection'.", Justification = "It is no collection.", Scope = "type", Target = "~T:PlcNext.Common.DataModel.IEntityBase")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA1710:Rename PlcNext.Common.Deploy.DeployEntity to end in 'Collection'.", Justification = "It is no collection.", Scope = "type", Target = "~T:PlcNext.Common.Deploy.DeployEntity")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA1710:Rename PlcNext.Common.Project.ProjectEntity to end in 'Collection'.", Justification = "It is no collection.", Scope = "type", Target = "~T:PlcNext.Common.Project.ProjectEntity")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA1710:Rename PlcNext.Common.Project.TargetEntity to end in 'Collection'.", Justification = "It is no collection.", Scope = "type", Target = "~T:PlcNext.Common.Project.TargetEntity")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA1710:Rename PlcNext.Common.Templates.TemplateEntity to end in 'Collection'.", Justification = "It is no collection.", Scope = "type", Target = "~T:PlcNext.Common.Templates.TemplateEntity")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA1710:Rename PlcNext.Common.Tools.FileSystem.FileEntity to end in 'Collection'.", Justification = "It is no collection.", Scope = "type", Target = "~T:PlcNext.Common.Tools.FileSystem.FileEntity")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA1724:The type name Settings conflicts in whole or in part with the namespace name 'PlcNext.Common.Tools.Settings'. Change either name to eliminate the conflict.", Justification = "Not possible because the name is used as output.", Scope = "type", Target = "~T:PlcNext.Common.Tools.Settings.Settings")]
