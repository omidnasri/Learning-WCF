﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.312
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client.localhost
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://www.thatindigogirl.com/samples/2006/06", ConfigurationName="Client.localhost.IHelloIndigoService")]
    public interface IHelloIndigoService
    {
        
        [System.ServiceModel.OperationContractAttribute(ProtectionLevel=System.Net.Security.ProtectionLevel.EncryptAndSign, Action="http://www.thatindigogirl.com/samples/2006/06/IHelloIndigoService/HelloIndigo", ReplyAction="http://www.thatindigogirl.com/samples/2006/06/IHelloIndigoService/HelloIndigoResp" +
            "onse")]
        string HelloIndigo(string s);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public interface IHelloIndigoServiceChannel : Client.localhost.IHelloIndigoService, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public partial class HelloIndigoServiceClient : System.ServiceModel.ClientBase<Client.localhost.IHelloIndigoService>, Client.localhost.IHelloIndigoService
    {
        
        public HelloIndigoServiceClient()
        {
        }
        
        public HelloIndigoServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName)
        {
        }
        
        public HelloIndigoServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress)
        {
        }
        
        public HelloIndigoServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress)
        {
        }
        
        public HelloIndigoServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public string HelloIndigo(string s)
        {
            return base.Channel.HelloIndigo(s);
        }
    }
}
