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
                CreateStaticLabel(X, Y, e.X, e.Y);
            }
            else
            {
                MessageBox.Show("��� ��������� ������� ���������� ��� ������ ����.", "�������!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CreateStaticLabel(int startX, int startY, int endX, int endY)
        {
            if (Math.Abs(endX - startX) <= 10 || Math.Abs(endY - startY) <= 10)
            {
                MessageBox.Show("����� ������� ������� ���� ����� �� 10�10", "�������!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Label label = new Label
            {
                BorderStyle = BorderStyle.Fixed3D,
                Location = new Point(Math.Min(startX, endX), Math.Min(startY, endY)),
                Size = new Size(Math.Abs(endX - startX), Math.Abs(endY - startY)),
                Text = numStatic.ToString(),
                TextAlign = ContentAlignment.MiddleCenter,
                ForeColor = Color.White,
                BackColor = Color.Blue,
            };

            Controls.Add(label);

            Text = $"�C���� �{numStatic} ��������";
            label.BringToFront();

            label.MouseClick += Label_MouseClick;
            label.DoubleClick += Label_MouseDoubleClick;
            numStatic++;
        }
        private void Label_MouseDoubleClick(object sender, EventArgs e)
        {
            if (e is MouseEventArgs)
            {
                int smallestStaticNumber = numStatic;
                MouseEventArgs mouseEventArgs = e as MouseEventArgs;
                if (mouseEventArgs.Button == MouseButtons.Left)
                {
                    var staticLabels = Controls.OfType<Label>();

                    foreach (Label label in staticLabels)
                    {
                        Point location = label.PointToScreen(Point.Empty);
                        if (MousePosition.X > location.X && MousePosition.X < location.X + label.Width &&
                            MousePosition.Y > location.Y && MousePosition.Y < location.Y + label.Height)
                        {
                            if (int.TryParse(label.Text, out int labelNumber))
                            {
                                if (smallestStaticNumber > labelNumber)
                                {
                                    smallestStaticNumber = labelNumber;
                                }
                            }
                        }
                    }

                    foreach (Label label in staticLabels)
                    {
                        if (int.TryParse(label.Text, out int labelNumber))
                        {
                            if (smallestStaticNumber == labelNumber)
                            {
                                Text = $"�C���� �{labelNumber} ��������";
                                Controls.Remove(label);
                                label.MouseClick -= Label_MouseClick;
                                label.DoubleClick -= Label_MouseDoubleClick;
                            }
                        }
                    }
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