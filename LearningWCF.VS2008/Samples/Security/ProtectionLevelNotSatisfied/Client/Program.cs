// � 2007 Michele Leroux Bustamante. All rights reserved 
// Book: Learning WCF, O'Reilly
// Book Blog: www.thatindigogirl.com
// Michele's Blog: www.dasblonde.net
// IDesign: www.idesign.net

using System;
using System.Collections.Generic;
using System.Text;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            using (localhost.HelloIndigoServiceClient proxy = new Client.localhost.HelloIndigoServiceClient())
            {
                string s = proxy.HelloIndigo("Hello from client...");
                Console.WriteLine(s);
                Console.ReadLine();
            }


        }
    }
}
