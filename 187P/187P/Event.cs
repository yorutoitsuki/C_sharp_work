using System.Windows;
using System.Windows.Forms;
using System.Drawing;
using System;

class Sample1 : Form
{
    private Label lb;

    public static void Main()
    {
        Application.Run(new Sample1());
    }
    public Sample1()
    {
        this.Text = "Sample";
        this.Width = 250; this.Height = 200;

        lb = new Label();
        lb.Text = "Welcom";

        lb.Parent = this;

        this.Click += new EventHandler(fm_Click);
    }
    public void fm_Click(object sender, EventArgs e)
    {
        lb.Text = "Hello";
    }
}