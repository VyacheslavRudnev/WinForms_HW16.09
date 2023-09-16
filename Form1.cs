namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
                {
            string title = "Стисло про себе";
            string messageStart = "Мене зовуть Вячеслав, мені 47 років, я навчаюсь в КА ШАГ";
            MessageBox.Show(messageStart, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
            string messageMiddle = "Я вже вивчив такі мови програмування як: C++, C#";
            MessageBox.Show(messageMiddle, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
            string messageEnd = "Наразі працюю над WindowsForm";
            MessageBox.Show(messageEnd, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
            int countBoxes = messageStart.Length + messageMiddle.Length + messageEnd.Length;
            int countSymbols = countBoxes / 3;
            string message = $"Середня кількість символів на сторінці: {countSymbols}";
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        

        
    }
}