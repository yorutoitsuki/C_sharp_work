using System;
using System.Windows.Forms;

class Sample4 : Form
{
    private Label lb1, lb2,lb3;
    public static void Main()
    {
        Application.Run(new Sample4());
    }

    public Sample4()
    {
        this.Text = "샘플";
        this.Width = 250; this.Height = 100;

        lb1 = new Label();
        lb1.Text = "방향키로 선택하세요";
        lb1.Width = this.Width;

        lb2 = new Label();
        lb2.Top = lb1.Bottom;

        lb3 = new Label();
        lb3.Text = "testing";
        lb3.Top = lb2.Bottom;

        lb1.Parent = this;
        lb2.Parent = this;
        lb3.Parent = this;
        this.KeyDown += new KeyEventHandler(fm_KeyDown);
        lb3.MouseEnter += new EventHandler(mouseEnter);
        lb3.MouseLeave += new EventHandler(mouseLeave);
    }

    public void mouseEnter(object sender, EventArgs e)
    {
        lb3.Text = "test in";
    }
    public void mouseLeave(object sender, EventArgs e)
    {
        lb3.Text = "test out";
    }


    public void fm_KeyDown(object sender, KeyEventArgs e)
    {
        String str;
        if(e.KeyCode == Keys.Up)
        {
            str = "위쪽";
        }
        else if(e.KeyCode == Keys.Down)
        {
            str = "아래쪽";
        }
        else if(e.KeyCode == Keys.Left)
        {
            str = "왼쪽";
        }
        else if(e.KeyCode == Keys.Right)
        {
            str = "오른쪽";
        }
        else
        {
            str = "다른 키";
        }
        lb2.Text = str;
    }

}