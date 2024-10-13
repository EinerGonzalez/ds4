namespace laboratorio_12._2
{
    partial class resultado
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
            button1 = new Button();
            btn2 = new Button();
            button3 = new Button();
            label4 = new Label();
            txt2 = new TextBox();
            n3 = new TextBox();
            n2 = new TextBox();
            n1 = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(69, 67);
            label1.Name = "label1";
            label1.Size = new Size(132, 32);
            label1.TabIndex = 0;
            label1.Text = "NOTA No.1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(88, 133);
            label2.Name = "label2";
            label2.Size = new Size(132, 32);
            label2.TabIndex = 1;
            label2.Text = "NOTA No.2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(82, 215);
            label3.Name = "label3";
            label3.Size = new Size(132, 32);
            label3.TabIndex = 2;
            label3.Text = "NOTA No.3";
            // 
            // button1
            // 
            button1.Location = new Point(142, 278);
            button1.Name = "button1";
            button1.Size = new Size(164, 39);
            button1.TabIndex = 3;
            button1.Text = "promedio";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btn2
            // 
            btn2.Location = new Point(342, 279);
            btn2.Name = "btn2";
            btn2.Size = new Size(135, 38);
            btn2.TabIndex = 4;
            btn2.Text = "reset";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(531, 279);
            button3.Name = "button3";
            button3.Size = new Size(145, 38);
            button3.TabIndex = 5;
            button3.Text = "salir";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(71, 374);
            label4.Name = "label4";
            label4.Size = new Size(177, 32);
            label4.TabIndex = 6;
            label4.Text = "Nota promedio";
            // 
            // txt2
            // 
            txt2.Location = new Point(261, 377);
            txt2.Name = "txt2";
            txt2.Size = new Size(200, 39);
            txt2.TabIndex = 7;
            // 
            // n3
            // 
            n3.Location = new Point(272, 214);
            n3.Name = "n3";
            n3.Size = new Size(200, 39);
            n3.TabIndex = 8;
            // 
            // n2
            // 
            n2.Location = new Point(272, 143);
            n2.Name = "n2";
            n2.Size = new Size(200, 39);
            n2.TabIndex = 9;
            // 
            // n1
            // 
            n1.Location = new Point(272, 67);
            n1.Name = "n1";
            n1.Size = new Size(200, 39);
            n1.TabIndex = 10;
            n1.TextChanged += n1_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(275, 9);
            label5.Name = "label5";
            label5.Size = new Size(202, 32);
            label5.TabIndex = 11;
            label5.Text = "NOTA PROMEDIO";
            // 
            // resultado
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(840, 438);
            Controls.Add(label5);
            Controls.Add(n1);
            Controls.Add(n2);
            Controls.Add(n3);
            Controls.Add(txt2);
            Controls.Add(label4);
            Controls.Add(button3);
            Controls.Add(btn2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "resultado";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button btn2;
        private Button button3;
        private Label label4;
        private TextBox txt2;
        private TextBox n3;
        private TextBox n2;
        private TextBox n1;
        private Label label5;
    }
}
