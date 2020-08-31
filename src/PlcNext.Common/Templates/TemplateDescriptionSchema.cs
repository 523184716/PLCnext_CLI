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
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by xsd, Version=4.7.3081.0.
// 
namespace PlcNext.Common.Templates.Description {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.phoenixcontact.com/schema/clitemplates")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.phoenixcontact.com/schema/clitemplates", IsNullable=false)]
    public partial class TemplateDescription {
        
        private templateArgumentDefinition[] argumentsField;
        
        private templateRelationship[] relationshipField;
        
        private templateReference[] addTemplateField;
        
        private templateFile[] fileField;
        
        private templateGeneratedFile[] generatedFileField;
        
        private string descriptionField;
        
        private templateExample[] exampleField;
        
        private templateDeployPostStep[] deployPostStepField;
        
        private string nameField;
        
        private string supportedFirmwareVersionsField;
        
        private string requiredCliVersionField;
        
        private string versionField;
        
        private bool isRootField;
        
        private bool isHiddenField;
        
        private string basedOnField;
        
        private string identifierField;
        
        private bool isRelevantForProjectNamespaceField;
        
        public TemplateDescription() {
            this.isRootField = false;
            this.isHiddenField = false;
            this.identifierField = "CodeAttributeIdentifier";
            this.isRelevantForProjectNamespaceField = false;
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Argument", IsNullable=false)]
        public templateArgumentDefinition[] Arguments {
            get {
                return this.argumentsField;
            }
            set {
                this.argumentsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Relationship")]
        public templateRelationship[] Relationship {
            get {
                return this.relationshipField;
            }
            set {
                this.relationshipField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AddTemplate")]
        public templateReference[] AddTemplate {
            get {
                return this.addTemplateField;
            }
            set {
                this.addTemplateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("File")]
        public templateFile[] File {
            get {
                return this.fileField;
            }
            set {
                this.fileField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("GeneratedFile")]
        public templateGeneratedFile[] GeneratedFile {
            get {
                return this.generatedFileField;
            }
            set {
                this.generatedFileField = value;
            }
        }
        
        /// <remarks/>
        public string Description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Example")]
        public templateExample[] Example {
            get {
                return this.exampleField;
            }
            set {
                this.exampleField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DeployPostStep")]
        public templateDeployPostStep[] DeployPostStep {
            get {
                return this.deployPostStepField;
            }
            set {
                this.deployPostStepField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string supportedFirmwareVersions {
            get {
                return this.supportedFirmwareVersionsField;
            }
            set {
                this.supportedFirmwareVersionsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string requiredCliVersion {
            get {
                return this.requiredCliVersionField;
            }
            set {
                this.requiredCliVersionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string version {
            get {
                return this.versionField;
            }
            set {
                this.versionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool isRoot {
            get {
                return this.isRootField;
            }
            set {
                this.isRootField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool isHidden {
            get {
                return this.isHiddenField;
            }
            set {
                this.isHiddenField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string basedOn {
            get {
                return this.basedOnField;
            }
            set {
                this.basedOnField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute("CodeAttributeIdentifier")]
        public string identifier {
            get {
                return this.identifierField;
            }
            set {
                this.identifierField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool isRelevantForProjectNamespace {
            get {
                return this.isRelevantForProjectNamespaceField;
            }
            set {
                this.isRelevantForProjectNamespaceField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.phoenixcontact.com/schema/clitemplates")]
    public partial class templateArgumentDefinition : templateArgumentBase {
        
        private valueRestriction valueRestrictionField;
        
        private string shortnameField;
        
        private string helpField;
        
        private string defaultField;
        
        private string formatField;
        
        private string separatorField;
        
        private bool hasvalueField;
        
        private multiplicity multiplicityField;
        
        public templateArgumentDefinition() {
            this.separatorField = ",";
            this.hasvalueField = false;
            this.multiplicityField = multiplicity.One;
        }
        
        /// <remarks/>
        public valueRestriction ValueRestriction {
            get {
                return this.valueRestrictionField;
            }
            set {
                this.valueRestrictionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("short-name")]
        public string shortname {
            get {
                return this.shortnameField;
            }
            set {
                this.shortnameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string help {
            get {
                return this.helpField;
            }
            set {
                this.helpField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string @default {
            get {
                return this.defaultField;
            }
            set {
                this.defaultField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string format {
            get {
                return this.formatField;
            }
            set {
                this.formatField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(",")]
        public string separator {
            get {
                return this.separatorField;
            }
            set {
                this.separatorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("has-value")]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool hasvalue {
            get {
                return this.hasvalueField;
            }
            set {
                this.hasvalueField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(multiplicity.One)]
        public multiplicity multiplicity {
            get {
                return this.multiplicityField;
            }
            set {
                this.multiplicityField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.phoenixcontact.com/schema/clitemplates")]
    public partial class valueRestriction {
        
        private string[] itemsField;
        
        private ItemsChoiceType[] itemsElementNameField;
        
        private bool ignorecaseField;
        
        private string minlengthField;
        
        private string maxlengthField;
        
        private string lengthField;
        
        private whitespace whitespaceField;
        
        public valueRestriction() {
            this.ignorecaseField = false;
            this.minlengthField = "0";
            this.maxlengthField = "-1";
            this.lengthField = "-1";
            this.whitespaceField = whitespace.Preserve;
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Enumeration", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("Pattern", typeof(string))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public string[] Items {
            get {
                return this.itemsField;
            }
            set {
                this.itemsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemsChoiceType[] ItemsElementName {
            get {
                return this.itemsElementNameField;
            }
            set {
                this.itemsElementNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("ignore-case")]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool ignorecase {
            get {
                return this.ignorecaseField;
            }
            set {
                this.ignorecaseField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("min-length", DataType="nonNegativeInteger")]
        [System.ComponentModel.DefaultValueAttribute("0")]
        public string minlength {
            get {
                return this.minlengthField;
            }
            set {
                this.minlengthField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("max-length", DataType="integer")]
        [System.ComponentModel.DefaultValueAttribute("-1")]
        public string maxlength {
            get {
                return this.maxlengthField;
            }
            set {
                this.maxlengthField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        [System.ComponentModel.DefaultValueAttribute("-1")]
        public string length {
            get {
                return this.lengthField;
            }
            set {
                this.lengthField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(whitespace.Preserve)]
        public whitespace whitespace {
            get {
                return this.whitespaceField;
            }
            set {
                this.whitespaceField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.phoenixcontact.com/schema/clitemplates", IncludeInSchema=false)]
    public enum ItemsChoiceType {
        
        /// <remarks/>
        Enumeration,
        
        /// <remarks/>
        Pattern,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.phoenixcontact.com/schema/clitemplates")]
    public enum whitespace {
        
        /// <remarks/>
        Preserve,
        
        /// <remarks/>
        Replace,
        
        /// <remarks/>
        Collapse,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.phoenixcontact.com/schema/clitemplates")]
    public partial class templateDeployPostStep {
        
        private templateArgumentDefinition[] argumentsField;
        
        private templateExample[] exampleField;
        
        private string identifierField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Argument", IsNullable=false)]
        public templateArgumentDefinition[] Arguments {
            get {
                return this.argumentsField;
            }
            set {
                this.argumentsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Example")]
        public templateExample[] Example {
            get {
                return this.exampleField;
            }
            set {
                this.exampleField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string identifier {
            get {
                return this.identifierField;
            }
            set {
                this.identifierField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.phoenixcontact.com/schema/clitemplates")]
    public partial class templateExample {
        
        private templateArgumentInstance[] argumentsField;
        
        private templateRelationshipInstance[] relationshipField;
        
        private string descriptionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Argument", IsNullable=false)]
        public templateArgumentInstance[] Arguments {
            get {
                return this.argumentsField;
            }
            set {
                this.argumentsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Relationship")]
        public templateRelationshipInstance[] Relationship {
            get {
                return this.relationshipField;
            }
            set {
                this.relationshipField = value;
            }
        }
        
        /// <remarks/>
        public string Description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.phoenixcontact.com/schema/clitemplates")]
    public partial class templateArgumentInstance : templateArgumentBase {
        
        private string valueField;
        
        public templateArgumentInstance() {
            this.valueField = "true";
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute("true")]
        public string value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(templateArgumentInstance))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(templateArgumentDefinition))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.phoenixcontact.com/schema/clitemplates")]
    public partial class templateArgumentBase {
        
        private string nameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.phoenixcontact.com/schema/clitemplates")]
    public partial class templateRelationshipInstance : templateRelationshipBase {
        
        private string valueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(templateRelationshipInstance))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(templateRelationship))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.phoenixcontact.com/schema/clitemplates")]
    public partial class templateRelationshipBase {
        
        private string nameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.phoenixcontact.com/schema/clitemplates")]
    public partial class templateRelationship : templateRelationshipBase {
        
        private string typeField;
        
        private multiplicity multiplicityField;
        
        public templateRelationship() {
            this.multiplicityField = multiplicity.One;
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(multiplicity.One)]
        public multiplicity multiplicity {
            get {
                return this.multiplicityField;
            }
            set {
                this.multiplicityField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.phoenixcontact.com/schema/clitemplates")]
    public enum multiplicity {
        
        /// <remarks/>
        One,
        
        /// <remarks/>
        OneOrMore,
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(templateGeneratedFile))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.phoenixcontact.com/schema/clitemplates")]
    public partial class templateFile {
        
        private string nameField;
        
        private string templateField;
        
        private string pathField;
        
        private string keyField;
        
        private string deployPathField;
        
        private string conditionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
        public string template {
            get {
                return this.templateField;
            }
            set {
                this.templateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string path {
            get {
                return this.pathField;
            }
            set {
                this.pathField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string key {
            get {
                return this.keyField;
            }
            set {
                this.keyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string deployPath {
            get {
                return this.deployPathField;
            }
            set {
                this.deployPathField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string condition {
            get {
                return this.conditionField;
            }
            set {
                this.conditionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.phoenixcontact.com/schema/clitemplates")]
    public partial class templateGeneratedFile : templateFile {
        
        private string generatorField;
        
        private string aggregatedField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string generator {
            get {
                return this.generatorField;
            }
            set {
                this.generatorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string aggregated {
            get {
                return this.aggregatedField;
            }
            set {
                this.aggregatedField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.phoenixcontact.com/schema/clitemplates")]
    public partial class templateReference {
        
        private templateArgumentInstance[] argumentsField;
        
        private templateRelationshipInstance[] relationshipField;
        
        private string templateField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Argument", IsNullable=false)]
        public templateArgumentInstance[] Arguments {
            get {
                return this.argumentsField;
            }
            set {
                this.argumentsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Relationship")]
        public templateRelationshipInstance[] Relationship {
            get {
                return this.relationshipField;
            }
            set {
                this.relationshipField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string template {
            get {
                return this.templateField;
            }
            set {
                this.templateField = value;
            }
        }
    }
}
