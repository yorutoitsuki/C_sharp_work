using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyMessageEvent
{
    public partial class Form1 : Form
    {
        private string str = "";
        private string substr = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter || e.KeyCode == Keys.Space)
            {
                substr = str.Substring(str.Length - 1, 1);
                if (char.GetUnicodeCategory(char.Parse(substr)) ==
                    System.Globalization.UnicodeCategory.OtherLetter)
                {
                    str = str.Substring(0, str.Length - 1);
                }
            } 
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            str += e.KeyChar;
            label1.Text = str;
        }
    }
}
