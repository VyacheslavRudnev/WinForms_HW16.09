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
            string title = "������ ��� ����";
            string messageStart = "���� ������ ��������, ��� 47 ����, � �������� � �� ���";
            MessageBox.Show(messageStart, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
            string messageMiddle = "� ��� ������ ��� ���� ������������� ��: C++, C#";
            MessageBox.Show(messageMiddle, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
            string messageEnd = "����� ������ ��� WindowsForm";
            MessageBox.Show(messageEnd, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
            int countBoxes = messageStart.Length + messageMiddle.Length + messageEnd.Length;
            int countSymbols = countBoxes / 3;
            string message = $"������� ������� ������� �� �������: {countSymbols}";
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        

        
    }
}