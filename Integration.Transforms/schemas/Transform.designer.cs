// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code. Version 3.4.0.38967
//    <NameSpace>Integration.Transforms</NameSpace><Collection>List</Collection><codeType>CSharp</codeType><EnableDataBinding>False</EnableDataBinding><EnableLazyLoading>False</EnableLazyLoading><TrackingChangesEnable>False</TrackingChangesEnable><GenTrackingClasses>False</GenTrackingClasses><HidePrivateFieldInIDE>False</HidePrivateFieldInIDE><EnableSummaryComment>False</EnableSummaryComment><VirtualProp>False</VirtualProp><IncludeSerializeMethod>False</IncludeSerializeMethod><UseBaseClass>False</UseBaseClass><GenBaseClass>False</GenBaseClass><GenerateCloneMethod>False</GenerateCloneMethod><GenerateDataContracts>False</GenerateDataContracts><CodeBaseTag>Net40</CodeBaseTag><SerializeMethodName>Serialize</SerializeMethodName><DeserializeMethodName>Deserialize</DeserializeMethodName><SaveToFileMethodName>SaveToFile</SaveToFileMethodName><LoadFromFileMethodName>LoadFromFile</LoadFromFileMethodName><GenerateXMLAttributes>True</GenerateXMLAttributes><EnableEncoding>False</EnableEncoding><AutomaticProperties>False</AutomaticProperties><GenerateShouldSerialize>False</GenerateShouldSerialize><DisableDebug>False</DisableDebug><PropNameSpecified>Default</PropNameSpecified><Encoder>UTF8</Encoder><CustomUsings></CustomUsings><ExcludeIncludedTypes>False</ExcludeIncludedTypes><EnableInitializeFields>True</EnableInitializeFields>
//  </auto-generated>
// ------------------------------------------------------------------------------
namespace Integration.Transforms {
    using System;
    using System.Diagnostics;
    using System.Xml.Serialization;
    using System.Collections;
    using System.Xml.Schema;
    using System.ComponentModel;
    using System.Collections.Generic;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="clr-namespace:Integration.Transforms")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="clr-namespace:Integration.Transforms", IsNullable=false)]
    public partial class Transform {
        
        private List<Model> inputsField;
        
        private List<Model> outputsField;
        
        private List<Function> functionsField;
        
        private OperationList operationsField;
        
        private List<Link> linksField;
        
        public Transform() {
            this.linksField = new List<Link>();
            this.operationsField = new OperationList();
            this.functionsField = new List<Function>();
            this.outputsField = new List<Model>();
            this.inputsField = new List<Model>();
        }
        
        [System.Xml.Serialization.XmlArrayAttribute(Order=0)]
        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
        public List<Model> Inputs {
            get {
                return this.inputsField;
            }
            set {
                this.inputsField = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayAttribute(Order=1)]
        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
        public List<Model> Outputs {
            get {
                return this.outputsField;
            }
            set {
                this.outputsField = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayAttribute(Order=2)]
        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
        public List<Function> Functions {
            get {
                return this.functionsField;
            }
            set {
                this.functionsField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public OperationList Operations {
            get {
                return this.operationsField;
            }
            set {
                this.operationsField = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayAttribute(Order=4)]
        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
        public List<Link> Links {
            get {
                return this.linksField;
            }
            set {
                this.linksField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="clr-namespace:Integration.Transforms")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="clr-namespace:Integration.Transforms", IsNullable=true)]
    public partial class Model {
        
        private List<Node> nodesField;
        
        private string typeField;
        
        public Model() {
            this.nodesField = new List<Node>();
        }
        
        [System.Xml.Serialization.XmlArrayAttribute(Order=0)]
        [System.Xml.Serialization.XmlArrayItemAttribute(typeof(Node), IsNullable=false)]
        public List<Node> Nodes {
            get {
                return this.nodesField;
            }
            set {
                this.nodesField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
        public string Type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="clr-namespace:Integration.Transforms")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="clr-namespace:Integration.Transforms", IsNullable=true)]
    public partial class Node {
        
        private List<Node> nodesField;
        
        private string idField;
        
        private string nameField;
        
        public Node() {
            this.nodesField = new List<Node>();
        }
        
        [System.Xml.Serialization.XmlArrayAttribute(Order=0)]
        [System.Xml.Serialization.XmlArrayItemAttribute(typeof(Node), IsNullable=false)]
        public List<Node> Nodes {
            get {
                return this.nodesField;
            }
            set {
                this.nodesField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="clr-namespace:Integration.Transforms")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="clr-namespace:Integration.Transforms", IsNullable=true)]
    public partial class Link {
        
        private string sourceField;
        
        private string targetField;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Source {
            get {
                return this.sourceField;
            }
            set {
                this.sourceField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Target {
            get {
                return this.targetField;
            }
            set {
                this.targetField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="clr-namespace:Integration.Transforms")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="clr-namespace:Integration.Transforms", IsNullable=true)]
    public partial class Output {
        
        private string idField;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="clr-namespace:Integration.Transforms")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="clr-namespace:Integration.Transforms", IsNullable=true)]
    public partial class Input {
        
        private string idField;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
    }
    
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CallFunction))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Assign))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Concat))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="clr-namespace:Integration.Transforms")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="clr-namespace:Integration.Transforms", IsNullable=true)]
    public abstract partial class Operation {
        
        private string idField;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="clr-namespace:Integration.Transforms")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="clr-namespace:Integration.Transforms", IsNullable=true)]
    public partial class CallFunction : Operation {
        
        private List<Input> inputsField;
        
        private Output outputField;
        
        private string functionIdField;
        
        public CallFunction() {
            this.outputField = new Output();
            this.inputsField = new List<Input>();
        }
        
        [System.Xml.Serialization.XmlArrayAttribute(Order=0)]
        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
        public List<Input> Inputs {
            get {
                return this.inputsField;
            }
            set {
                this.inputsField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public Output Output {
            get {
                return this.outputField;
            }
            set {
                this.outputField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string FunctionId {
            get {
                return this.functionIdField;
            }
            set {
                this.functionIdField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="clr-namespace:Integration.Transforms")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="clr-namespace:Integration.Transforms", IsNullable=true)]
    public partial class Assign : Operation {
        
        private Output outputField;
        
        private string valueField;
        
        public Assign() {
            this.outputField = new Output();
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public Output Output {
            get {
                return this.outputField;
            }
            set {
                this.outputField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="clr-namespace:Integration.Transforms")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="clr-namespace:Integration.Transforms", IsNullable=true)]
    public partial class Concat : Operation {
        
        private List<Input> inputsField;
        
        private Output outputField;
        
        public Concat() {
            this.outputField = new Output();
            this.inputsField = new List<Input>();
        }
        
        [System.Xml.Serialization.XmlArrayAttribute(Order=0)]
        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
        public List<Input> Inputs {
            get {
                return this.inputsField;
            }
            set {
                this.inputsField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public Output Output {
            get {
                return this.outputField;
            }
            set {
                this.outputField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="clr-namespace:Integration.Transforms")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="clr-namespace:Integration.Transforms", IsNullable=true)]
    public partial class OperationList {
        
        private Assign assignField;
        
        private Concat concatField;
        
        private CallFunction callFunctionField;
        
        public OperationList() {
            this.callFunctionField = new CallFunction();
            this.concatField = new Concat();
            this.assignField = new Assign();
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public Assign Assign {
            get {
                return this.assignField;
            }
            set {
                this.assignField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public Concat Concat {
            get {
                return this.concatField;
            }
            set {
                this.concatField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public CallFunction CallFunction {
            get {
                return this.callFunctionField;
            }
            set {
                this.callFunctionField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="clr-namespace:Integration.Transforms")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="clr-namespace:Integration.Transforms", IsNullable=true)]
    public partial class Parameter {
        
        private string nameField;
        
        private string typeField;
        
        private ParameterDirection directionField;
        
        private bool directionFieldSpecified;
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="Name")]
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ParameterDirection Direction {
            get {
                return this.directionField;
            }
            set {
                this.directionField = value;
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DirectionSpecified {
            get {
                return this.directionFieldSpecified;
            }
            set {
                this.directionFieldSpecified = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="clr-namespace:Integration.Transforms")]
    public enum ParameterDirection {
        
        /// <remarks/>
        In,
        
        /// <remarks/>
        Out,
        
        /// <remarks/>
        InOut,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="clr-namespace:Integration.Transforms")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="clr-namespace:Integration.Transforms", IsNullable=true)]
    public partial class ParameterList {
        
        private Parameter parameterField;
        
        public ParameterList() {
            this.parameterField = new Parameter();
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public Parameter Parameter {
            get {
                return this.parameterField;
            }
            set {
                this.parameterField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="clr-namespace:Integration.Transforms")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="clr-namespace:Integration.Transforms", IsNullable=true)]
    public partial class Function {
        
        private ParameterList parametersField;
        
        private string bodyField;
        
        private string idField;
        
        private string nameField;
        
        private string returnTypeField;
        
        private ProgrammingLanguage languageField;
        
        private bool languageFieldSpecified;
        
        public Function() {
            this.parametersField = new ParameterList();
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public ParameterList Parameters {
            get {
                return this.parametersField;
            }
            set {
                this.parametersField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string Body {
            get {
                return this.bodyField;
            }
            set {
                this.bodyField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="Name")]
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ReturnType {
            get {
                return this.returnTypeField;
            }
            set {
                this.returnTypeField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ProgrammingLanguage Language {
            get {
                return this.languageField;
            }
            set {
                this.languageField = value;
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LanguageSpecified {
            get {
                return this.languageFieldSpecified;
            }
            set {
                this.languageFieldSpecified = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="clr-namespace:Integration.Transforms")]
    public enum ProgrammingLanguage {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("C#")]
        C,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="NodeList", Namespace="clr-namespace:Integration.Transforms")]
    [System.Xml.Serialization.XmlRootAttribute("NodeList", Namespace="clr-namespace:Integration.Transforms", IsNullable=true)]
    public partial class NodeList1 {
        
        private List<Node> nodeField;
        
        public NodeList1() {
            this.nodeField = new List<Node>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Node", Order=0)]
        public List<Node> Node {
            get {
                return this.nodeField;
            }
            set {
                this.nodeField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="clr-namespace:Integration.Transforms")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="clr-namespace:Integration.Transforms", IsNullable=true)]
    public partial class TransformInputs {
        
        private List<Model> modelField;
        
        public TransformInputs() {
            this.modelField = new List<Model>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Model", Order=0)]
        public List<Model> Model {
            get {
                return this.modelField;
            }
            set {
                this.modelField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="clr-namespace:Integration.Transforms")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="clr-namespace:Integration.Transforms", IsNullable=true)]
    public partial class TransformOutputs {
        
        private List<Model> modelField;
        
        public TransformOutputs() {
            this.modelField = new List<Model>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Model", Order=0)]
        public List<Model> Model {
            get {
                return this.modelField;
            }
            set {
                this.modelField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="clr-namespace:Integration.Transforms")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="clr-namespace:Integration.Transforms", IsNullable=true)]
    public partial class FunctionList {
        
        private List<Function> functionField;
        
        public FunctionList() {
            this.functionField = new List<Function>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Function", Order=0)]
        public List<Function> Function {
            get {
                return this.functionField;
            }
            set {
                this.functionField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="clr-namespace:Integration.Transforms")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="clr-namespace:Integration.Transforms", IsNullable=true)]
    public partial class InputList {
        
        private List<Input> inputField;
        
        public InputList() {
            this.inputField = new List<Input>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Input", Order=0)]
        public List<Input> Input {
            get {
                return this.inputField;
            }
            set {
                this.inputField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="clr-namespace:Integration.Transforms")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="clr-namespace:Integration.Transforms", IsNullable=true)]
    public partial class OutputList {
        
        private List<Output> outputField;
        
        public OutputList() {
            this.outputField = new List<Output>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Output", Order=0)]
        public List<Output> Output {
            get {
                return this.outputField;
            }
            set {
                this.outputField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="clr-namespace:Integration.Transforms")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="clr-namespace:Integration.Transforms", IsNullable=true)]
    public partial class LinkList {
        
        private List<Link> linkField;
        
        public LinkList() {
            this.linkField = new List<Link>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Link", Order=0)]
        public List<Link> Link {
            get {
                return this.linkField;
            }
            set {
                this.linkField = value;
            }
        }
    }
}
