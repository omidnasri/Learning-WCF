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
using System.ServiceModel;
using System.Threading;
using UIService;

namespace WindowsHost
{
    public partial class Form1 : Form
    {
        ServiceHost m_serviceHost;

        public Form1()
        {
            InitializeComponent();
            this.Text += ": " + Thread.CurrentThread.GetHashCode();
            this.button2.Enabled=false;

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.button1.Enabled=false;
            this.button2.Enabled=true;
            m_serviceHost = new ServiceHost(typeof(UIService.UIService));
            m_serviceHost.Open();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.button1.Enabled=true;
            this.button2.Enabled=false;
            
            m_serviceHost.Close();
            m_serviceHost=null;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to close the service?", "Service Controller", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                if (m_serviceHost!=null)
                {
                    m_serviceHost.Close();
                    m_serviceHost =null;
                }
            }
            else
                e.Cancel=true;
        }


        private void button3_Click(object sender, EventArgs e)
        {
                UIService.UIService.ShowForm(true);
        }
    }
}