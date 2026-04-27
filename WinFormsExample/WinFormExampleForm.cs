using System.Data.Common;

namespace WinFormsExample
{
    public partial class WinFormExampleForm : Form
    {
        public WinFormExampleForm()
        {
            InitializeComponent();
            CityRadioButton.CheckedChanged += CityRadioButton_CheckedChanged1;
            FirstNameRadioButton.CheckedChanged += CityRadioButton_CheckedChanged1;
            LastNameRadioButton.CheckedChanged += CityRadioButton_CheckedChanged1;
            FilterComboBox.SelectedIndexChanged += FilterComboBox_SelectedIndexChanged;

            SetDefaults();
        }

        

        string[,] customerData = new string[0,0]; // persistant customer data 

        private void SetDefaults()
        {
            NameTextBox.Text = "";
            AgeTextBox.Text = "";
            PhoneTextBox.Text = "";
            CityTextBox.Text = "";
            //Displaylabel.Text = "";

            CityRadioButton.Checked = true;

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

        private int CountOfLinesIn(string filePath)
        {
            int count = 0;
            using (StreamReader testFile = new StreamReader(filePath))
            {

                do
                {
                    testFile.ReadLine();
                    count++;
                } while (!testFile.EndOfStream);
            }
            return count;
        }

        private void FileToArray(string filePath)
        {
            string[,] _customerData = new string[4, CountOfLinesIn(filePath)];
            string[] temp;
            int counter = 0;


            using (StreamReader testFile = new StreamReader(filePath))
            {

                do
                {

                    temp = testFile.ReadLine().Split(",");

                    if (temp.Length == 5)
                    {
                        temp[0] = temp[0].Replace("\"$$", "");
                        temp[3] = temp[3].Replace("\"", "");

                        _customerData[0, counter] = temp[0];
                        _customerData[1, counter] = temp[1];
                        _customerData[2, counter] = temp[2];
                        _customerData[3, counter] = temp[3];
                    }

                    counter++;

                } while (!testFile.EndOfStream);
            }

            this.customerData = _customerData;

        }

        private void DisplayData()
        {
            string[,] data = this.customerData;
            string formattedRow = "";
            int filterColumn = 2;

            DisplayListBox.Items.Clear();

            switch (true)
            {
                case bool when CityRadioButton.Checked == true:
                    filterColumn = 2;
                    break;
                case bool when FirstNameRadioButton.Checked == true:
                    filterColumn = 0;
                    break;
                case bool when LastNameRadioButton.Checked == true:
                    filterColumn = 1;
                    break;
            }

            for (int row = 0; row < data.GetLength(1); row++)
            {
                for (int column = 0; column < data.GetLength(0); column++)
                {
                    if (data[column, row] != null && (data[filterColumn, row] == FilterComboBox.SelectedItem.ToString() ||  FilterComboBox.SelectedIndex == 0))
                    {
                        formattedRow += data[column, row].PadRight(12);

                    }
                }
                if (formattedRow != "")
                {


                    DisplayListBox.Items.Add(formattedRow);
                }
                formattedRow = "";
            }
        }

        void LoadFilterComboBox()
        {
            FilterComboBox.Items.Clear();

            int column = 2;

            switch(true)
            {
                case bool when CityRadioButton.Checked == true:
                    column = 2;
                    break;
                case bool when FirstNameRadioButton.Checked == true:
                    column = 0;
                    break;
                case bool when LastNameRadioButton.Checked == true:
                    column = 1;
                    break;


            }
            for (int row = 0; (row < this.customerData.GetUpperBound(1)); row++)
            {
                if (this.customerData[column, row] != null && FilterComboBox.Items.Contains(this.customerData[column, row]) != true)
                {
                    FilterComboBox.Items.Add(this.customerData[column, row]); //add city

                }
            }

            FilterComboBox.Items.Add("~Select~");
            FilterComboBox.Sorted = true;
            FilterComboBox.SelectedIndex = 0;

        }


        //Event handelers below------------------------------------------------
        private void FilterComboBox_SelectedIndexChanged(object? sender, EventArgs e)
        {
            DisplayData();
        }

        private void CityRadioButton_CheckedChanged1(object? sender, EventArgs e)
        {
            LoadFilterComboBox();
        }

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
                //Displaylabel.Text = Reverse(UpperCase(NameTextBox.Text +
                //             "\n" + AgeTextBox.Text +
                //             "\n" + PhoneTextBox.Text +
                //             "\n" + CityTextBox.Text));
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

        private void UpperContextMenuItem_Click(object sender, EventArgs e)
        {
            UpperCaseRadioButton.Checked = true;
        }

        private void LowerContextMenuItem_Click(object sender, EventArgs e)
        {
            LowerCaseRadioButton.Checked = true;
        }

        private void ReverseContextMenuItem_Click(object sender, EventArgs e)
        {
            ReverseRadioButton.Checked = true;
        }

        private void OpenTopMenuItem_Click(object sender, EventArgs e)
        {
            string[,] fileData;
            string filePath = "";
            MainOpenFileDialog.FileName = "Big fella";
            MainOpenFileDialog.Filter = "txt files (*.txt)|*.txt|wav files (*.wav*)|*.wav|All files (*.*)|*.*"; //"file filter name |*file extention|"

            if (MainOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = MainOpenFileDialog.FileName;
                FileToArray(filePath);
                LoadFilterComboBox();
                DisplayData();

            }
        }

        
    }
}
