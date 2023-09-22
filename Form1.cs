namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        //Задание 4
        //Разработать приложение, созданное на основе форме.
        //- Пользователь «щелкает» левой кнопкой мыши по форме и,
        //не отпуская кнопку, ведет по ней мышку, а в момент отпу-
        //скания кнопки по полученным координатам прямоуголь-
        //ника(вам, конечно, известно, что двух точек на плоскости
        //достаточно для создания прямоугольника) необходимо со-
        //здать «статик», который содержит свой порядковый номер
        //(имеется в виду порядок появления на форме).
        //- Минимальный размер «статика» составляет 10х10, при по-
        //пытке создания элемента меньших размеров пользователь
        //должен увидеть соответствующее предупреждение.
        //- При щелчке правой кнопкой мыши над поверхностью
        //«статика» в заголовке окна должна появиться информа-
        //ция о его площади и координатах (относительно формы).
        //В случае, если в точке щелчка находится несколько «ста-
        //тиков», то предпочтение отдается «статику» с наибольшим
        //порядковым номером.
        //- При двойном щелчке левой кнопки мыши над поверхно-
        //стью «статика» он должен исчезнуть с формы.В случае,
        //если в точке щелчка находится несколько «статиков», то
        //предпочтение отдается «статику» с наименьшим порядко-
        //вым номером.
        int X { get; set; }
        int Y { get; set; }
        int numStatic = 1;

        public Form1()
        {
            InitializeComponent();
            Text = "Домашне завдання №4";
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
                    MessageBox.Show("Розмір «статіку» повинен бути більше ніж 10х10", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    label.Size = new Size(Math.Abs(e.X - X), Math.Abs(e.Y - Y));
                    label.Text = numStatic.ToString();
                    label.TextAlign = ContentAlignment.MiddleCenter;
                    label.ForeColor = Color.White;
                    label.BackColor = Color.Blue;
                    Controls.Add(label);
        
                    Text = $"«Cтатік» №{numStatic} створено";
                   
                    //Controls.Add(label);
                    label.MouseClick += Label_MouseClick;
                    label.DoubleClick += Label_MouseDoubleClick;
                    numStatic++;
                }
            }
            else
            {
                MessageBox.Show("Для створення «статіка» натискайте ліву кнопку миші.", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    Text = $"«Cтатік» №{label.Text} видалено";
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
                Text = $"Площа «статіка» №{label.Text}: {label.Width * label.Height} Координати: {label.Location.X}, {label.Location.Y}";
            }
        }
        


    }
}