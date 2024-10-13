namespace laboratorio12
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
            n1 = new TextBox();
            n2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label4 = new Label();
            resp = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(384, 23);
            label1.Name = "label1";
            label1.Size = new Size(188, 32);
            label1.TabIndex = 0;
            label1.Text = "calculo distancia";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(179, 141);
            label2.Name = "label2";
            label2.Size = new Size(206, 32);
            label2.TabIndex = 1;
            label2.Text = "ingrese velocidad:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(198, 200);
            label3.Name = "label3";
            label3.Size = new Size(180, 32);
            label3.TabIndex = 2;
            label3.Text = "ingrese tiempo:";
            // 
            // n1
            // 
            n1.Location = new Point(395, 134);
            n1.Name = "n1";
            n1.Size = new Size(200, 39);
            n1.TabIndex = 3;
            // 
            // n2
            // 
            n2.Location = new Point(395, 200);
            n2.Name = "n2";
            n2.Size = new Size(200, 39);
            n2.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(234, 268);
            button1.Name = "button1";
            button1.Size = new Size(123, 48);
            button1.TabIndex = 5;
            button1.Text = "calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(531, 268);
            button2.Name = "button2";
            button2.Size = new Size(144, 48);
            button2.TabIndex = 6;
            button2.Text = "salir";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(372, 270);
            button3.Name = "button3";
            button3.Size = new Size(139, 46);
            button3.TabIndex = 7;
            button3.Text = "reset";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(234, 353);
            label4.Name = "label4";
            label4.Size = new Size(112, 32);
            label4.TabIndex = 8;
            label4.Text = "distancia:";
            label4.Click += label4_Click;
            // 
            // resp
            // 
            resp.Location = new Point(405, 353);
            resp.Name = "resp";
            resp.Size = new Size(200, 39);
            resp.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(resp);
            Controls.Add(label4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(n2);
            Controls.Add(n1);
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
        private TextBox n1;
        private TextBox n2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label4;
        private TextBox resp;
    }
}
