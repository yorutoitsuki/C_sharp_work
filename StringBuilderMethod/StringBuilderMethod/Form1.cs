using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringBuilderMethod
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        StringBuilder str = new StringBuilder("용돈이 저그냐",7);

        private void btnBase_Click(object sender, EventArgs e)
        {
            lblResult.Text = str.ToString();
        }

        private void btnAppend_Click(object sender, EventArgs e)
        {
            str.Append("~옹옹옹");
            lblResult.Text = str.ToString();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            str.Remove(4, 2);
            lblResult.Text = str.ToString();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            str.Insert(4, "마느");
            lblResult.Text=str.ToString();
        }
    }
}
