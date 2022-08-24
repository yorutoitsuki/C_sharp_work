using System.Windows.Forms;
using System.Drawing;

class Sample2
{
    public static void Main()
    {
        Form fm = new Form();
        fm.Text = "Welcom to C#";

        Label lb = new Label();
        lb.Width = 150;
        lb.Text = "Start C#";
        lb.Parent = fm;

        PictureBox pb = new PictureBox();
        pb.Image = Image.FromFile("C:\\Users\\yn-17\\2022_영남_이승기\\HTML\\Image\\flower.jpg");
        pb.Parent = fm;

        Application.Run(fm);
    }
}