namespace WinFormsExample
{
    public partial class WinFormExampleForm : Form
    {
        public WinFormExampleForm()
        {
            InitializeComponent();
            SetDefaults();
        }

        private void SetDefaults()
        {
            NameTextBox.Text = "";
            AgeTextBox.Text = "";
            PhoneTextBox.Text = "";
            CityTextBox.Text = "";
            Displaylabel.Text = "";

            UpperCaseRadioButton.Checked = true;
            SubmitButton.Enabled = false;
            SubmitTopMenuItem.Enabled = false;

        }

        private bool ValidateFields()
        {
            string message = "";
            bool valid = true;

            if (CityTextBox.Text == "")
            {
                message = "City is required\n" + message;
                CityTextBox.Focus();

            }
            if (PhoneTextBox.Text == "")
            {
                message = "Phone number is required\n" + message;
                PhoneTextBox.Focus();

            }
            if (AgeTextBox.Text == "")
            {
                message = "Age is required\n" + message;
                AgeTextBox.Focus();

            }
            if (NameTextBox.Text == "")
            {
                message = "Name is required\n" + message;
                NameTextBox.Focus();
            }
            if (message != "")
            {
                MessageBox.Show(message);
                valid = false;
            }
            return valid;
        }

        private string UpperCase(string toUpper)
        {
            if (UpperCaseRadioButton.Checked)
            {
                return toUpper.ToUpper();
            }
            else
            {
                return toUpper;
            }
        }

        private string Reverse(string reverseThis)
        {
            if (ReverseRadioButton.Checked)
            {
                return new string(reverseThis.Reverse().ToArray());
            }
            else
            {
                return reverseThis;
            }
        }
        //Event handelers below
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (ValidateFields())
            {
                //this.Text = NameTextBox.Text;
                //UpperCase();
                //Reverse();
                Displaylabel.Text = Reverse(UpperCase(NameTextBox.Text +
                             "\n" + AgeTextBox.Text +
                             "\n" + PhoneTextBox.Text +
                             "\n" + CityTextBox.Text));
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            SetDefaults();
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (NameTextBox.Text != "")
            {
                NameTextBox.BackColor = Color.LightYellow;
                SubmitButton.Enabled = true;
                SubmitTopMenuItem.Enabled = true;
            }
            else
            {
                NameTextBox.BackColor = Color.White;
                SubmitButton.Enabled = false;
                SubmitTopMenuItem.Enabled = false;

            }
        }

        private void AgeTextBox_TextChanged(object sender, EventArgs e)
        {
            if (AgeTextBox.Text != "")
            {
                AgeTextBox.BackColor = Color.LightYellow;
                SubmitButton.Enabled = true;
                SubmitTopMenuItem.Enabled = true;

            }
            else
            {
                AgeTextBox.BackColor = Color.White;
                SubmitButton.Enabled = false;
                SubmitTopMenuItem.Enabled = false;


            }
        }

        private void AboutTopMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No help avalible");
        }
    }
}
