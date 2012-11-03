// � 2007 Michele Leroux Bustamante. All rights reserved 
// Book: Learning WCF, O'Reilly
// Book Blog: www.thatindigogirl.com
// Michele's Blog: www.dasblonde.net
// IDesign: www.idesign.net
   
using System;
using System.Collections.Generic;
using System.Text;
using System.ServiceModel;
using System.ServiceModel.Dispatcher;
using System.Security.Cryptography.X509Certificates;
using System.ServiceModel.Security;

namespace Host
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(HelloIndigo.HelloIndigoService)))
            {
                host.Credentials.ServiceCertificate.SetCertificate(StoreLocation.LocalMachine, StoreName.My, X509FindType.FindBySubjectName, "RPKey");

                host.Open();

                Console.WriteLine();
                Console.WriteLine("Press <ENTER> to terminate the host application");
                Console.ReadLine();
   
            }
        }
    }
}
