namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public event MouseEventHandler MoveMous;
        public delegate void MouseEventHandler(Object sender, MouseEventArgs e);
        private string CoordinatesToString(MouseEventArgs e)
        {
            return "Координати миші: х=" + e.X.ToString() + "; y=" + e.Y.ToString();
        }
        private void Form1_MoveMous(object sender, MouseEventArgs e)
        {
            Text = CoordinatesToString(e);
        }
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            String message = "";
            if (e.Button == MouseButtons.Right)
            {
                message = "Ви натиснули праву кнопку миші." +
                    "\nШирина робочої області = " + Width + "," +
                    "\nВисота робочої області= " + Height;

            }
            if (e.Button == MouseButtons.Left)
            {
                if (Control.ModifierKeys != Keys.Control)
                {
                    message = "Ви натиснули ліву кнопку миші.";
                    if (e.X > 15 && e.X < 782 && e.Y > 15 && e.Y < 434)
                    {
                        MessageBox.Show("Вказівник всередені прямокутника");
                    }
                    else if (e.X < 10 || e.X > 787 || e.Y < 10 || e.Y > 439)
                    {
                        MessageBox.Show("Вказівник зовні прямoкутника");
                    }
                    else
                    {
                        MessageBox.Show("Вказівник на межі прямокутника");
                    }
                }
                else
                {
                    Close();
                }
            }
            message += "\n" + CoordinatesToString(e);
            String caption = "Клик мыши";
            MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}