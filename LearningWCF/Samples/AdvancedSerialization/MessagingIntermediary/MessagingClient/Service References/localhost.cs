﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.42
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MessagingClient.localhost
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://www.thatindigogirl.com/samples/2006/06", ConfigurationName="MessagingClient.localhost.MessageManagerServiceContract")]
    public interface MessageManagerServiceContract
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.thatindigogirl.com/samples/2006/06/MessageManagerServiceContract/SendM" +
            "essage", ReplyAction="http://www.thatindigogirl.com/samples/2006/06/MessageManagerServiceContract/SendM" +
            "essageResponse")]
        string SendMessage(string msg);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public interface MessageManagerServiceContractChannel : MessagingClient.localhost.MessageManagerServiceContract, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public partial class MessageManagerServiceContractClient : System.ServiceModel.ClientBase<MessagingClient.localhost.MessageManagerServiceContract>, MessagingClient.localhost.MessageManagerServiceContract
    {
        
        public MessageManagerServiceContractClient()
        {
        }
        
        public MessageManagerServiceContractClient(string endpointConfigurationName) : 
                base(endpointConfigurationName)
        {
        }
        
        public MessageManagerServiceContractClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress)
        {
        }
        
        public MessageManagerServiceContractClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress)
        {
        }
        
        public MessageManagerServiceContractClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public string SendMessage(string msg)
        {
            return base.Channel.SendMessage(msg);
        }
    }
}
