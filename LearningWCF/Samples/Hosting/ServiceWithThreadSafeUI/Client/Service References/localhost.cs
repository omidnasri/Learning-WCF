﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.42
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client.localhost
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://www.thatindigogirl.com/samples/2006/06", ConfigurationName="Client.localhost.IUIService")]
    public interface IUIService
    {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://www.thatindigogirl.com/samples/2006/06/IUIService/SendMessage")]
        void SendMessage(string message);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public interface IUIServiceChannel : Client.localhost.IUIService, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public partial class UIServiceClient : System.ServiceModel.ClientBase<Client.localhost.IUIService>, Client.localhost.IUIService
    {
        
        public UIServiceClient()
        {
        }
        
        public UIServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName)
        {
        }
        
        public UIServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress)
        {
        }
        
        public UIServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress)
        {
        }
        
        public UIServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public void SendMessage(string message)
        {
            base.Channel.SendMessage(message);
        }
    }
}
