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

            UpperCaseRadioButton.Checked = true;

        }

        //Event handelers below
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            this.Text = NameTextBox.Text;
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            SetDefaults();
        }
    }
}
