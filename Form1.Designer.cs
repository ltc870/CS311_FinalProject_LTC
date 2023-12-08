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
            rdoBtn2 = new RadioButton();
            rdoBtn1 = new RadioButton();
            grpBoxConverGrp2 = new GroupBox();
            rdoBtn4 = new RadioButton();
            rdoBtn3 = new RadioButton();
            lblFormula = new Label();
            label3 = new Label();
            lblTitle = new Label();
            btnInstructions = new Button();
            textBoxUnit1 = new TextBox();
            textBoxUnit2 = new TextBox();
            btnConvertRight = new Button();
            btnConvertLeft = new Button();
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
            grpBoxConverGrp1.Controls.Add(rdoBtn2);
            grpBoxConverGrp1.Controls.Add(rdoBtn1);
            grpBoxConverGrp1.Location = new Point(94, 255);
            grpBoxConverGrp1.Name = "grpBoxConverGrp1";
            grpBoxConverGrp1.Size = new Size(225, 142);
            grpBoxConverGrp1.TabIndex = 6;
            grpBoxConverGrp1.TabStop = false;
            grpBoxConverGrp1.Text = "groupBox1";
            // 
            // rdoBtn2
            // 
            rdoBtn2.AutoSize = true;
            rdoBtn2.Location = new Point(30, 92);
            rdoBtn2.Name = "rdoBtn2";
            rdoBtn2.Size = new Size(70, 29);
            rdoBtn2.TabIndex = 1;
            rdoBtn2.TabStop = true;
            rdoBtn2.Text = "Feet";
            rdoBtn2.UseVisualStyleBackColor = true;
            // 
            // rdoBtn1
            // 
            rdoBtn1.AutoSize = true;
            rdoBtn1.Location = new Point(30, 48);
            rdoBtn1.Name = "rdoBtn1";
            rdoBtn1.Size = new Size(83, 29);
            rdoBtn1.TabIndex = 0;
            rdoBtn1.TabStop = true;
            rdoBtn1.Text = "Meter";
            rdoBtn1.UseVisualStyleBackColor = true;
            // 
            // grpBoxConverGrp2
            // 
            grpBoxConverGrp2.Controls.Add(rdoBtn4);
            grpBoxConverGrp2.Controls.Add(rdoBtn3);
            grpBoxConverGrp2.Location = new Point(438, 255);
            grpBoxConverGrp2.Name = "grpBoxConverGrp2";
            grpBoxConverGrp2.Size = new Size(255, 142);
            grpBoxConverGrp2.TabIndex = 7;
            grpBoxConverGrp2.TabStop = false;
            grpBoxConverGrp2.Text = "groupBox2";
            // 
            // rdoBtn4
            // 
            rdoBtn4.AutoSize = true;
            rdoBtn4.Location = new Point(23, 92);
            rdoBtn4.Name = "rdoBtn4";
            rdoBtn4.Size = new Size(83, 29);
            rdoBtn4.TabIndex = 1;
            rdoBtn4.TabStop = true;
            rdoBtn4.Text = "Meter";
            rdoBtn4.UseVisualStyleBackColor = true;
            // 
            // rdoBtn3
            // 
            rdoBtn3.AutoSize = true;
            rdoBtn3.Location = new Point(23, 48);
            rdoBtn3.Name = "rdoBtn3";
            rdoBtn3.Size = new Size(70, 29);
            rdoBtn3.TabIndex = 0;
            rdoBtn3.TabStop = true;
            rdoBtn3.Text = "Feet";
            rdoBtn3.UseVisualStyleBackColor = true;
            // 
            // lblFormula
            // 
            lblFormula.AutoSize = true;
            lblFormula.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFormula.Location = new Point(94, 424);
            lblFormula.Name = "lblFormula";
            lblFormula.Size = new Size(115, 32);
            lblFormula.TabIndex = 8;
            lblFormula.Text = "Formula:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(215, 424);
            label3.Name = "label3";
            label3.Size = new Size(53, 32);
            label3.TabIndex = 10;
            label3.Text = "xxx";
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
            // btnInstructions
            // 
            btnInstructions.Location = new Point(581, 419);
            btnInstructions.Name = "btnInstructions";
            btnInstructions.Size = new Size(112, 34);
            btnInstructions.TabIndex = 12;
            btnInstructions.Text = "Instructions";
            btnInstructions.UseVisualStyleBackColor = true;
            // 
            // textBoxUnit1
            // 
            textBoxUnit1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxUnit1.Location = new Point(88, 194);
            textBoxUnit1.Name = "textBoxUnit1";
            textBoxUnit1.Size = new Size(225, 61);
            textBoxUnit1.TabIndex = 13;
            textBoxUnit1.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxUnit2
            // 
            textBoxUnit2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxUnit2.Location = new Point(438, 194);
            textBoxUnit2.Name = "textBoxUnit2";
            textBoxUnit2.Size = new Size(255, 61);
            textBoxUnit2.TabIndex = 14;
            textBoxUnit2.TextAlign = HorizontalAlignment.Center;
            // 
            // btnConvertRight
            // 
            btnConvertRight.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnConvertRight.Location = new Point(319, 184);
            btnConvertRight.Name = "btnConvertRight";
            btnConvertRight.Size = new Size(112, 34);
            btnConvertRight.TabIndex = 15;
            btnConvertRight.Text = "--->";
            btnConvertRight.UseVisualStyleBackColor = true;
            // 
            // btnConvertLeft
            // 
            btnConvertLeft.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnConvertLeft.Location = new Point(319, 233);
            btnConvertLeft.Name = "btnConvertLeft";
            btnConvertLeft.Size = new Size(112, 34);
            btnConvertLeft.TabIndex = 16;
            btnConvertLeft.Text = "<---";
            btnConvertLeft.UseVisualStyleBackColor = true;
            // 
            // formUnitConverter
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 499);
            Controls.Add(btnConvertLeft);
            Controls.Add(btnConvertRight);
            Controls.Add(textBoxUnit2);
            Controls.Add(textBoxUnit1);
            Controls.Add(btnInstructions);
            Controls.Add(lblTitle);
            Controls.Add(label3);
            Controls.Add(lblFormula);
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
        private RadioButton rdoBtn2;
        private RadioButton rdoBtn1;
        private GroupBox grpBoxConverGrp2;
        private RadioButton rdoBtn4;
        private RadioButton rdoBtn3;
        private Label lblFormula;
        private Label label3;
        private Label lblTitle;
        private Button btnInstructions;
        private TextBox textBoxUnit1;
        private TextBox textBoxUnit2;
        private Button btnConvertRight;
        private Button btnConvertLeft;
    }
}
