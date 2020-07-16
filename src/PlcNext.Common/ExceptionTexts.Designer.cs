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
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class ExceptionTexts {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ExceptionTexts() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("PlcNext.Common.ExceptionTexts", typeof(ExceptionTexts).Assembly);
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
        ///   Looks up a localized string similar to The specified {0} &apos;{1}&apos; is ambiguous for the types:{2}.
        /// </summary>
        internal static string AmbiguousRelationshipType {
            get {
                return ResourceManager.GetString("AmbiguousRelationshipType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The argument &apos;{0}&apos; used in an example is not defined in the template &apos;{1}&apos;..
        /// </summary>
        internal static string ArgumentNotFound {
            get {
                return ResourceManager.GetString("ArgumentNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The restriction for the argument &apos;{0}&apos; does not allow the value &apos;{1}&apos;. {2}.
        /// </summary>
        internal static string ArgumentRestriction {
            get {
                return ResourceManager.GetString("ArgumentRestriction", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The setting &apos;{0}&apos; is a boolean setting. The value &apos;{1}&apos; is not allowed. Please use either &apos;true&apos; or &apos;false&apos;..
        /// </summary>
        internal static string BoolSettingsValueFormat {
            get {
                return ResourceManager.GetString("BoolSettingsValueFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There is no &apos;{0}&apos; available for the element &apos;{1}&apos;..
        /// </summary>
        internal static string CannotResolveContent {
            get {
                return ResourceManager.GetString("CannotResolveContent", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not find cmake build system in {0}. No external libraries will be added to library. Libraries can be added manually via option --externallibraries.
        /// </summary>
        internal static string CMakeBuildSystemNotFound {
            get {
                return ResourceManager.GetString("CMakeBuildSystemNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not find cmake build system for the target {0} and build type {1}. No external libraries will be added to library. Libraries can be added manually via option --files..
        /// </summary>
        internal static string CMakeBuildSystemNotFoundWithoutPath {
            get {
                return ResourceManager.GetString("CMakeBuildSystemNotFoundWithoutPath", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to While exploring the SDK &apos;{0}&apos; an error occured..
        /// </summary>
        internal static string CMakeExploration {
            get {
                return ResourceManager.GetString("CMakeExploration", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No CMake file was found..
        /// </summary>
        internal static string CMakeFileNotFound {
            get {
                return ResourceManager.GetString("CMakeFileNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The specified component is ambiguous for this project..
        /// </summary>
        internal static string ComponentAmbiguous {
            get {
                return ResourceManager.GetString("ComponentAmbiguous", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot find parent component {0} for program {1}..
        /// </summary>
        internal static string ComponentNotFound {
            get {
                return ResourceManager.GetString("ComponentNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to resolving the value of an entity.
        /// </summary>
        internal static string ContentProviderCycle {
            get {
                return ResourceManager.GetString("ContentProviderCycle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There is a control sequence &apos;{0}&apos; without the matching end tag &apos;end-{0}&apos;..
        /// </summary>
        internal static string ControlSequenceEndTagNotFound {
            get {
                return ResourceManager.GetString("ControlSequenceEndTagNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The following cycle was detected while {0}:{1}.
        /// </summary>
        internal static string Cycle {
            get {
                return ResourceManager.GetString("Cycle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No deployment source file was found with {0}. Please specify only existing files or paths..
        /// </summary>
        internal static string DeploymentFileNotFound {
            get {
                return ResourceManager.GetString("DeploymentFileNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The file &apos;{0}&apos; is not reachable..
        /// </summary>
        internal static string DownloadFileUnreachable {
            get {
                return ResourceManager.GetString("DownloadFileUnreachable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} not found inside project {1}.{2}Existing items are:{2}{3}.
        /// </summary>
        internal static string EntityNotFound {
            get {
                return ResourceManager.GetString("EntityNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The restriction for the values of the attribute &apos;{0}&apos; does not allow the value &apos;{1}&apos;. {2}.
        /// </summary>
        internal static string FieldAttributeRestriction {
            get {
                return ResourceManager.GetString("FieldAttributeRestriction", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The file &apos;{0}&apos; of the {2} could not be created, because it exists already.{1}Use &apos;--force&apos; to override..
        /// </summary>
        internal static string FileExists {
            get {
                return ResourceManager.GetString("FileExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There are files in the destination directory &apos;{0}&apos;.{1}Use &apos;--force&apos; to override..
        /// </summary>
        internal static string FilesExistingInsideDirectory {
            get {
                return ResourceManager.GetString("FilesExistingInsideDirectory", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The foreach control sequence must be in the form $([foreach]&lt;element-name&gt;[in]&lt;collection&gt;[of-type]&lt;element-type&gt;) where the [of-type] part is optional. The form &apos;$([foreach]{0})&apos; is not allowed..
        /// </summary>
        internal static string ForeachSequenceParameterMismatch {
            get {
                return ResourceManager.GetString("ForeachSequenceParameterMismatch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The format template &apos;{0}&apos; was applied to &apos;{1}&apos;, but accepts only &apos;{2}&apos; as a target..
        /// </summary>
        internal static string FormatTargetMismatch {
            get {
                return ResourceManager.GetString("FormatTargetMismatch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The hash of the file &apos;{0}&apos; does not match with the file. The file is corrupt..
        /// </summary>
        internal static string HashValidationFailure {
            get {
                return ResourceManager.GetString("HashValidationFailure", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The if-xxx control sequence must be in the form $([if-xxx]&lt;content-name&gt;). An empty content-name is not allowed..
        /// </summary>
        internal static string IfSequenceParameterMismatch {
            get {
                return ResourceManager.GetString("IfSequenceParameterMismatch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The relative uri &apos;{0}&apos; is no valid uri format..
        /// </summary>
        internal static string InvalidRelativUriFormat {
            get {
                return ResourceManager.GetString("InvalidRelativUriFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The uri &apos;{0}&apos; is no valid uri format..
        /// </summary>
        internal static string InvalidUriFormat {
            get {
                return ResourceManager.GetString("InvalidUriFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The library builder could not be found..
        /// </summary>
        internal static string LibraryBuilderNotFound {
            get {
                return ResourceManager.GetString("LibraryBuilderNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The id {0} is no valid GUID for the library..
        /// </summary>
        internal static string LibraryIdMalformatted {
            get {
                return ResourceManager.GetString("LibraryIdMalformatted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No library file was found in the path &apos;{0}&apos;..
        /// </summary>
        internal static string LibraryNotFound {
            get {
                return ResourceManager.GetString("LibraryNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} is neither an existing file nor a valid {1}: {2}.
        /// </summary>
        internal static string MalformedExternalLibrariesOption {
            get {
                return ResourceManager.GetString("MalformedExternalLibrariesOption", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Metafile {1} not found in directory &apos;{0}&apos;..
        /// </summary>
        internal static string MetaFileNotFound {
            get {
                return ResourceManager.GetString("MetaFileNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No &apos;.libmeta&apos; file was found in the directory &apos;{0}&apos;..
        /// </summary>
        internal static string MetaLibraryNotFound {
            get {
                return ResourceManager.GetString("MetaLibraryNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The base data type of the enum &apos;{0}&apos; is missing. For ports and port structures only known data types can be used as base types..
        /// </summary>
        internal static string MissingEnumDataType {
            get {
                return ResourceManager.GetString("MissingEnumDataType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The following possible namespaces were found for the project. Only one namespace is allowed.{0}.
        /// </summary>
        internal static string MultipleRootNamespaces {
            get {
                return ResourceManager.GetString("MultipleRootNamespaces", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The following possible namespaces were found for the project. Only one namespace is allowed for targets prior to 2020.6.0.{0}.
        /// </summary>
        internal static string MultipleRootNamespacesForTarget {
            get {
                return ResourceManager.GetString("MultipleRootNamespacesForTarget", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Project {0} has no assigned targets.{1}Please specify a target to execute the build..
        /// </summary>
        internal static string NoAssignedTargets {
            get {
                return ResourceManager.GetString("NoAssignedTargets", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The no-duplicate-lines control sequence must be in the form $([no-duplicate-lines]). Additional parameter inside the braces are not allowed..
        /// </summary>
        internal static string NoDuplicateLinesParameterMismatch {
            get {
                return ResourceManager.GetString("NoDuplicateLinesParameterMismatch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No higher target available for target &apos;{0}&apos;. Use --downgrade option, remove project-target via set setting or install higher target version. .
        /// </summary>
        internal static string NoHigherTargetAvailable {
            get {
                return ResourceManager.GetString("NoHigherTargetAvailable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No SDK was found for target {0}..
        /// </summary>
        internal static string NoSdkForTarget {
            get {
                return ResourceManager.GetString("NoSdkForTarget", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There is no target specified for the project. Please use --target to specify for which targets the deploy shall be executed..
        /// </summary>
        internal static string NoTargetSpecified {
            get {
                return ResourceManager.GetString("NoTargetSpecified", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No project was found inside the directory {0}..
        /// </summary>
        internal static string ProjectMissing {
            get {
                return ResourceManager.GetString("ProjectMissing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The public key file for the cli update repository is missing. Without it the repository cannot be verified..
        /// </summary>
        internal static string PublicKeyFileMissing {
            get {
                return ResourceManager.GetString("PublicKeyFileMissing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The related {0} can only be defined once but is not defined or defined multiple times for {1}..
        /// </summary>
        internal static string RelationshipMultiplicityMismatch {
            get {
                return ResourceManager.GetString("RelationshipMultiplicityMismatch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The relationship &apos;{0}&apos; used in an example is not defined in the template &apos;{1}&apos;..
        /// </summary>
        internal static string RelationshipNotFound {
            get {
                return ResourceManager.GetString("RelationshipNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The specified {0} &apos;{1}&apos; was not found. Available types are:{2}.
        /// </summary>
        internal static string RelationshipTypeNotFound {
            get {
                return ResourceManager.GetString("RelationshipTypeNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could find no template which is marked as a root template in the related templates of &apos;{0}&apos;..
        /// </summary>
        internal static string RootTemplateNotFound {
            get {
                return ResourceManager.GetString("RootTemplateNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The capabilities of the SDK &apos;{0}&apos; was not found..
        /// </summary>
        internal static string SdkCapabilitiesNotFound {
            get {
                return ResourceManager.GetString("SdkCapabilitiesNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The SDK &apos;{0}&apos; was not found..
        /// </summary>
        internal static string SdkNotFound {
            get {
                return ResourceManager.GetString("SdkNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not find the SDK &apos;{0}&apos;. This SDK cannot be used, please remove the SDK from the settings..
        /// </summary>
        internal static string SdkPathNotExisting {
            get {
                return ResourceManager.GetString("SdkPathNotExisting", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please specify, if you want to add or remove the target..
        /// </summary>
        internal static string SetTargetsOptionMissing {
            get {
                return ResourceManager.GetString("SetTargetsOptionMissing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Setting &apos;{0}&apos; is no collection setting (add and remove is not possible)..
        /// </summary>
        internal static string SettingIsNoCollection {
            get {
                return ResourceManager.GetString("SettingIsNoCollection", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The setting &apos;{0}&apos; does not exist. Do you mean &apos;{1}&apos;?.
        /// </summary>
        internal static string SettingNotFound {
            get {
                return ResourceManager.GetString("SettingNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The settings are read-only. Please execute the command with administrator rights..
        /// </summary>
        internal static string SettingNotWritable {
            get {
                return ResourceManager.GetString("SettingNotWritable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A setting key must be provided..
        /// </summary>
        internal static string SettingsKeyIsNotSet {
            get {
                return ResourceManager.GetString("SettingsKeyIsNotSet", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to While migrating the settings the process &apos;{0}&apos; threw the error: {1}.
        /// </summary>
        internal static string SettingsMigrationProcessError {
            get {
                return ResourceManager.GetString("SettingsMigrationProcessError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A value must be provided for the chosen setting..
        /// </summary>
        internal static string SettingsValueIsNotSet {
            get {
                return ResourceManager.GetString("SettingsValueIsNotSet", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value &apos;{0}&apos; does not exist. Do you mean &apos;{1}&apos;?.
        /// </summary>
        internal static string SettingValueNotFound {
            get {
                return ResourceManager.GetString("SettingValueNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The signature of the file &apos;{0}&apos; does not match with the file. The file is corrupt..
        /// </summary>
        internal static string SignatureValidationFailure {
            get {
                return ResourceManager.GetString("SignatureValidationFailure", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The target {0} is already supported by the project..
        /// </summary>
        internal static string TargetAlreadySupported {
            get {
                return ResourceManager.GetString("TargetAlreadySupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not find the architecture &apos;{1}&apos; of the target &apos;{0}&apos;. Available architectures are:{2}..
        /// </summary>
        internal static string TargetArchitectureNotFound {
            get {
                return ResourceManager.GetString("TargetArchitectureNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The target {0} does not have the correct format. Expected is the format &lt;target&gt;,&lt;version&gt;..
        /// </summary>
        internal static string TargetFormatMismatch {
            get {
                return ResourceManager.GetString("TargetFormatMismatch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The target {0} does not have the correct format. Expected is the format &lt;target&gt;,&lt;version&gt;(,&lt;file&gt;)..
        /// </summary>
        internal static string TargetFormatMismatchWithFile {
            get {
                return ResourceManager.GetString("TargetFormatMismatchWithFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The target {0} is installed more than once. Please check your installed targets..
        /// </summary>
        internal static string TargetInstalledTwice {
            get {
                return ResourceManager.GetString("TargetInstalledTwice", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The target {0} is ambiguous. Make clear which target you mean by specifying the version. Possible targets are:{1}.
        /// </summary>
        internal static string TargetNameAmbiguous {
            get {
                return ResourceManager.GetString("TargetNameAmbiguous", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not find the target &apos;{0}&apos;, because no targets with that name are available..
        /// </summary>
        internal static string TargetNameNotFound {
            get {
                return ResourceManager.GetString("TargetNameNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not find the target &apos;{0}&apos;. Do you mean &apos;{1}&apos;?.
        /// </summary>
        internal static string TargetNameNotFoundClosestMatch {
            get {
                return ResourceManager.GetString("TargetNameNotFoundClosestMatch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A target can only be set for projects with a plcnext.proj file, which is located in the project root directory..
        /// </summary>
        internal static string TargetNotSettableForProject {
            get {
                return ResourceManager.GetString("TargetNotSettableForProject", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Sdk manifest contains target definition without version. .
        /// </summary>
        internal static string TargetVersionMissing {
            get {
                return ResourceManager.GetString("TargetVersionMissing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not find the version &apos;{1}&apos; of the target &apos;{0}&apos;. Available versions are:{2}..
        /// </summary>
        internal static string TargetVersionNotFound {
            get {
                return ResourceManager.GetString("TargetVersionNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The identifier &apos;{0}&apos; configured for the template &apos;{1}&apos; is not available..
        /// </summary>
        internal static string TemplateIdentifierNotFound {
            get {
                return ResourceManager.GetString("TemplateIdentifierNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There is a template reference to the template &apos;{0}&apos; defined, but there is no template with the name &apos;{0}&apos;..
        /// </summary>
        internal static string TemplateReferenceNotDefined {
            get {
                return ResourceManager.GetString("TemplateReferenceNotDefined", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to resolving the order of template relationships.
        /// </summary>
        internal static string TemplateRelationshipCycle {
            get {
                return ResourceManager.GetString("TemplateRelationshipCycle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The template &apos;{0}&apos; does not contain a relationship with the name &apos;{1}&apos;..
        /// </summary>
        internal static string TemplateRelationshipNotFound {
            get {
                return ResourceManager.GetString("TemplateRelationshipNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The data type &apos;{0}&apos; is not known. For ports and port structures only known data types can be used..
        /// </summary>
        internal static string UnkownDataType {
            get {
                return ResourceManager.GetString("UnkownDataType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The base data type &apos;{0}&apos; of the enum &apos;{1}&apos; is not known. For ports and port structures only known data types can be used as base types..
        /// </summary>
        internal static string UnkownEnumDataType {
            get {
                return ResourceManager.GetString("UnkownEnumDataType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The version {0} is not available..
        /// </summary>
        internal static string UnkownVersion {
            get {
                return ResourceManager.GetString("UnkownVersion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The control sequence &apos;{0}&apos; is not available..
        /// </summary>
        internal static string UnrecognizedControlSequence {
            get {
                return ResourceManager.GetString("UnrecognizedControlSequence", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The format of the file &apos;{0}&apos; is not supported. Please proceed manually..
        /// </summary>
        internal static string UnsupportedArchiveFormat {
            get {
                return ResourceManager.GetString("UnsupportedArchiveFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The system {0} - {1} is not supported by this version..
        /// </summary>
        internal static string UnsupportedSystem {
            get {
                return ResourceManager.GetString("UnsupportedSystem", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There is a wild control sequence &apos;{0}&apos;..
        /// </summary>
        internal static string WildControlSequence {
            get {
                return ResourceManager.GetString("WildControlSequence", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The type &apos;{0}&apos; has the template &apos;{1}&apos; which needs the relationships &apos;{2}&apos;. At least one of the relationship is not specified or was not found..
        /// </summary>
        internal static string WildEntity {
            get {
                return ResourceManager.GetString("WildEntity", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You cannot combine external libraries for a specific target and external libraries without target..
        /// </summary>
        internal static string WrongCombinedExternalLibraries {
            get {
                return ResourceManager.GetString("WrongCombinedExternalLibraries", resourceCulture);
            }
        }
    }
}
