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
            components = new System.ComponentModel.Container();
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
            ReverseRadioButton = new RadioButton();
            UpperCaseRadioButton = new RadioButton();
            LowerCaseRadioButton = new RadioButton();
            MainToolTip = new ToolTip(components);
            FormatOptionsGroupBox = new GroupBox();
            FormatContextMenuStrip = new ContextMenuStrip(components);
            UpperContextMenuItem = new ToolStripMenuItem();
            LowerContextMenuItem = new ToolStripMenuItem();
            ReverseContextMenuItem = new ToolStripMenuItem();
            TopMenuStrip = new MenuStrip();
            fileTopMenuItem = new ToolStripMenuItem();
            OpenTopMenuItem = new ToolStripMenuItem();
            SubmitTopMenuItem = new ToolStripMenuItem();
            ClearTopMenuItem = new ToolStripMenuItem();
            ExitTopMenuItem = new ToolStripMenuItem();
            helpTopMenuItem = new ToolStripMenuItem();
            AboutTopMenuItem = new ToolStripMenuItem();
            MainOpenFileDialog = new OpenFileDialog();
            DisplayListBox = new ListBox();
            FilterComboBox = new ComboBox();
            FilterOptionsGroupBox = new GroupBox();
            CityRadioButton = new RadioButton();
            LastNameRadioButton = new RadioButton();
            FirstNameRadioButton = new RadioButton();
            ButtonsGroupBox.SuspendLayout();
            UserInfoGroupBox.SuspendLayout();
            FormatOptionsGroupBox.SuspendLayout();
            FormatContextMenuStrip.SuspendLayout();
            TopMenuStrip.SuspendLayout();
            FilterOptionsGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(219, 20);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(106, 75);
            ExitButton.TabIndex = 6;
            ExitButton.Text = "E&xit";
            MainToolTip.SetToolTip(ExitButton, "Dont leave please");
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
            NameTextBox.Location = new Point(79, 33);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(234, 31);
            NameTextBox.TabIndex = 0;
            NameTextBox.TextChanged += NameTextBox_TextChanged;
            // 
            // AgeTextBox
            // 
            AgeTextBox.Location = new Point(79, 66);
            AgeTextBox.Name = "AgeTextBox";
            AgeTextBox.Size = new Size(234, 31);
            AgeTextBox.TabIndex = 1;
            AgeTextBox.TextChanged += AgeTextBox_TextChanged;
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
            UserInfoGroupBox.Location = new Point(12, 36);
            UserInfoGroupBox.Name = "UserInfoGroupBox";
            UserInfoGroupBox.Size = new Size(319, 185);
            UserInfoGroupBox.TabIndex = 0;
            UserInfoGroupBox.TabStop = false;
            UserInfoGroupBox.Text = "User Info";
            // 
            // ReverseRadioButton
            // 
            ReverseRadioButton.AutoSize = true;
            ReverseRadioButton.Location = new Point(14, 100);
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
            UpperCaseRadioButton.Location = new Point(14, 30);
            UpperCaseRadioButton.Name = "UpperCaseRadioButton";
            UpperCaseRadioButton.Size = new Size(86, 29);
            UpperCaseRadioButton.TabIndex = 5;
            UpperCaseRadioButton.TabStop = true;
            UpperCaseRadioButton.Text = "Upper";
            MainToolTip.SetToolTip(UpperCaseRadioButton, "Youre dumb if you dont know what this does");
            UpperCaseRadioButton.UseVisualStyleBackColor = true;
            // 
            // LowerCaseRadioButton
            // 
            LowerCaseRadioButton.AutoSize = true;
            LowerCaseRadioButton.Location = new Point(14, 65);
            LowerCaseRadioButton.Name = "LowerCaseRadioButton";
            LowerCaseRadioButton.Size = new Size(84, 29);
            LowerCaseRadioButton.TabIndex = 15;
            LowerCaseRadioButton.TabStop = true;
            LowerCaseRadioButton.Text = "Lower";
            LowerCaseRadioButton.UseVisualStyleBackColor = true;
            // 
            // FormatOptionsGroupBox
            // 
            FormatOptionsGroupBox.ContextMenuStrip = FormatContextMenuStrip;
            FormatOptionsGroupBox.Controls.Add(UpperCaseRadioButton);
            FormatOptionsGroupBox.Controls.Add(LowerCaseRadioButton);
            FormatOptionsGroupBox.Controls.Add(ReverseRadioButton);
            FormatOptionsGroupBox.Location = new Point(12, 227);
            FormatOptionsGroupBox.Name = "FormatOptionsGroupBox";
            FormatOptionsGroupBox.Size = new Size(152, 203);
            FormatOptionsGroupBox.TabIndex = 18;
            FormatOptionsGroupBox.TabStop = false;
            FormatOptionsGroupBox.Text = "Format Options";
            MainToolTip.SetToolTip(FormatOptionsGroupBox, "Change info format");
            // 
            // FormatContextMenuStrip
            // 
            FormatContextMenuStrip.ImageScalingSize = new Size(24, 24);
            FormatContextMenuStrip.Items.AddRange(new ToolStripItem[] { UpperContextMenuItem, LowerContextMenuItem, ReverseContextMenuItem });
            FormatContextMenuStrip.Name = "FormatContextMenuStrip";
            FormatContextMenuStrip.Size = new Size(145, 100);
            // 
            // UpperContextMenuItem
            // 
            UpperContextMenuItem.Name = "UpperContextMenuItem";
            UpperContextMenuItem.Size = new Size(144, 32);
            UpperContextMenuItem.Text = "Upper";
            UpperContextMenuItem.Click += UpperContextMenuItem_Click;
            // 
            // LowerContextMenuItem
            // 
            LowerContextMenuItem.Name = "LowerContextMenuItem";
            LowerContextMenuItem.Size = new Size(144, 32);
            LowerContextMenuItem.Text = "Lower";
            LowerContextMenuItem.Click += LowerContextMenuItem_Click;
            // 
            // ReverseContextMenuItem
            // 
            ReverseContextMenuItem.Name = "ReverseContextMenuItem";
            ReverseContextMenuItem.Size = new Size(144, 32);
            ReverseContextMenuItem.Text = "Reverse";
            ReverseContextMenuItem.Click += ReverseContextMenuItem_Click;
            // 
            // TopMenuStrip
            // 
            TopMenuStrip.ImageScalingSize = new Size(24, 24);
            TopMenuStrip.Items.AddRange(new ToolStripItem[] { fileTopMenuItem, helpTopMenuItem });
            TopMenuStrip.Location = new Point(0, 0);
            TopMenuStrip.Name = "TopMenuStrip";
            TopMenuStrip.Size = new Size(800, 33);
            TopMenuStrip.TabIndex = 17;
            TopMenuStrip.Text = "menuStrip1";
            // 
            // fileTopMenuItem
            // 
            fileTopMenuItem.DropDownItems.AddRange(new ToolStripItem[] { OpenTopMenuItem, SubmitTopMenuItem, ClearTopMenuItem, ExitTopMenuItem });
            fileTopMenuItem.Name = "fileTopMenuItem";
            fileTopMenuItem.Size = new Size(59, 29);
            fileTopMenuItem.Text = "File ";
            // 
            // OpenTopMenuItem
            // 
            OpenTopMenuItem.Name = "OpenTopMenuItem";
            OpenTopMenuItem.Size = new Size(171, 34);
            OpenTopMenuItem.Text = "&Open";
            OpenTopMenuItem.Click += OpenTopMenuItem_Click;
            // 
            // SubmitTopMenuItem
            // 
            SubmitTopMenuItem.Name = "SubmitTopMenuItem";
            SubmitTopMenuItem.Size = new Size(171, 34);
            SubmitTopMenuItem.Text = "&Submit";
            SubmitTopMenuItem.Click += SubmitButton_Click;
            // 
            // ClearTopMenuItem
            // 
            ClearTopMenuItem.Name = "ClearTopMenuItem";
            ClearTopMenuItem.Size = new Size(171, 34);
            ClearTopMenuItem.Text = "&Clear";
            ClearTopMenuItem.Click += ClearButton_Click;
            // 
            // ExitTopMenuItem
            // 
            ExitTopMenuItem.Name = "ExitTopMenuItem";
            ExitTopMenuItem.Size = new Size(171, 34);
            ExitTopMenuItem.Text = "E&xit";
            ExitTopMenuItem.Click += ExitButton_Click;
            // 
            // helpTopMenuItem
            // 
            helpTopMenuItem.DropDownItems.AddRange(new ToolStripItem[] { AboutTopMenuItem });
            helpTopMenuItem.Name = "helpTopMenuItem";
            helpTopMenuItem.Size = new Size(65, 29);
            helpTopMenuItem.Text = "Help";
            // 
            // AboutTopMenuItem
            // 
            AboutTopMenuItem.Name = "AboutTopMenuItem";
            AboutTopMenuItem.Size = new Size(164, 34);
            AboutTopMenuItem.Text = "&About";
            AboutTopMenuItem.Click += AboutTopMenuItem_Click;
            // 
            // MainOpenFileDialog
            // 
            MainOpenFileDialog.FileName = "openFileDialog1";
            // 
            // DisplayListBox
            // 
            DisplayListBox.Font = new Font("Source Code Pro", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DisplayListBox.FormattingEnabled = true;
            DisplayListBox.Location = new Point(337, 73);
            DisplayListBox.Name = "DisplayListBox";
            DisplayListBox.Size = new Size(443, 247);
            DisplayListBox.TabIndex = 19;
            // 
            // FilterComboBox
            // 
            FilterComboBox.FormattingEnabled = true;
            FilterComboBox.Location = new Point(337, 36);
            FilterComboBox.Name = "FilterComboBox";
            FilterComboBox.Size = new Size(182, 33);
            FilterComboBox.TabIndex = 20;
            // 
            // FilterOptionsGroupBox
            // 
            FilterOptionsGroupBox.Controls.Add(FirstNameRadioButton);
            FilterOptionsGroupBox.Controls.Add(LastNameRadioButton);
            FilterOptionsGroupBox.Controls.Add(CityRadioButton);
            FilterOptionsGroupBox.Location = new Point(170, 227);
            FilterOptionsGroupBox.Name = "FilterOptionsGroupBox";
            FilterOptionsGroupBox.Size = new Size(161, 203);
            FilterOptionsGroupBox.TabIndex = 21;
            FilterOptionsGroupBox.TabStop = false;
            FilterOptionsGroupBox.Text = "Filter Options";
            // 
            // CityRadioButton
            // 
            CityRadioButton.AutoSize = true;
            CityRadioButton.Location = new Point(6, 30);
            CityRadioButton.Name = "CityRadioButton";
            CityRadioButton.Size = new Size(67, 29);
            CityRadioButton.TabIndex = 0;
            CityRadioButton.TabStop = true;
            CityRadioButton.Text = "City";
            CityRadioButton.UseVisualStyleBackColor = true;
            // 
            // LastNameRadioButton
            // 
            LastNameRadioButton.AutoSize = true;
            LastNameRadioButton.Location = new Point(6, 64);
            LastNameRadioButton.Name = "LastNameRadioButton";
            LastNameRadioButton.Size = new Size(120, 29);
            LastNameRadioButton.TabIndex = 1;
            LastNameRadioButton.TabStop = true;
            LastNameRadioButton.Text = "Last Name";
            LastNameRadioButton.UseVisualStyleBackColor = true;
            // 
            // FirstNameRadioButton
            // 
            FirstNameRadioButton.AutoSize = true;
            FirstNameRadioButton.Location = new Point(6, 99);
            FirstNameRadioButton.Name = "FirstNameRadioButton";
            FirstNameRadioButton.Size = new Size(122, 29);
            FirstNameRadioButton.TabIndex = 2;
            FirstNameRadioButton.TabStop = true;
            FirstNameRadioButton.Text = "First Name";
            FirstNameRadioButton.UseVisualStyleBackColor = true;
            // 
            // WinFormExampleForm
            // 
            AcceptButton = SubmitButton;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = ClearButton;
            ClientSize = new Size(800, 450);
            Controls.Add(FilterOptionsGroupBox);
            Controls.Add(FilterComboBox);
            Controls.Add(DisplayListBox);
            Controls.Add(FormatOptionsGroupBox);
            Controls.Add(UserInfoGroupBox);
            Controls.Add(ButtonsGroupBox);
            Controls.Add(TopMenuStrip);
            MainMenuStrip = TopMenuStrip;
            Name = "WinFormExampleForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Windows Form Example";
            ButtonsGroupBox.ResumeLayout(false);
            UserInfoGroupBox.ResumeLayout(false);
            UserInfoGroupBox.PerformLayout();
            FormatOptionsGroupBox.ResumeLayout(false);
            FormatOptionsGroupBox.PerformLayout();
            FormatContextMenuStrip.ResumeLayout(false);
            TopMenuStrip.ResumeLayout(false);
            TopMenuStrip.PerformLayout();
            FilterOptionsGroupBox.ResumeLayout(false);
            FilterOptionsGroupBox.PerformLayout();
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
        private RadioButton ReverseRadioButton;
        private RadioButton UpperCaseRadioButton;
        private RadioButton LowerCaseRadioButton;
        private ToolTip MainToolTip;
        private MenuStrip TopMenuStrip;
        private ToolStripMenuItem fileTopMenuItem;
        private ToolStripMenuItem helpTopMenuItem;
        private ToolStripMenuItem SubmitTopMenuItem;
        private ToolStripMenuItem ClearTopMenuItem;
        private ToolStripMenuItem ExitTopMenuItem;
        private ToolStripMenuItem AboutTopMenuItem;
        private GroupBox FormatOptionsGroupBox;
        private ContextMenuStrip FormatContextMenuStrip;
        private ToolStripMenuItem UpperContextMenuItem;
        private ToolStripMenuItem LowerContextMenuItem;
        private ToolStripMenuItem ReverseContextMenuItem;
        private OpenFileDialog MainOpenFileDialog;
        private ToolStripMenuItem OpenTopMenuItem;
        private ListBox DisplayListBox;
        private ComboBox FilterComboBox;
        private GroupBox FilterOptionsGroupBox;
        private RadioButton FirstNameRadioButton;
        private RadioButton LastNameRadioButton;
        private RadioButton CityRadioButton;
    }
}
