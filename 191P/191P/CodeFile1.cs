using System;
using System.Windows.Forms;


/*
 * 
 * 
 * 
 * 버튼 이벤트가 키보드 이벤트를 모두 흡수해버림,
 * 버튼 이벤트와 키보드 이벤트를 따로 구현해야함
 * 
 * 
 * 
 */
class Sample2 : Form
{
    private Label lb1, lb2;

    public static void Main()
    {
        Application.Run(new Sample2());

    }
    public Sample2()
    {
        this.Text = "샘플";
        this.Width = 250; this.Height = 300;

        lb1 = new Label();
        lb1.Text = "어서오세요";
        lb1.Width = 150;

        lb2 = new Label();
        lb2.Text = "방향키를 입력해주세요";
        lb2.Top = lb1.Bottom;
        lb1.Parent = this;
        lb2.Parent = this;
        this.KeyDown += new KeyEventHandler(fm_KeyDown);
        lb1.MouseEnter += new EventHandler(fm_MouseEnter);
        lb1.MouseLeave += new EventHandler(fm_MouseLeave);



    }
    public void fm_MouseEnter(Object sender, EventArgs e)
    {
        lb1.Text = "안녕하세요";
    }
    public void fm_MouseLeave(Object sender, EventArgs e)
    {
        lb1.Text = "안녕히 가세요";
    }
    public void fm_KeyDown(Object sender, KeyEventArgs e)
    {
        lb1.Text = "Error";
        String str;
        if (e.KeyCode == Keys.Up)
        {
            str = "위쪽";
        }
        else if (e.KeyCode == Keys.Down)
        {
            str = "아래쪽";
        }
        else if (e.KeyCode == Keys.Left)
        {
            str = "왼쪽";
        }
        else if (e.KeyCode == Keys.Right)
        {
            str = "오른쪽";
        }
        else
        {
            str = "다른키";
        }
        lb2.Text = str;
    }
}