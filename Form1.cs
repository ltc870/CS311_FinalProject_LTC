namespace CS311_FinalProject_LTC
{
    public partial class formUnitConverter : Form
    {
        // class members
        private string unitType;
        private double value1;
        private double value2;


        public formUnitConverter()
        {
            InitializeComponent();
        }

        private void cboBoxUnitPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            String data = cboBoxUnitPicker.GetItemText(cboBoxUnitPicker.SelectedItem);

            unitType = data;

            switch (data)
            {
                case "Length":
                    rdoBtn1.Text = "Meter";
                    rdoBtn2.Text = "Feet";
                    rdoBtn3.Visible = true;
                    rdoBtn3.Text = "Kilometer";
                    rdoBtn4.Visible = true;
                    rdoBtn4.Text = "Mile";
                    rdoBtn5.Text = "Feet";
                    rdoBtn6.Text = "Meter";
                    rdoBtn7.Visible = true;
                    rdoBtn7.Text = "Mile";
                    rdoBtn8.Visible = true;
                    rdoBtn8.Text = "Kilometer";
                    break;
                case "Mass":
                    rdoBtn1.Text = "Kilogram";
                    rdoBtn2.Text = "Pound";
                    rdoBtn3.Visible = true;
                    rdoBtn3.Text = "Ounce";
                    rdoBtn4.Visible = true;
                    rdoBtn4.Text = "Gram";
                    rdoBtn5.Text = "Pound";
                    rdoBtn6.Text = "Kilogram";
                    rdoBtn7.Visible = true;
                    rdoBtn7.Text = "Gram";
                    rdoBtn8.Visible = true;
                    rdoBtn8.Text = "Ounce";
                    break;
                case "Temperature":
                    rdoBtn1.Text = "Celsius";
                    rdoBtn2.Text = "Fahrenheit";
                    rdoBtn3.Visible = false;
                    rdoBtn4.Visible = false;
                    rdoBtn5.Text = "Fahrenheit";
                    rdoBtn6.Text = "Celsius";
                    rdoBtn7.Visible = false;
                    rdoBtn8.Visible = false;
                    break;
            }
        }

        private void btnConvertRight_Click(object sender, EventArgs e)
        {
            RightTextBoxValueChecker();
            if (cboBoxUnitPicker.Text == "Length")
            {
                if (rdoBtn1.Checked)
                {
                    if (rdoBtn5.Checked)
                    {
                        textBoxUnit2.Text = Convert.ToString(value1 * 3.28084);
                        lblFormula.Text = "For an approximate result,\nmultiply the length value \nby 3.281";
                    }
                    else if (rdoBtn6.Checked)
                    {
                        MessageBox.Show("Cannot convert to the same unit type");
                    }
                    else if (rdoBtn7.Checked)
                    {
                        textBoxUnit2.Text = Convert.ToString((value1 * 0.000621371));
                        lblFormula.Text = "For an approximate result,\ndivide the length value \nby 1609";
                    }
                    else if (rdoBtn8.Checked)
                    {
                        textBoxUnit2.Text = Convert.ToString(value1 * 0.001);
                        lblFormula.Text = "divide the length \nvalue by 1000";
                    }
                }
                else if (rdoBtn2.Checked)
                {
                    if (rdoBtn5.Checked)
                    {
                        MessageBox.Show("Cannot convert to the same unit type");
                    }
                    else if (rdoBtn6.Checked)
                    {
                        textBoxUnit2.Text = Convert.ToString(value1 / 3.281);
                        lblFormula.Text = "For an approximate result,\ndivide the length value \nby 3.281";
                    }
                    else if (rdoBtn7.Checked)
                    {
                        textBoxUnit2.Text = Convert.ToString(value1 / 5280);
                        lblFormula.Text = "For an approximate result,\ndivide the length value \nby 5280";
                    }
                    else if (rdoBtn8.Checked)
                    {
                        textBoxUnit2.Text = Convert.ToString(value1 / 3281);
                        lblFormula.Text = "For an approximate result,\ndivide the length value \nby 3281";
                    }
                }
                else if (rdoBtn3.Checked)
                {
                    if (rdoBtn5.Checked)
                    {
                        textBoxUnit2.Text = Convert.ToString(value1 * 3280.84);
                        lblFormula.Text = "For an approximate result, \nmultiply the length \nvalue by 3281";
                    }
                    else if (rdoBtn6.Checked)
                    {
                        textBoxUnit2.Text = Convert.ToString(value1 * 1000);
                        lblFormula.Text = "multiply the length \nvalue by 1000";
                    }
                    else if (rdoBtn7.Checked)
                    {
                        textBoxUnit2.Text = Convert.ToString(value1 / 1.609);
                        lblFormula.Text = "For an approximate result, \ndivide the length \nvalue by 1.609";
                    }
                    else if (rdoBtn8.Checked)
                    {
                        MessageBox.Show("Cannot convert to the same unit type");
                    }
                }
                else if (rdoBtn4.Checked)
                {
                    if (rdoBtn5.Checked)
                    {
                        textBoxUnit2.Text = Convert.ToString(value1 * 5280);
                        lblFormula.Text = "multiply the length \nvalue by 5280";
                    }
                    else if (rdoBtn6.Checked)
                    {
                        textBoxUnit2.Text = Convert.ToString(value1 * 1609.34);
                        lblFormula.Text = "For an approximate result, \nmultiply the length \nvalue by 1609";
                    }
                    else if (rdoBtn7.Checked)
                    {
                        MessageBox.Show("Cannot convert to the same unit type");
                    }
                    else if (rdoBtn8.Checked)
                    {
                        textBoxUnit2.Text = Convert.ToString(value1 * 1.60934);
                        lblFormula.Text = "For an approximate result, \nmultiply the length \nvalue by 1.609";
                    }
                }
            }
            else if (cboBoxUnitPicker.Text == "Mass")
            {
                if (rdoBtn1.Checked)
                {
                    if (rdoBtn5.Checked)
                    {
                        textBoxUnit2.Text = Convert.ToString(value1 * 2.20462);
                        lblFormula.Text = "For an approximate result, \nmultiply the mass \nvalue by 2.205";
                    }
                    else if (rdoBtn6.Checked)
                    {
                        MessageBox.Show("Cannot convert to the same unit type");
                    }
                    else if (rdoBtn7.Checked)
                    {
                        textBoxUnit2.Text = Convert.ToString(value1 * 1000);
                        lblFormula.Text = "multiply the mass \nvalue by 1000";
                    }
                    else if (rdoBtn8.Checked)
                    {
                        textBoxUnit2.Text = Convert.ToString(value1 * 35.274);
                        lblFormula.Text = "multiply the mass \nvalue by 35.274";
                    }
                }
                else if (rdoBtn2.Checked)
                {
                    if (rdoBtn5.Checked)
                    {
                        MessageBox.Show("Cannot convert to the same unit type");
                    }
                    else if (rdoBtn6.Checked)
                    {
                        textBoxUnit2.Text = Convert.ToString(value1 / 2.205);
                        lblFormula.Text = "For an approximate result, \ndivide the mass \nvalue by 2.205";
                    }
                    else if (rdoBtn7.Checked)
                    {
                        textBoxUnit2.Text = Convert.ToString(value1 * 453.592);
                        lblFormula.Text = "multiply the mass \nvalue by 453.592";
                    }
                    else if (rdoBtn8.Checked)
                    {
                        textBoxUnit2.Text = Convert.ToString(value1 * 16);
                        lblFormula.Text = "multiply the mass \nvalue by 16";
                    }
                }
                else if (rdoBtn3.Checked)
                {
                    if (rdoBtn5.Checked)
                    {
                        textBoxUnit2.Text = Convert.ToString(value1 / 16);
                        lblFormula.Text = "divide the mass \nvalue by 16";
                    }
                    else if (rdoBtn6.Checked)
                    {
                        textBoxUnit2.Text = Convert.ToString(value1 / 35.274);
                        lblFormula.Text = "divide the mass \nvalue by 35.274";
                    }
                    else if (rdoBtn7.Checked)
                    {
                        textBoxUnit2.Text = Convert.ToString(value1 * 28.3495);
                        lblFormula.Text = "For an approximate amount, \nmultiply the mass \nvalue by 28.35";
                    }
                    else if (rdoBtn8.Checked)
                    {
                        MessageBox.Show("Cannot convert to the same unit type");
                    }
                }
                else if (rdoBtn4.Checked)
                {
                    if (rdoBtn5.Checked)
                    {
                        textBoxUnit2.Text = Convert.ToString(value1 / 453.6);
                        lblFormula.Text = "For an approximate amount, \ndivide the mass \nvalue by 453.6";
                    }
                    else if (rdoBtn6.Checked)
                    {
                        textBoxUnit2.Text = Convert.ToString(value1 / 1000);
                        lblFormula.Text = "divide the mass \nvalue by 1000";
                    }
                    else if (rdoBtn7.Checked)
                    {
                        MessageBox.Show("Cannot convert to the same unit type");
                    }
                    else if (rdoBtn8.Checked)
                    {
                        textBoxUnit2.Text = Convert.ToString(value1 / 28.35);
                        lblFormula.Text = "For an approximate amount, \ndivide the mass \nvalue by 28.35";
                    }
                }
            }
            else if (cboBoxUnitPicker.Text == "Temperature")
            {
                if (rdoBtn1.Checked)
                {
                    if (rdoBtn5.Checked)
                    {
                        textBoxUnit2.Text = Convert.ToString((value1 * 9 / 5) + 32);
                        lblFormula.Text = $"({value1}C * 9/5) + 32 = {textBoxUnit2.Text}F";
                    }
                    else if (rdoBtn6.Checked)
                    {
                        MessageBox.Show("Cannot convert to the same unit type");
                    }
                }
                else if (rdoBtn2.Checked)
                {
                    if (rdoBtn5.Checked)
                    {
                        MessageBox.Show("Cannot convert to the same unit type");
                    }
                    else if (rdoBtn6.Checked)
                    {
                        textBoxUnit2.Text = Convert.ToString((value1 - 32) * 5 / 9);
                        lblFormula.Text = $"({value1}F - 32) * 5/9 = {textBoxUnit2.Text}C";
                    }
                }
            }
        }

        private void btnConvertLeft_Click(object sender, EventArgs e)
        {
            LeftTextBoxValueChecker();
            if (cboBoxUnitPicker.Text == "Length")
            {
                if (rdoBtn5.Checked)
                {
                    if (rdoBtn1.Checked)
                    {
                        textBoxUnit1.Text = Convert.ToString(value2 / 3.281);
                        lblFormula.Text = "For an approximate result,\ndivide the length value \nby 3.281";
                    }
                    else if (rdoBtn2.Checked)
                    {
                        MessageBox.Show("Cannot convert to the same unit type");
                    }
                    else if (rdoBtn3.Checked)
                    {
                        textBoxUnit1.Text = Convert.ToString(value2 / 3281);
                        lblFormula.Text = "For an approximate result,\ndivide the length value \nby 3281";
                    }
                    else if (rdoBtn4.Checked)
                    {
                        textBoxUnit1.Text = Convert.ToString(value2 / 5280);
                        lblFormula.Text = " divide the length value \nby 5280";
                    }
                }
                else if (rdoBtn6.Checked)
                {
                    if (rdoBtn1.Checked)
                    {
                        MessageBox.Show("Cannot convert to the same unit type");
                    }
                    else if (rdoBtn2.Checked)
                    {
                        textBoxUnit1.Text = Convert.ToString(value2 * 3.281);
                        lblFormula.Text = "For an approximate result,\nmultiply the length value \nby 3.281";
                    }
                    else if (rdoBtn3.Checked)
                    {
                        textBoxUnit1.Text = Convert.ToString(value2 / 1000);
                        lblFormula.Text = "divide the length value \nby 1000";
                    }
                    else if (rdoBtn4.Checked)
                    {
                        textBoxUnit1.Text = Convert.ToString(value2 / 1609);
                        lblFormula.Text = "For an approximate result,\ndivide the length value \nby 1609";
                    }
                }
                else if (rdoBtn7.Checked)
                {
                    if (rdoBtn1.Checked)
                    {
                        textBoxUnit1.Text = Convert.ToString(value2 * 1609.34);
                        lblFormula.Text = "For an approximate result,\nmultiply the length value \nby 1609";
                    }
                    else if (rdoBtn2.Checked)
                    {
                        textBoxUnit1.Text = Convert.ToString(value2 * 5280);
                        lblFormula.Text = "multiply the length value \nby 5280";
                    }
                    else if (rdoBtn3.Checked)
                    {
                        textBoxUnit1.Text = Convert.ToString(value2 * 1.60934);
                        lblFormula.Text = "For an approximate result,\nmultiply the length value \nby 1.609";
                    }
                    else if (rdoBtn4.Checked)
                    {
                        MessageBox.Show("Cannot convert to the same unit type");
                    }
                }
                else if (rdoBtn8.Checked)
                {
                    if (rdoBtn1.Checked)
                    {
                        textBoxUnit1.Text = Convert.ToString(value2 * 1000);
                        lblFormula.Text = "multiply the length value \nby 1000";
                    }
                    else if (rdoBtn2.Checked)
                    {
                        textBoxUnit1.Text = Convert.ToString(value2 * 3280.84);
                        lblFormula.Text = "For an approximate result,\nmultiply the length value \nby 3281";
                    }
                    else if (rdoBtn3.Checked)
                    {
                        MessageBox.Show("Cannot convert to the same unit type");
                    }
                    else if (rdoBtn4.Checked)
                    {
                        textBoxUnit1.Text = Convert.ToString(value2 / 1.60934);
                        lblFormula.Text = "For an approximate result,\ndivide the length value \nby 1.609";
                    }
                }
            }
            else if (cboBoxUnitPicker.Text == "Mass")
            {
                if (rdoBtn5.Checked)
                {
                    if (rdoBtn1.Checked)
                    {
                        textBoxUnit1.Text = Convert.ToString(value2 / 2.205);
                        lblFormula.Text = "For an approximate result,\ndivide the mass value \nby 2.205";
                    }
                    else if (rdoBtn2.Checked)
                    {
                        MessageBox.Show("Cannot convert to the same unit type");
                    }
                    else if (rdoBtn3.Checked)
                    {
                        textBoxUnit1.Text = Convert.ToString(value2 * 16);
                        lblFormula.Text = "multiply the mass value \nby 16";
                    }
                    else if (rdoBtn4.Checked)
                    {
                        textBoxUnit1.Text = Convert.ToString(value2 * 453.592);
                        lblFormula.Text = "For an approximate result, \nmultiply the mass value \nby 453.592";
                    }
                }
                else if (rdoBtn6.Checked)
                {
                    if (rdoBtn1.Checked)
                    {
                        MessageBox.Show("Cannot convert to the same unit type");
                    }
                    else if (rdoBtn2.Checked)
                    {
                        textBoxUnit1.Text = Convert.ToString(value2 * 2.20462);
                        lblFormula.Text = "For an approximate result, \nmultiply the mass value \nby 2.205";
                    }
                    else if (rdoBtn3.Checked)
                    {
                        textBoxUnit1.Text = Convert.ToString(value2 * 35.274);
                        lblFormula.Text = "multiply the mass value \nby 35.274";
                    }
                    else if (rdoBtn4.Checked)
                    {
                        textBoxUnit1.Text = Convert.ToString(value2 * 1000);
                        lblFormula.Text = "multiply the mass value \nby 1000";
                    }
                }
                else if (rdoBtn7.Checked)
                {
                    if (rdoBtn1.Checked)
                    {
                        textBoxUnit1.Text = Convert.ToString(value2 / 1000);
                        lblFormula.Text = "divide the mass value \nby 1000";
                    }
                    else if (rdoBtn2.Checked)
                    {
                        textBoxUnit1.Text = Convert.ToString(value2 / 453.592);
                        lblFormula.Text = "For an approximate result, \ndivide the mass value \nby 453.6";
                    }
                    else if (rdoBtn3.Checked)
                    {
                        textBoxUnit1.Text = Convert.ToString(value2 / 28.35);
                        lblFormula.Text = "For an approximate result, \ndivide the mass value \nby 28.35";
                    }
                    else if (rdoBtn4.Checked)
                    {
                        MessageBox.Show("Cannot convert to the same unit type");
                    }
                }
                else if (rdoBtn8.Checked)
                {
                    if (rdoBtn1.Checked)
                    {
                        textBoxUnit1.Text = Convert.ToString(value2 / 35.274);
                        lblFormula.Text = "divide the mass value \nby 35.274";
                    }
                    else if (rdoBtn2.Checked)
                    {
                        textBoxUnit1.Text = Convert.ToString(value2 / 16);
                        lblFormula.Text = "divide the mass value \nby 16";
                    }
                    else if (rdoBtn3.Checked)
                    {
                        MessageBox.Show("Cannot convert to the same unit type");
                    }
                    else if (rdoBtn4.Checked)
                    {
                        textBoxUnit1.Text = Convert.ToString(value2 * 28.3495);
                        lblFormula.Text = "For an approximate result, \nmultiply the mass value \nby 28.35";
                    }
                }

            }
            else if (cboBoxUnitPicker.Text == "Temperature")
            {
                if (rdoBtn5.Checked)
                {
                    if (rdoBtn1.Checked)
                    {
                        textBoxUnit1.Text = Convert.ToString((value2 - 32) * 5 / 9);
                        lblFormula.Text = $"({value2}F - 32) * 5/9 = {textBoxUnit1.Text}C";
                    }
                    else if (rdoBtn2.Checked)
                    {
                        MessageBox.Show("Cannot convert to the same unit type");
                    }
                }
                else if (rdoBtn6.Checked)
                {
                    if (rdoBtn1.Checked)
                    {
                        MessageBox.Show("Cannot convert to the same unit type");
                    }
                    else if (rdoBtn2.Checked)
                    {
                        textBoxUnit1.Text = Convert.ToString((value2 * 9 / 5) + 32);
                        lblFormula.Text = $"({value2}C * 9/5) + 32 = {textBoxUnit1.Text}F";
                    }
                }
            }
        }


        private void RightTextBoxValueChecker()
        {
            if (!double.TryParse(textBoxUnit1.Text, out value1))
            {
                MessageBox.Show("Please enter a valid number");
            }
        }

        private void LeftTextBoxValueChecker()
        {
            if (!double.TryParse(textBoxUnit2.Text, out value2))
            {
                MessageBox.Show("Please enter a valid number");
            }
        }

        private void btnInstructions_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            string instructions = "Here are the insturctions in using this simple converter. There's two text boxes with arrow buttons in between them, one pointing to the right, and the other button pointing to the left. There's also a set of radio buttons under each text box, that corresponds to the unit of measurement in the dropdown list. You will pick from either the left set of radio buttons or the right set of radio and use the arrow buttons to perform the conversion. Please enter a number in one of the text boxes, choose your base unit under the text box with the number, then choose the unit you want to convert to on the opposite side. Please keep in mind, you will not be able to convert to the same unit type in the opposite set of radio buttons.";
            MessageBox.Show(instructions, "Instructions", buttons);
        }
    }
}
