﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.1378
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WinClientV2.localhost {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://www.thatindigogirl.com/samples/2006/08", ConfigurationName="localhost.ServiceAContract2")]
    public interface ServiceAContract2 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.thatindigogirl.com/samples/2006/08/ServiceAContract2/Operation1", ReplyAction="http://www.thatindigogirl.com/samples/2006/08/ServiceAContract2/Operation1Respons" +
            "e")]
        string Operation1();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.thatindigogirl.com/samples/2006/08/ServiceAContract2/Operation2", ReplyAction="http://www.thatindigogirl.com/samples/2006/08/ServiceAContract2/Operation2Respons" +
            "e")]
        string Operation2();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.thatindigogirl.com/samples/2006/08/ServiceAContract2/Operation3", ReplyAction="http://www.thatindigogirl.com/samples/2006/08/ServiceAContract2/Operation3Respons" +
            "e")]
        string Operation3();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public interface ServiceAContract2Channel : WinClientV2.localhost.ServiceAContract2, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public partial class ServiceAContract2Client : System.ServiceModel.ClientBase<WinClientV2.localhost.ServiceAContract2>, WinClientV2.localhost.ServiceAContract2 {
        
        public ServiceAContract2Client() {
        }
        
        public ServiceAContract2Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceAContract2Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceAContract2Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceAContract2Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string Operation1() {
            return base.Channel.Operation1();
        }
        
        public string Operation2() {
            return base.Channel.Operation2();
        }
        
        public string Operation3() {
            return base.Channel.Operation3();
        }
    }
}