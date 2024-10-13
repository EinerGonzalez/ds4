namespace laboratorio12._2
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            n1 = new TextBox();
            n2 = new TextBox();
            n3 = new TextBox();
            txt1 = new TextBox();
            txt2 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(72, 61);
            label1.Name = "label1";
            label1.Size = new Size(328, 32);
            label1.TabIndex = 0;
            label1.Text = "ingresa la longitud del lado A";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(80, 116);
            label2.Name = "label2";
            label2.Size = new Size(327, 32);
            label2.TabIndex = 1;
            label2.Text = "ingresa la longitud del lado B";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(93, 156);
            label3.Name = "label3";
            label3.Size = new Size(328, 32);
            label3.TabIndex = 2;
            label3.Text = "ingresa la longitud del lado C";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(60, 312);
            label4.Name = "label4";
            label4.Size = new Size(256, 32);
            label4.TabIndex = 3;
            label4.Text = "calcular semiperimetro";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(60, 374);
            label5.Name = "label5";
            label5.Size = new Size(202, 32);
            label5.TabIndex = 4;
            label5.Text = "area del triangulo";
            label5.Click += label5_Click;
            // 
            // button1
            // 
            button1.Location = new Point(34, 233);
            button1.Name = "button1";
            button1.Size = new Size(188, 46);
            button1.TabIndex = 5;
            button1.Text = "semiperimetro";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(250, 233);
            button2.Name = "button2";
            button2.Size = new Size(150, 46);
            button2.TabIndex = 6;
            button2.Text = "area";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(433, 236);
            button3.Name = "button3";
            button3.Size = new Size(150, 46);
            button3.TabIndex = 7;
            button3.Text = "reset";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(614, 236);
            button4.Name = "button4";
            button4.Size = new Size(150, 46);
            button4.TabIndex = 8;
            button4.Text = "salida";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // n1
            // 
            n1.Location = new Point(427, 61);
            n1.Name = "n1";
            n1.Size = new Size(200, 39);
            n1.TabIndex = 9;
            n1.TextChanged += textBox1_TextChanged;
            // 
            // n2
            // 
            n2.Location = new Point(427, 106);
            n2.Name = "n2";
            n2.Size = new Size(200, 39);
            n2.TabIndex = 10;
            // 
            // n3
            // 
            n3.Location = new Point(427, 151);
            n3.Name = "n3";
            n3.Size = new Size(200, 39);
            n3.TabIndex = 11;
            n3.TextChanged += textBox3_TextChanged;
            // 
            // txt1
            // 
            txt1.Location = new Point(346, 314);
            txt1.Name = "txt1";
            txt1.Size = new Size(200, 39);
            txt1.TabIndex = 12;
            // 
            // txt2
            // 
            txt2.Location = new Point(419, 375);
            txt2.Name = "txt2";
            txt2.Size = new Size(200, 39);
            txt2.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txt2);
            Controls.Add(txt1);
            Controls.Add(n3);
            Controls.Add(n2);
            Controls.Add(n1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private TextBox n1;
        private TextBox n2;
        private TextBox n3;
        private TextBox txt1;
        private TextBox txt2;
    }
}
