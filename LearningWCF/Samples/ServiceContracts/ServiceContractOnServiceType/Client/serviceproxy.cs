﻿// © 2007 Michele Leroux Bustamante. All rights reserved 
// Book: Learning WCF, O'Reilly
// Book Blog: www.thatindigogirl.com
// Michele's Blog: www.dasblonde.net
// IDesign: www.idesign.net

using System.ServiceModel;

[ServiceContract(Name="HelloIndigoService", Namespace = "http://www.thatindigogirl.com/samples/2006/06")]
public interface IHelloIndigoService
{
    [OperationContract]
    string HelloIndigo();
}
