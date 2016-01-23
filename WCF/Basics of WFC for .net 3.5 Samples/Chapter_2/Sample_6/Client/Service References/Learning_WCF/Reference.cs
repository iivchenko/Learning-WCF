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
    [System.Runtime.Serialization.DataContractAttribute(Name="Message", Namespace="http://Service")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(Client.Learning_WCF.HelloMessage))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(Client.Learning_WCF.ByMessage))]
    public partial class Message : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string MessageMemberField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="Message", IsRequired=true)]
        public string MessageMember {
            get {
                return this.MessageMemberField;
            }
            set {
                if ((object.ReferenceEquals(this.MessageMemberField, value) != true)) {
                    this.MessageMemberField = value;
                    this.RaisePropertyChanged("MessageMember");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="HelloMessage", Namespace="http://Service")]
    [System.SerializableAttribute()]
    public partial class HelloMessage : Client.Learning_WCF.Message {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SenderField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Sender {
            get {
                return this.SenderField;
            }
            set {
                if ((object.ReferenceEquals(this.SenderField, value) != true)) {
                    this.SenderField = value;
                    this.RaisePropertyChanged("Sender");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ByMessage", Namespace="http://Service")]
    [System.SerializableAttribute()]
    public partial class ByMessage : Client.Learning_WCF.Message {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SenderField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Sender {
            get {
                return this.SenderField;
            }
            set {
                if ((object.ReferenceEquals(this.SenderField, value) != true)) {
                    this.SenderField = value;
                    this.RaisePropertyChanged("Sender");
                }
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://Service", ConfigurationName="Learning_WCF.IService")]
    public interface IService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Service/IService/Send", ReplyAction="http://Service/IService/SendResponse")]
        void Send(Client.Learning_WCF.Message msg);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Service/IService/Send", ReplyAction="http://Service/IService/SendResponse")]
        System.Threading.Tasks.Task SendAsync(Client.Learning_WCF.Message msg);
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
        
        public void Send(Client.Learning_WCF.Message msg) {
            base.Channel.Send(msg);
        }
        
        public System.Threading.Tasks.Task SendAsync(Client.Learning_WCF.Message msg) {
            return base.Channel.SendAsync(msg);
        }
    }
}