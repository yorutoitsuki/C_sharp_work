using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormEvent_2
{
    public class FormEvent : Form
    {
        public FormEvent()
        {
            this.Click += new EventHandler(ClickEvent);
        }
        private void ClickEvent(Object sender, EventArgs e)
        {
            MessageBox.Show("마우스 클릭 이벤트를 처리합니다.");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Application.Run(new FormEvent());
        }
    }
}
