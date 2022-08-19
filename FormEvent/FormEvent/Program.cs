using System.Windows.Forms;

namespace FormEvent
{
    public class FormEvent
    {
        public FormEvent()
        {
            this.Click += new EventHandler(ClickEvent);
        }

        private void ClickEvent (object sender, EventArgs e)
        {
            MessageBox.Show("마우스 클릭 이벤트를 처리합니다");
        }
    }

    class Program
    {
        static void Main()
        {
            Application.Run(new FormEvent());
        }
    }
}
