namespace ArtificialBrowser
{
    partial class Settings
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.themeGroupBox = new System.Windows.Forms.GroupBox();
            this.darkModeRadioButton = new System.Windows.Forms.RadioButton();
            this.lightModeRadioButton = new System.Windows.Forms.RadioButton();
            this.languageGroupBox = new System.Windows.Forms.GroupBox();
            this.languageComboBox = new System.Windows.Forms.ComboBox();
            this.notificationsCheckBox = new System.Windows.Forms.CheckBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.themeGroupBox.SuspendLayout();
            this.languageGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // themeGroupBox
            // 
            this.themeGroupBox.Controls.Add(this.darkModeRadioButton);
            this.themeGroupBox.Controls.Add(this.lightModeRadioButton);
            this.themeGroupBox.Location = new System.Drawing.Point(12, 12);
            this.themeGroupBox.Name = "themeGroupBox";
            this.themeGroupBox.Size = new System.Drawing.Size(200, 100);
            this.themeGroupBox.TabIndex = 0;
            this.themeGroupBox.TabStop = false;
            this.themeGroupBox.Text = "Theme";
            // 
            // darkModeRadioButton
            // 
            this.darkModeRadioButton.AutoSize = true;
            this.darkModeRadioButton.Location = new System.Drawing.Point(6, 58);
            this.darkModeRadioButton.Name = "darkModeRadioButton";
            this.darkModeRadioButton.Size = new System.Drawing.Size(78, 17);
            this.darkModeRadioButton.TabIndex = 1;
            this.darkModeRadioButton.TabStop = true;
            this.darkModeRadioButton.Text = "Dark Mode";
            this.darkModeRadioButton.UseVisualStyleBackColor = true;
            this.darkModeRadioButton.CheckedChanged += new System.EventHandler(this.darkModeRadioButton_CheckedChanged);
            // 
            // lightModeRadioButton
            // 
            this.lightModeRadioButton.AutoSize = true;
            this.lightModeRadioButton.Location = new System.Drawing.Point(6, 31);
            this.lightModeRadioButton.Name = "lightModeRadioButton";
            this.lightModeRadioButton.Size = new System.Drawing.Size(78, 17);
            this.lightModeRadioButton.TabIndex = 0;
            this.lightModeRadioButton.TabStop = true;
            this.lightModeRadioButton.Text = "Light Mode";
            this.lightModeRadioButton.UseVisualStyleBackColor = true;
            this.lightModeRadioButton.CheckedChanged += new System.EventHandler(this.lightModeRadioButton_CheckedChanged);
            // 
            // languageGroupBox
            // 
            this.languageGroupBox.Controls.Add(this.languageComboBox);
            this.languageGroupBox.Location = new System.Drawing.Point(12, 118);
            this.languageGroupBox.Name = "languageGroupBox";
            this.languageGroupBox.Size = new System.Drawing.Size(200, 70);
            this.languageGroupBox.TabIndex = 1;
            this.languageGroupBox.TabStop = false;
            this.languageGroupBox.Text = "Language";
            // 
            // languageComboBox
            // 
            this.languageComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.languageComboBox.FormattingEnabled = true;
            this.languageComboBox.Items.AddRange(new object[] {
            "English",
            "Spanish",
            "French",
            "German"});
            this.languageComboBox.Location = new System.Drawing.Point(6, 30);
            this.languageComboBox.Name = "languageComboBox";
            this.languageComboBox.Size = new System.Drawing.Size(188, 21);
            this.languageComboBox.TabIndex = 0;
            // 
            // notificationsCheckBox
            // 
            this.notificationsCheckBox.AutoSize = true;
            this.notificationsCheckBox.Location = new System.Drawing.Point(12, 200);
            this.notificationsCheckBox.Name = "notificationsCheckBox";
            this.notificationsCheckBox.Size = new System.Drawing.Size(120, 17);
            this.notificationsCheckBox.TabIndex = 2;
            this.notificationsCheckBox.Text = "Enable Notifications";
            this.notificationsCheckBox.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(137, 233);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 268);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.notificationsCheckBox);
            this.Controls.Add(this.languageGroupBox);
            this.Controls.Add(this.themeGroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Settings";
            this.Text = "Settings";
            this.themeGroupBox.ResumeLayout(false);
            this.themeGroupBox.PerformLayout();
            this.languageGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.GroupBox themeGroupBox;
        private System.Windows.Forms.RadioButton darkModeRadioButton;
        private System.Windows.Forms.RadioButton lightModeRadioButton;
        private System.Windows.Forms.GroupBox languageGroupBox;
        private System.Windows.Forms.ComboBox languageComboBox;
        private System.Windows.Forms.CheckBox notificationsCheckBox;
        private System.Windows.Forms.Button saveButton;
    }
}
