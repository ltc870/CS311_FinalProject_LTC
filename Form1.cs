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
                        lblFormula.Text = "divide the length value by 1000";
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
                    }
                    else if (rdoBtn7.Checked)
                    {
                        textBoxUnit2.Text = Convert.ToString((value1 / 5280));
                    }
                    else if (rdoBtn8.Checked)
                    {
                        textBoxUnit2.Text = Convert.ToString(value1 / 3281);
                    }
                }
                else if (rdoBtn3.Checked)
                {
                    if (rdoBtn5.Checked)
                    {
                        textBoxUnit2.Text = Convert.ToString(value1 * 3280.84);
                    }
                    else if (rdoBtn6.Checked)
                    {
                        textBoxUnit2.Text = Convert.ToString(value1 * 1000);
                    }
                    else if (rdoBtn7.Checked)
                    {
                        textBoxUnit2.Text = Convert.ToString(value1 / 0.621371);
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
                    }
                    else if (rdoBtn6.Checked)
                    {
                        textBoxUnit2.Text = Convert.ToString(value1 * 1609.34);
                    }
                    else if (rdoBtn7.Checked)
                    {
                        MessageBox.Show("Cannot convert to the same unit type");
                    }
                    else if (rdoBtn8.Checked)
                    {
                        textBoxUnit2.Text = Convert.ToString(value1 * 1.60934);
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
                    }
                    else if (rdoBtn6.Checked)
                    {
                        MessageBox.Show("Cannot convert to the same unit type");
                    }
                    else if (rdoBtn7.Checked)
                    {
                        textBoxUnit2.Text = Convert.ToString(value1 * 1000);
                    }
                    else if (rdoBtn8.Checked)
                    {
                        textBoxUnit2.Text = Convert.ToString(value1 * 35.274);
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
                    }
                    else if (rdoBtn7.Checked)
                    {
                        textBoxUnit2.Text = Convert.ToString(value1 * 453.592);
                    }
                    else if (rdoBtn8.Checked)
                    {
                        textBoxUnit2.Text = Convert.ToString(value1 * 16);
                    }
                }
                else if (rdoBtn3.Checked)
                {
                    if (rdoBtn5.Checked)
                    {
                        textBoxUnit2.Text = Convert.ToString(value1 / 16);
                    }
                    else if (rdoBtn6.Checked)
                    {
                        textBoxUnit2.Text = Convert.ToString(value1 / 35.274);
                    }
                    else if (rdoBtn7.Checked)
                    {
                        textBoxUnit2.Text = Convert.ToString(value1 * 28.3495);
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
                    }
                    else if (rdoBtn6.Checked)
                    {
                        textBoxUnit2.Text = Convert.ToString(value1 / 1000);
                    }
                    else if (rdoBtn7.Checked)
                    {
                        MessageBox.Show("Cannot convert to the same unit type");
                    }
                    else if (rdoBtn8.Checked)
                    {
                        textBoxUnit2.Text = Convert.ToString(value1 / 28.35);
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

    }
}
