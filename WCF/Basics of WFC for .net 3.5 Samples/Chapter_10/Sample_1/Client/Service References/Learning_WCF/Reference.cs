﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client.Learning_WCF {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ErrorDetails", Namespace="http://schemas.datacontract.org/2004/07/Server")]
    [System.SerializableAttribute()]
    public partial class ErrorDetails : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CodeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Code {
            get {
                return this.CodeField;
            }
            set {
                if ((this.CodeField.Equals(value) != true)) {
                    this.CodeField = value;
                    this.RaisePropertyChanged("Code");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Description {
            get {
                return this.DescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescriptionField, value) != true)) {
                    this.DescriptionField = value;
                    this.RaisePropertyChanged("Description");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Learning_WCF.IService")]
    public interface IService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/ThrowNotImplementedException", ReplyAction="http://tempuri.org/IService/ThrowNotImplementedExceptionResponse")]
        void ThrowNotImplementedException();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/ThrowNotImplementedException", ReplyAction="http://tempuri.org/IService/ThrowNotImplementedExceptionResponse")]
        System.Threading.Tasks.Task ThrowNotImplementedExceptionAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/ThrowFaulException", ReplyAction="http://tempuri.org/IService/ThrowFaulExceptionResponse")]
        void ThrowFaulException();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/ThrowFaulException", ReplyAction="http://tempuri.org/IService/ThrowFaulExceptionResponse")]
        System.Threading.Tasks.Task ThrowFaulExceptionAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/ThrowGenericFaultException", ReplyAction="http://tempuri.org/IService/ThrowGenericFaultExceptionResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Client.Learning_WCF.ErrorDetails), Action="http://tempuri.org/IService/ThrowGenericFaultExceptionErrorDetailsFault", Name="ErrorDetails", Namespace="http://schemas.datacontract.org/2004/07/Server")]
        void ThrowGenericFaultException();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/ThrowGenericFaultException", ReplyAction="http://tempuri.org/IService/ThrowGenericFaultExceptionResponse")]
        System.Threading.Tasks.Task ThrowGenericFaultExceptionAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceChannel : Client.Learning_WCF.IService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceClient : System.ServiceModel.ClientBase<Client.Learning_WCF.IService>, Client.Learning_WCF.IService {
        
        public ServiceClient() {
        }
        
        public ServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void ThrowNotImplementedException() {
            base.Channel.ThrowNotImplementedException();
        }
        
        public System.Threading.Tasks.Task ThrowNotImplementedExceptionAsync() {
            return base.Channel.ThrowNotImplementedExceptionAsync();
        }
        
        public void ThrowFaulException() {
            base.Channel.ThrowFaulException();
        }
        
        public System.Threading.Tasks.Task ThrowFaulExceptionAsync() {
            return base.Channel.ThrowFaulExceptionAsync();
        }
        
        public void ThrowGenericFaultException() {
            base.Channel.ThrowGenericFaultException();
        }
        
        public System.Threading.Tasks.Task ThrowGenericFaultExceptionAsync() {
            return base.Channel.ThrowGenericFaultExceptionAsync();
        }
    }
}
