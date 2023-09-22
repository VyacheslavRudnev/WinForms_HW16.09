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
            return "���������� ����: �=" + e.X.ToString() + "; y=" + e.Y.ToString();
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
                message = "�� ��������� ����� ������ ����." +
                    "\n������ ������ ������ = " + Width + "," +
                    "\n������ ������ ������= " + Height;

            }
            if (e.Button == MouseButtons.Left)
            {
                if (Control.ModifierKeys != Keys.Control)
                {
                    message = "�� ��������� ��� ������ ����.";
                    if (e.X > 15 && e.X < 782 && e.Y > 15 && e.Y < 434)
                    {
                        MessageBox.Show("�������� �������� ������������");
                    }
                    else if (e.X < 10 || e.X > 787 || e.Y < 10 || e.Y > 439)
                    {
                        MessageBox.Show("�������� ���� ����o�������");
                    }
                    else
                    {
                        MessageBox.Show("�������� �� ��� ������������");
                    }
                }
                else
                {
                    Close();
                }
            }
            message += "\n" + CoordinatesToString(e);
            String caption = "���� ����";
            MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}