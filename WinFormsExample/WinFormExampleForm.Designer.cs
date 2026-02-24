namespace WinFormsExample
{
    partial class WinFormExampleForm
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
            ExitButton = new Button();
            SubmitButton = new Button();
            NameLabel = new Label();
            NameTextBox = new TextBox();
            AgeTextBox = new TextBox();
            AgeLabel = new Label();
            CityTextBox = new TextBox();
            CityLabel = new Label();
            PhoneTextBox = new TextBox();
            PhoneLabel = new Label();
            ClearButton = new Button();
            ButtonsGroupBox = new GroupBox();
            UserInfoGroupBox = new GroupBox();
            groupBox1 = new GroupBox();
            radioButton2 = new RadioButton();
            radioButton6 = new RadioButton();
            radioButton1 = new RadioButton();
            checkBox3 = new CheckBox();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox4 = new CheckBox();
            ReverseRadioButton = new RadioButton();
            UpperCaseRadioButton = new RadioButton();
            LowerCaseRadioButton = new RadioButton();
            ButtonsGroupBox.SuspendLayout();
            UserInfoGroupBox.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(219, 20);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(106, 75);
            ExitButton.TabIndex = 6;
            ExitButton.Text = "E&xit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // SubmitButton
            // 
            SubmitButton.Location = new Point(6, 20);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new Size(100, 75);
            SubmitButton.TabIndex = 4;
            SubmitButton.Text = "&Submit";
            SubmitButton.UseVisualStyleBackColor = true;
            SubmitButton.Click += SubmitButton_Click;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(14, 33);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(59, 25);
            NameLabel.TabIndex = 2;
            NameLabel.Text = "Name";
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(85, 33);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(234, 31);
            NameTextBox.TabIndex = 0;
            // 
            // AgeTextBox
            // 
            AgeTextBox.Location = new Point(79, 66);
            AgeTextBox.Name = "AgeTextBox";
            AgeTextBox.Size = new Size(234, 31);
            AgeTextBox.TabIndex = 1;
            // 
            // AgeLabel
            // 
            AgeLabel.AutoSize = true;
            AgeLabel.Location = new Point(14, 69);
            AgeLabel.Name = "AgeLabel";
            AgeLabel.Size = new Size(44, 25);
            AgeLabel.TabIndex = 4;
            AgeLabel.Text = "Age";
            // 
            // CityTextBox
            // 
            CityTextBox.Location = new Point(79, 142);
            CityTextBox.Name = "CityTextBox";
            CityTextBox.Size = new Size(234, 31);
            CityTextBox.TabIndex = 3;
            // 
            // CityLabel
            // 
            CityLabel.AutoSize = true;
            CityLabel.Location = new Point(14, 145);
            CityLabel.Name = "CityLabel";
            CityLabel.Size = new Size(42, 25);
            CityLabel.TabIndex = 8;
            CityLabel.Text = "City";
            // 
            // PhoneTextBox
            // 
            PhoneTextBox.Location = new Point(79, 106);
            PhoneTextBox.Name = "PhoneTextBox";
            PhoneTextBox.Size = new Size(234, 31);
            PhoneTextBox.TabIndex = 2;
            // 
            // PhoneLabel
            // 
            PhoneLabel.AutoSize = true;
            PhoneLabel.Location = new Point(14, 109);
            PhoneLabel.Name = "PhoneLabel";
            PhoneLabel.Size = new Size(62, 25);
            PhoneLabel.TabIndex = 6;
            PhoneLabel.Text = "Phone";
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(112, 20);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(101, 75);
            ClearButton.TabIndex = 5;
            ClearButton.Text = "&Clear";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // ButtonsGroupBox
            // 
            ButtonsGroupBox.Controls.Add(SubmitButton);
            ButtonsGroupBox.Controls.Add(ClearButton);
            ButtonsGroupBox.Controls.Add(ExitButton);
            ButtonsGroupBox.Location = new Point(455, 335);
            ButtonsGroupBox.Name = "ButtonsGroupBox";
            ButtonsGroupBox.Size = new Size(333, 103);
            ButtonsGroupBox.TabIndex = 2;
            ButtonsGroupBox.TabStop = false;
            // 
            // UserInfoGroupBox
            // 
            UserInfoGroupBox.Controls.Add(NameTextBox);
            UserInfoGroupBox.Controls.Add(NameLabel);
            UserInfoGroupBox.Controls.Add(CityTextBox);
            UserInfoGroupBox.Controls.Add(AgeLabel);
            UserInfoGroupBox.Controls.Add(CityLabel);
            UserInfoGroupBox.Controls.Add(AgeTextBox);
            UserInfoGroupBox.Controls.Add(PhoneTextBox);
            UserInfoGroupBox.Controls.Add(PhoneLabel);
            UserInfoGroupBox.Location = new Point(12, 12);
            UserInfoGroupBox.Name = "UserInfoGroupBox";
            UserInfoGroupBox.Size = new Size(319, 185);
            UserInfoGroupBox.TabIndex = 0;
            UserInfoGroupBox.TabStop = false;
            UserInfoGroupBox.Text = "User Info";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton6);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(checkBox3);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Location = new Point(337, 23);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(443, 315);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(25, 156);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(141, 29);
            radioButton2.TabIndex = 3;
            radioButton2.TabStop = true;
            radioButton2.Text = "radioButton2";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            radioButton6.AutoSize = true;
            radioButton6.Location = new Point(25, 191);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(141, 29);
            radioButton6.TabIndex = 4;
            radioButton6.TabStop = true;
            radioButton6.Text = "radioButton6";
            radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(25, 121);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(141, 29);
            radioButton1.TabIndex = 2;
            radioButton1.TabStop = true;
            radioButton1.Text = "radioButton1";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(25, 70);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(121, 29);
            checkBox3.TabIndex = 1;
            checkBox3.Text = "checkBox3";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(25, 35);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(121, 29);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(11, 209);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(121, 29);
            checkBox2.TabIndex = 3;
            checkBox2.Text = "checkBox2";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(11, 244);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(121, 29);
            checkBox4.TabIndex = 4;
            checkBox4.Text = "checkBox4";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // ReverseRadioButton
            // 
            ReverseRadioButton.AutoSize = true;
            ReverseRadioButton.Location = new Point(20, 369);
            ReverseRadioButton.Name = "ReverseRadioButton";
            ReverseRadioButton.Size = new Size(97, 29);
            ReverseRadioButton.TabIndex = 15;
            ReverseRadioButton.TabStop = true;
            ReverseRadioButton.Text = "Reverse";
            ReverseRadioButton.UseVisualStyleBackColor = true;
            // 
            // UpperCaseRadioButton
            // 
            UpperCaseRadioButton.AutoSize = true;
            UpperCaseRadioButton.Location = new Point(20, 299);
            UpperCaseRadioButton.Name = "UpperCaseRadioButton";
            UpperCaseRadioButton.Size = new Size(86, 29);
            UpperCaseRadioButton.TabIndex = 5;
            UpperCaseRadioButton.TabStop = true;
            UpperCaseRadioButton.Text = "Upper";
            UpperCaseRadioButton.UseVisualStyleBackColor = true;
            // 
            // LowerCaseRadioButton
            // 
            LowerCaseRadioButton.AutoSize = true;
            LowerCaseRadioButton.Location = new Point(20, 334);
            LowerCaseRadioButton.Name = "LowerCaseRadioButton";
            LowerCaseRadioButton.Size = new Size(84, 29);
            LowerCaseRadioButton.TabIndex = 15;
            LowerCaseRadioButton.TabStop = true;
            LowerCaseRadioButton.Text = "Lower";
            LowerCaseRadioButton.UseVisualStyleBackColor = true;
            // 
            // WinFormExampleForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ReverseRadioButton);
            Controls.Add(LowerCaseRadioButton);
            Controls.Add(UpperCaseRadioButton);
            Controls.Add(checkBox2);
            Controls.Add(checkBox4);
            Controls.Add(groupBox1);
            Controls.Add(UserInfoGroupBox);
            Controls.Add(ButtonsGroupBox);
            Name = "WinFormExampleForm";
            Text = "Form1";
            ButtonsGroupBox.ResumeLayout(false);
            UserInfoGroupBox.ResumeLayout(false);
            UserInfoGroupBox.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ExitButton;
        private Button SubmitButton;
        private Label NameLabel;
        private TextBox NameTextBox;
        private TextBox AgeTextBox;
        private Label AgeLabel;
        private TextBox CityTextBox;
        private Label CityLabel;
        private TextBox PhoneTextBox;
        private Label PhoneLabel;
        private Button ClearButton;
        private GroupBox ButtonsGroupBox;
        private GroupBox UserInfoGroupBox;
        private GroupBox groupBox1;
        private CheckBox checkBox3;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox4;
        private RadioButton radioButton2;
        private RadioButton radioButton6;
        private RadioButton radioButton1;
        private RadioButton ReverseRadioButton;
        private RadioButton UpperCaseRadioButton;
        private RadioButton LowerCaseRadioButton;
    }
}
