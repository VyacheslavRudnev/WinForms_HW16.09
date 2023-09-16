namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string message1 = "������� ����� �� 1 �� 2000";
            string title = "������ �����";
            MessageBox.Show(message1, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            int min = 1;
            int max = 2000;
            int number = 0;
            int count = 0;
            while (true)
            {
                count++;
                number = (min + max) / 2;
                string message2 = $"�� ������� ����� {number} ����?";
                DialogResult result = MessageBox.Show(message2, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string message3 = $"� ������ ����� {number} �� {count} �����";
                    MessageBox.Show(message3, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                }
                else
                {
                    string message3 = $"����� {number} ����� ����������?";
                    DialogResult result2 = MessageBox.Show(message3, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result2 == DialogResult.Yes)
                    {
                        max = number;
                    }
                    else
                    {
                        min = number;
                    }
                }
            }
        }
    }
}