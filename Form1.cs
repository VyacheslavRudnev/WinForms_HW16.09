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
            string message1 = "Загадай число від 1 до 2000";
            string title = "Вгадай число";
            MessageBox.Show(message1, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            int min = 1;
            int max = 2000;
            int number = 0;
            int count = 0;
            while (true)
            {
                count++;
                number = (min + max) / 2;
                string message2 = $"Ти загадав число {number} вірно?";
                DialogResult result = MessageBox.Show(message2, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string message3 = $"Я вгадав число {number} за {count} спроб";
                    MessageBox.Show(message3, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                }
                else
                {
                    string message3 = $"Число {number} більше загаданого?";
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