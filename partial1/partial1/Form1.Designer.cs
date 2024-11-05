namespace partial1
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
            e1 = new TextBox();
            e2 = new TextBox();
            button1 = new Button();
            listBox1 = new ListBox();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // e1
            // 
            e1.Location = new Point(297, 51);
            e1.Name = "e1";
            e1.Size = new Size(200, 39);
            e1.TabIndex = 0;
            // 
            // e2
            // 
            e2.Location = new Point(297, 109);
            e2.Name = "e2";
            e2.Size = new Size(200, 39);
            e2.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(107, 180);
            button1.Name = "button1";
            button1.Size = new Size(175, 46);
            button1.TabIndex = 2;
            button1.Text = "confirmacion";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(324, 197);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(502, 164);
            listBox1.TabIndex = 3;
            // 
            // button2
            // 
            button2.Location = new Point(619, 378);
            button2.Name = "button2";
            button2.Size = new Size(150, 46);
            button2.TabIndex = 5;
            button2.Text = "limpiar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 58);
            label1.Name = "label1";
            label1.Size = new Size(233, 32);
            label1.TabIndex = 6;
            label1.Text = "cantidad de archivos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 116);
            label2.Name = "label2";
            label2.Size = new Size(172, 32);
            label2.TabIndex = 7;
            label2.Text = "tamano en MB";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(839, 491);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Controls.Add(e2);
            Controls.Add(e1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox e1;
        private TextBox e2;
        private Button button1;
        private ListBox listBox1;
        private Button button2;
        private Label label1;
        private Label label2;
    }
}
