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
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://Service", ConfigurationName="Learning_WCF.IService")]
    public interface IService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Service/IService/Send", ReplyAction="http://Service/IService/SendResponse")]
        Client.Learning_WCF.SendResponse Send(Client.Learning_WCF.Message request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Service/IService/Send", ReplyAction="http://Service/IService/SendResponse")]
        System.Threading.Tasks.Task<Client.Learning_WCF.SendResponse> SendAsync(Client.Learning_WCF.Message request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Message", WrapperNamespace="http://Service", IsWrapped=true)]
    public partial class Message {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://Service")]
        public string Header;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://Service", Order=0)]
        public string Body;
        
        public Message() {
        }
        
        public Message(string Header, string Body) {
            this.Header = Header;
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SendResponse {
        
        public SendResponse() {
        }
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
        
        public Client.Learning_WCF.SendResponse Send(Client.Learning_WCF.Message request) {
            return base.Channel.Send(request);
        }
        
        public System.Threading.Tasks.Task<Client.Learning_WCF.SendResponse> SendAsync(Client.Learning_WCF.Message request) {
            return base.Channel.SendAsync(request);
        }
    }
}
