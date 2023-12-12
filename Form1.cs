namespace CS311_FinalProject_LTC
{
    public enum UnitType
    {
        Length,
        Mass,
        Temperature
    }
    public partial class formUnitConverter : Form
    {
        // class members
        private Dictionary<UnitType, Dictionary<string, double>> conversionFactors;
        private double value1;
        private double value2;


        public formUnitConverter()
        {
            InitializeComponent();
            InitializeConversionFactors();
        }

        private void InitializeConversionFactors()
        {
            conversionFactors = new Dictionary<UnitType, Dictionary<string, double>>
            {
                {
                    UnitType.Length, new Dictionary<string, double>
                    {
                        {"Meter", 1},
                        {"Feet", 3.28084},
                        {"Kilometer", 0.001},
                        {"Mile", 0.000621371 }
                    }
                },
                {
                    UnitType.Mass, new Dictionary<string, double>
                    {
                        {"Kilogram", 1},
                        {"Pound", 2.20462},
                        {"Ounce", 35.274},
                        {"Gram", 1000}
                    }
                },
                {
                    UnitType.Temperature, new Dictionary<string, double>
                    {
                        {"Celsius", 1},
                        {"Fahrenheit", 33.8}
                    }
                }

            };
        }

        private double ConvertUnits(double value, string fromUnit, string toUnit, UnitType unitType)
        {
            double fromFactor = conversionFactors[unitType][fromUnit];
            double toFactor = conversionFactors[unitType][toUnit];

            if (fromUnit == "Fahrenheit" && toUnit == "Celsius")
            {
                return (value - 32) * 5 / 9;
            }

            if (fromUnit == "Celsius" && toUnit == "Fahrenheit")
            {
                return (value * 9 / 5) + 32;
            }

            return value * (toFactor / fromFactor);
        }

        private void btnConvertRight_Click(object sender, EventArgs e)
        {
            RightTextBoxValueChecker();
            if (Enum.TryParse(cboBoxUnitPicker.Text, out UnitType unitType))
            {
                string fromUnit = GetSelectedRadioButtonText(grpBoxConverGrp1);
                string toUnit = GetSelectedRadioButtonText(grpBoxConverGrp2);

                if (fromUnit != null && toUnit != null)
                {
                    double result = ConvertUnits(value1, fromUnit, toUnit, unitType);
                    textBoxUnit2.Text = result.ToString();
                    lblFormula.Text = $"Conversion: {value1} {fromUnit} to {toUnit}";
                }
                else
                {
                    MessageBox.Show("Please select units for conversion");
                }
            }
        }

        private void btnConvertLeft_Click(object sender, EventArgs e)
        {
            LeftTextBoxValueChecker();
            if (Enum.TryParse(cboBoxUnitPicker.Text, out UnitType unitType))
            {
                string fromUnit = GetSelectedRadioButtonText(grpBoxConverGrp2);
                string toUnit = GetSelectedRadioButtonText(grpBoxConverGrp1);

                if (fromUnit != null && toUnit != null)
                {
                    double result = ConvertUnits(value2, fromUnit, toUnit, unitType);
                    textBoxUnit1.Text = result.ToString();
                    lblFormula.Text = $"Conversion: {value2} {fromUnit} to {toUnit}";
                }
                else
                {
                    MessageBox.Show("Please select units for conversion");
                }
            }
        }

        private string GetSelectedRadioButtonText(GroupBox groupBox)
        {
            var checkedButton = groupBox.Controls.OfType<RadioButton>().FirstOrDefault(radio => radio.Checked);
            return checkedButton?.Text;
        }

        private void cboBoxUnitPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            String data = cboBoxUnitPicker.GetItemText(cboBoxUnitPicker.SelectedItem);

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
