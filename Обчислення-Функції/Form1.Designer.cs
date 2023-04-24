namespace Обчислення_Функції
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(33, 14);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(296, 23);
            textBox1.TabIndex = 0;
            textBox1.Text = "0";
            textBox1.TextAlign = HorizontalAlignment.Right;
            textBox1.Click += textBox3_Click;
            textBox1.TextChanged += textBox3_TextChanged;
            textBox1.KeyPress += textBox1_KeyPress;
            textBox1.Validating += textBox3_Validating;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(33, 53);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(296, 23);
            textBox2.TabIndex = 1;
            textBox2.Text = "0";
            textBox2.TextAlign = HorizontalAlignment.Right;
            textBox2.Click += textBox3_Click;
            textBox2.TextChanged += textBox3_TextChanged;
            textBox2.KeyPress += textBox1_KeyPress;
            textBox2.Validating += textBox3_Validating;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(33, 92);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(296, 23);
            textBox3.TabIndex = 2;
            textBox3.Text = "0";
            textBox3.TextAlign = HorizontalAlignment.Right;
            textBox3.Click += textBox3_Click;
            textBox3.TextChanged += textBox3_TextChanged;
            textBox3.KeyPress += textBox1_KeyPress;
            textBox3.Validating += textBox3_Validating;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(33, 205);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(296, 23);
            textBox4.TabIndex = 3;
            textBox4.TextAlign = HorizontalAlignment.Right;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(11, 143);
            button1.Name = "button1";
            button1.Size = new Size(156, 40);
            button1.TabIndex = 4;
            button1.Text = "Обчислення без функцій";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(173, 143);
            button2.Name = "button2";
            button2.Size = new Size(156, 40);
            button2.TabIndex = 5;
            button2.Text = "Обчислення з функціями";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(80, 261);
            button3.Name = "button3";
            button3.Size = new Size(156, 40);
            button3.TabIndex = 6;
            button3.Text = "Завершити роботу";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(340, 313);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}