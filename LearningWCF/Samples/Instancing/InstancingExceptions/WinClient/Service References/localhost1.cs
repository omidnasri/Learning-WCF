﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.312
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WinClient.localhost1
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://www.thatindigogirl.com/samples/2006/06", ConfigurationName="WinClient.localhost1.ICounterServiceSession", SessionMode=System.ServiceModel.SessionMode.Required)]
    public interface ICounterServiceSession
    {
        
        [System.ServiceModel.OperationContractAttribute(ProtectionLevel=System.Net.Security.ProtectionLevel.EncryptAndSign, Action="http://www.thatindigogirl.com/samples/2006/06/ICounterServiceSession/IncrementCou" +
            "nter", ReplyAction="http://www.thatindigogirl.com/samples/2006/06/ICounterServiceSession/IncrementCou" +
            "nterResponse")]
        int IncrementCounter();
        
        [System.ServiceModel.OperationContractAttribute(ProtectionLevel=System.Net.Security.ProtectionLevel.EncryptAndSign, Action="http://www.thatindigogirl.com/samples/2006/06/ICounterServiceSession/ThrowExcepti" +
            "on", ReplyAction="http://www.thatindigogirl.com/samples/2006/06/ICounterServiceSession/ThrowExcepti" +
            "onResponse")]
        void ThrowException();
        
        [System.ServiceModel.OperationContractAttribute(ProtectionLevel=System.Net.Security.ProtectionLevel.EncryptAndSign, Action="http://www.thatindigogirl.com/samples/2006/06/ICounterServiceSession/ThrowFault", ReplyAction="http://www.thatindigogirl.com/samples/2006/06/ICounterServiceSession/ThrowFaultRe" +
            "sponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(System.InvalidOperationException), Action="http://www.thatindigogirl.com/samples/2006/06/ICounterServiceSession/ThrowFaultIn" +
            "validOperationExceptionFault", ProtectionLevel=System.Net.Security.ProtectionLevel.EncryptAndSign, Name="InvalidOperationException", Namespace="http://schemas.datacontract.org/2004/07/System")]
        void ThrowFault();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public interface ICounterServiceSessionChannel : WinClient.localhost1.ICounterServiceSession, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public partial class CounterServiceSessionClient : System.ServiceModel.ClientBase<WinClient.localhost1.ICounterServiceSession>, WinClient.localhost1.ICounterServiceSession
    {
        
        public CounterServiceSessionClient()
        {
        }
        
        public CounterServiceSessionClient(string endpointConfigurationName) : 
                base(endpointConfigurationName)
        {
        }
        
        public CounterServiceSessionClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress)
        {
        }
        
        public CounterServiceSessionClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress)
        {
        }
        
        public CounterServiceSessionClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public int IncrementCounter()
        {
            return base.Channel.IncrementCounter();
        }
        
        public void ThrowException()
        {
            base.Channel.ThrowException();
        }
        
        public void ThrowFault()
        {
            base.Channel.ThrowFault();
        }
    }
}