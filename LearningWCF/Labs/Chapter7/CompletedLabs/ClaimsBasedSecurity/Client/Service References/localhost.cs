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
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://www.thatindigogirl.com/samples/2006/06", ConfigurationName="Client.localhost.ICrudService")]
    public interface ICrudService
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.thatindigogirl.com/samples/2006/06/ICrudService/CreateSomething", ReplyAction="http://www.thatindigogirl.com/samples/2006/06/ICrudService/CreateSomethingRespons" +
            "e")]
        string CreateSomething();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.thatindigogirl.com/samples/2006/06/ICrudService/ReadSomething", ReplyAction="http://www.thatindigogirl.com/samples/2006/06/ICrudService/ReadSomethingResponse")]
        string ReadSomething();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.thatindigogirl.com/samples/2006/06/ICrudService/UpdateSomething", ReplyAction="http://www.thatindigogirl.com/samples/2006/06/ICrudService/UpdateSomethingRespons" +
            "e")]
        string UpdateSomething();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.thatindigogirl.com/samples/2006/06/ICrudService/DeleteSomething", ReplyAction="http://www.thatindigogirl.com/samples/2006/06/ICrudService/DeleteSomethingRespons" +
            "e")]
        string DeleteSomething();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public interface ICrudServiceChannel : Client.localhost.ICrudService, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public partial class CrudServiceClient : System.ServiceModel.ClientBase<Client.localhost.ICrudService>, Client.localhost.ICrudService
    {
        
        public CrudServiceClient()
        {
        }
        
        public CrudServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName)
        {
        }
        
        public CrudServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress)
        {
        }
        
        public CrudServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress)
        {
        }
        
        public CrudServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public string CreateSomething()
        {
            return base.Channel.CreateSomething();
        }
        
        public string ReadSomething()
        {
            return base.Channel.ReadSomething();
        }
        
        public string UpdateSomething()
        {
            return base.Channel.UpdateSomething();
        }
        
        public string DeleteSomething()
        {
            return base.Channel.DeleteSomething();
        }
    }
}
