namespace CS311_FinalProject_LTC
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
            comboBox1 = new ComboBox();
            richTextBox1 = new RichTextBox();
            richTextBox2 = new RichTextBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(94, 61);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(525, 33);
            comboBox1.TabIndex = 0;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(94, 124);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(225, 59);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(403, 124);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(216, 59);
            richTextBox2.TabIndex = 2;
            richTextBox2.Text = "";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(94, 180);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(225, 33);
            comboBox2.TabIndex = 3;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(403, 180);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(216, 33);
            comboBox3.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(94, 253);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(richTextBox2);
            Controls.Add(richTextBox1);
            Controls.Add(comboBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private RichTextBox richTextBox1;
        private RichTextBox richTextBox2;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private TextBox textBox1;
    }
}
