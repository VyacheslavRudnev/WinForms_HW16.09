namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(147, 28);
            label1.TabIndex = 0;
            label1.Text = "Завдання №2";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(0, 28);
            label2.Name = "label2";
            label2.Size = new Size(512, 140);
            label2.TabIndex = 1;
            label2.Text = resources.GetString("label2.Text");
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.BackColor = Color.LightSkyBlue;
            button1.CausesValidation = false;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Calibri", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Navy;
            button1.Location = new Point(208, 222);
            button1.Name = "button1";
            button1.Size = new Size(332, 40);
            button1.TabIndex = 2;
            button1.Text = "ГРА \"ВГАДАЙ ЧИСЛО\"\r\n";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(800, 451);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ми й не сумнівалися, що Ви саме так вважаєте!");
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
    }
}