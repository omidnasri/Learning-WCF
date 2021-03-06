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
using System.Transactions;
using System.Threading;

namespace CountersClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            GetCounters();

        }

        localhost.CountersServiceClient m_proxy = new CountersClient.localhost.CountersServiceClient();


        private void GetCounters()
        {
            this.bindingSource1.DataSource = m_proxy.GetCounters();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                TransactionOptions options = new TransactionOptions();
                options.IsolationLevel = System.Transactions.IsolationLevel.Serializable;
//                options.Timeout = new TimeSpan(0, 0, 3);
                using (TransactionScope scope = new TransactionScope(TransactionScopeOption.Required, options))
                {
                    m_proxy.SetCounter1(int.Parse(this.txtCounter.Text));
                    
                    // pause for transaction timeout
  //                  Thread.Sleep(5000);

                    m_proxy.SetCounter2(int.Parse(this.txtCounter.Text));

                    scope.Complete();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                m_proxy = new CountersClient.localhost.CountersServiceClient();
            }

            GetCounters();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                m_proxy.ResetCounters();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                m_proxy = new CountersClient.localhost.CountersServiceClient();
            }

            GetCounters();
        }
    }
}