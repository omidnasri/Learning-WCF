// � 2007 Michele Leroux Bustamante. All rights reserved 
// Book: Learning WCF, O'Reilly
// Book Blog: www.thatindigogirl.com
// Michele's Blog: www.dasblonde.net
// IDesign: www.idesign.net

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;
using System.ServiceModel;

namespace Client
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            this.Text += ": ThreadId " + Thread.CurrentThread.GetHashCode().ToString();

        }
 
        private void button1_Click(object sender, EventArgs e)
        {
            using (localhost.MessagingServiceClient m_proxy = new localhost.MessagingServiceClient())
            {
                m_proxy.SendMessage(string.Format("Hello from {0}", this.Text));
            }
        }
    }
}