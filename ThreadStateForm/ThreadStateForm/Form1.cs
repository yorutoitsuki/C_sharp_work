using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace ThreadStateForm
{
    public partial class Form1 : Form
    {
        private Thread thd;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThreadState_Click(object sender, EventArgs e)
        {
            thd = new Thread(new ThreadStart(ThreadFunction));
            tbThreadState.Text += "스레드 식별 : " + thd.GetHashCode() + "\r\n";
            thd.Start();
            tbThreadState.Text += "스레드 상태 : " + thd.ThreadState + "\r\n";
        }

        private void btnSuspend_Click(object sender, EventArgs e)
        {

        }

        private void btnResume_Click(object sender, EventArgs e)
        {

        }
        private void ThreadFunction()
        {
            int count = 0;
            while(count < 100)
            {
                count++;
                Thread.Sleep(1000);
                tbThreadState.Text += "스레드 상태 : " + thd.ThreadState + "\r\n";
            }
        }
    }
}
