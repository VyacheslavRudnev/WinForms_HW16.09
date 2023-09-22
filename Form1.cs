namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        //������� 4
        //����������� ����������, ��������� �� ������ �����.
        //- ������������ �������� ����� ������� ���� �� ����� �,
        //�� �������� ������, ����� �� ��� �����, � � ������ ����-
        //������ ������ �� ���������� ����������� ����������-
        //����(���, �������, ��������, ��� ���� ����� �� ���������
        //���������� ��� �������� ��������������) ���������� ��-
        //����� �������, ������� �������� ���� ���������� �����
        //(������� � ���� ������� ��������� �� �����).
        //- ����������� ������ �������� ���������� 10�10, ��� ��-
        //����� �������� �������� ������� �������� ������������
        //������ ������� ��������������� ��������������.
        //- ��� ������ ������ ������� ���� ��� ������������
        //�������� � ��������� ���� ������ ��������� �������-
        //��� � ��� ������� � ����������� (������������ �����).
        //� ������, ���� � ����� ������ ��������� ��������� ����-
        //�����, �� ������������ �������� �������� � ����������
        //���������� �������.
        //- ��� ������� ������ ����� ������ ���� ��� ��������-
        //���� �������� �� ������ ��������� � �����.� ������,
        //���� � ����� ������ ��������� ��������� ���������, ��
        //������������ �������� �������� � ���������� �������-
        //��� �������.
        int X { get; set; }
        int Y { get; set; }
        int numStatic = 1;

        public Form1()
        {
            InitializeComponent();
            Text = "������� �������� �4";
            MouseDown += Form1_MouseDown;
            MouseUp += Form1_MouseUp;
        }
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                X = e.X;
                Y = e.Y;
            }
        }
        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Label label = new Label();
                label.BorderStyle = BorderStyle.Fixed3D;
                
                if (e.X > X && e.Y > Y)
                {
                    label.Location = new Point(X, Y);
                }
                else if (e.X > X && e.Y < Y)
                {
                    label.Location = new Point(X, e.Y);
                }
                else if (e.X < X && e.Y > Y)
                {
                    label.Location = new Point(e.X, Y);
                }
                else
                {
                    label.Location = new Point(e.X, e.Y);
                }

                if (Math.Abs(e.X - X) <= 10 || Math.Abs(e.Y - Y) <= 10)
                {
                    MessageBox.Show("����� ������� ������� ���� ����� �� 10�10", "�������!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    label.Size = new Size(Math.Abs(e.X - X), Math.Abs(e.Y - Y));
                    label.Text = numStatic.ToString();
                    label.TextAlign = ContentAlignment.MiddleCenter;
                    label.ForeColor = Color.White;
                    label.BackColor = Color.Blue;
                    Controls.Add(label);
        
                    Text = $"�C���� �{numStatic} ��������";
                   
                    //Controls.Add(label);
                    label.MouseClick += Label_MouseClick;
                    label.DoubleClick += Label_MouseDoubleClick;
                    numStatic++;
                }
            }
            else
            {
                MessageBox.Show("��� ��������� ������� ���������� ��� ������ ����.", "�������!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void Label_MouseDoubleClick(object sender, EventArgs e)
        {
            if (e is MouseEventArgs)
            {
                int numLabel = numStatic;
                MouseEventArgs mouseEventArgs = e as MouseEventArgs;
                if (mouseEventArgs.Button == MouseButtons.Left)
                {
                    Label label = sender as Label;
                    Text = $"�C���� �{label.Text} ��������";
                    Controls.Remove(label);
                    label.MouseClick -= Label_MouseClick;
                    label.DoubleClick -= Label_MouseDoubleClick;

                }
            }
        }
        private void Label_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Label label = sender as Label;
                Text = $"����� ������� �{label.Text}: {label.Width * label.Height} ����������: {label.Location.X}, {label.Location.Y}";
            }
        }
        


    }
}