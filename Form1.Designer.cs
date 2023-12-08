namespace CS311_FinalProject_LTC
{
    partial class formUnitConverter
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
            cboBoxUnitPicker = new ComboBox();
            grpBoxConverGrp1 = new GroupBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            grpBoxConverGrp2 = new GroupBox();
            radioButton4 = new RadioButton();
            radioButton3 = new RadioButton();
            label1 = new Label();
            lblEqualSign = new Label();
            label3 = new Label();
            lblTitle = new Label();
            button1 = new Button();
            textBoxUnit1 = new TextBox();
            textBoxUnit2 = new TextBox();
            grpBoxConverGrp1.SuspendLayout();
            grpBoxConverGrp2.SuspendLayout();
            SuspendLayout();
            // 
            // cboBoxUnitPicker
            // 
            cboBoxUnitPicker.FormattingEnabled = true;
            cboBoxUnitPicker.Items.AddRange(new object[] { "Length", "Mass", "Temperature" });
            cboBoxUnitPicker.Location = new Point(94, 128);
            cboBoxUnitPicker.Name = "cboBoxUnitPicker";
            cboBoxUnitPicker.Size = new Size(560, 33);
            cboBoxUnitPicker.TabIndex = 0;
            // 
            // grpBoxConverGrp1
            // 
            grpBoxConverGrp1.Controls.Add(radioButton2);
            grpBoxConverGrp1.Controls.Add(radioButton1);
            grpBoxConverGrp1.Location = new Point(94, 255);
            grpBoxConverGrp1.Name = "grpBoxConverGrp1";
            grpBoxConverGrp1.Size = new Size(225, 142);
            grpBoxConverGrp1.TabIndex = 6;
            grpBoxConverGrp1.TabStop = false;
            grpBoxConverGrp1.Text = "groupBox1";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(30, 92);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(141, 29);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "radioButton2";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(30, 48);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(141, 29);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "radioButton1";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // grpBoxConverGrp2
            // 
            grpBoxConverGrp2.Controls.Add(radioButton4);
            grpBoxConverGrp2.Controls.Add(radioButton3);
            grpBoxConverGrp2.Location = new Point(438, 255);
            grpBoxConverGrp2.Name = "grpBoxConverGrp2";
            grpBoxConverGrp2.Size = new Size(255, 142);
            grpBoxConverGrp2.TabIndex = 7;
            grpBoxConverGrp2.TabStop = false;
            grpBoxConverGrp2.Text = "groupBox2";
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(23, 92);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(141, 29);
            radioButton4.TabIndex = 1;
            radioButton4.TabStop = true;
            radioButton4.Text = "radioButton4";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(23, 48);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(141, 29);
            radioButton3.TabIndex = 0;
            radioButton3.TabStop = true;
            radioButton3.Text = "radioButton3";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(94, 424);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 8;
            label1.Text = "label1";
            // 
            // lblEqualSign
            // 
            lblEqualSign.AutoSize = true;
            lblEqualSign.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEqualSign.Location = new Point(363, 218);
            lblEqualSign.Name = "lblEqualSign";
            lblEqualSign.Size = new Size(31, 32);
            lblEqualSign.TabIndex = 9;
            lblEqualSign.Text = "=";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(206, 424);
            label3.Name = "label3";
            label3.Size = new Size(59, 25);
            label3.TabIndex = 10;
            label3.Text = "label3";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(297, 53);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(178, 32);
            lblTitle.TabIndex = 11;
            lblTitle.Text = "Unit Converter";
            // 
            // button1
            // 
            button1.Location = new Point(581, 419);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 12;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBoxUnit1
            // 
            textBoxUnit1.Location = new Point(94, 218);
            textBoxUnit1.Name = "textBoxUnit1";
            textBoxUnit1.Size = new Size(225, 31);
            textBoxUnit1.TabIndex = 13;
            textBoxUnit1.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxUnit2
            // 
            textBoxUnit2.Location = new Point(438, 218);
            textBoxUnit2.Name = "textBoxUnit2";
            textBoxUnit2.Size = new Size(255, 31);
            textBoxUnit2.TabIndex = 14;
            textBoxUnit2.TextAlign = HorizontalAlignment.Center;
            // 
            // formUnitConverter
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 499);
            Controls.Add(textBoxUnit2);
            Controls.Add(textBoxUnit1);
            Controls.Add(button1);
            Controls.Add(lblTitle);
            Controls.Add(label3);
            Controls.Add(lblEqualSign);
            Controls.Add(label1);
            Controls.Add(grpBoxConverGrp2);
            Controls.Add(grpBoxConverGrp1);
            Controls.Add(cboBoxUnitPicker);
            Name = "formUnitConverter";
            Text = "Form1";
            grpBoxConverGrp1.ResumeLayout(false);
            grpBoxConverGrp1.PerformLayout();
            grpBoxConverGrp2.ResumeLayout(false);
            grpBoxConverGrp2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboBoxUnitPicker;
        private GroupBox grpBoxConverGrp1;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private GroupBox grpBoxConverGrp2;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private Label label1;
        private Label lblEqualSign;
        private Label label3;
        private Label lblTitle;
        private Button button1;
        private TextBox textBoxUnit1;
        private TextBox textBoxUnit2;
    }
}
