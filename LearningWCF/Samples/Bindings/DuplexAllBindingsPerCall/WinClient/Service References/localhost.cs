﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.42
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WinClient.localhost
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://www.thatindigogirl.com/samples/2006/06", ConfigurationName="WinClient.localhost.IHelloIndigoService", CallbackContract=typeof(WinClient.localhost.IHelloIndigoServiceCallback))]
    public interface IHelloIndigoService
    {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://www.thatindigogirl.com/samples/2006/06/IHelloIndigoService/HelloIndigo")]
        void HelloIndigo(string message);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.thatindigogirl.com/samples/2006/06/IHelloIndigoService/HelloIndigo2", ReplyAction="http://www.thatindigogirl.com/samples/2006/06/IHelloIndigoService/HelloIndigo2Res" +
            "ponse")]
        void HelloIndigo2(string message);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public interface IHelloIndigoServiceCallback
    {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://www.thatindigogirl.com/samples/2006/06/IHelloIndigoService/HelloIndigoCall" +
            "back")]
        void HelloIndigoCallback(string message);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.thatindigogirl.com/samples/2006/06/IHelloIndigoService/HelloIndigoCall" +
            "back2", ReplyAction="http://www.thatindigogirl.com/samples/2006/06/IHelloIndigoService/HelloIndigoCall" +
            "back2Response")]
        void HelloIndigoCallback2(string message);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public interface IHelloIndigoServiceChannel : WinClient.localhost.IHelloIndigoService, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public partial class HelloIndigoServiceClient : System.ServiceModel.DuplexClientBase<WinClient.localhost.IHelloIndigoService>, WinClient.localhost.IHelloIndigoService
    {
        
        public HelloIndigoServiceClient(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance)
        {
        }
        
        public HelloIndigoServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName)
        {
        }
        
        public HelloIndigoServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress)
        {
        }
        
        public HelloIndigoServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress)
        {
        }
        
        public HelloIndigoServiceClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress)
        {
        }
        
        public void HelloIndigo(string message)
        {
            base.Channel.HelloIndigo(message);
        }
        
        public void HelloIndigo2(string message)
        {
            base.Channel.HelloIndigo2(message);
        }
    }
}
