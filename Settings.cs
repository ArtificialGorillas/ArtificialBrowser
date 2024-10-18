using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ArtificialBrowser
{
    public partial class Settings : Form
    {
        private const string settingsFilePath = "settings.txt";

        public Settings()
        {
            InitializeComponent();
            LoadSettings();
        }

        private void LoadSettings()
        {
            if (File.Exists(settingsFilePath))
            {
                var settings = File.ReadAllLines(settingsFilePath);
                if (settings.Length > 0)
                {
                    lightModeRadioButton.Checked = settings[0] == "Light";
                    darkModeRadioButton.Checked = settings[0] == "Dark";
                }
                if (settings.Length > 1)
                {
                    languageComboBox.SelectedItem = settings[1];
                }
                if (settings.Length > 2)
                {
                    notificationsCheckBox.Checked = settings[2] == "True";
                }
            }
            else
            {
                lightModeRadioButton.Checked = true;
                languageComboBox.SelectedItem = "English";
                notificationsCheckBox.Checked = true;
            }
        }

        private void lightModeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (lightModeRadioButton.Checked)
            {
                this.BackColor = Color.White;
                foreach (Control control in this.Controls)
                {
                    control.ForeColor = Color.Black;
                }
            }
        }

        private void darkModeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (darkModeRadioButton.Checked)
            {
                this.BackColor = Color.Black;
                foreach (Control control in this.Controls)
                {
                    control.ForeColor = Color.White;
                }
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            File.WriteAllLines(settingsFilePath, new[]
            {
                darkModeRadioButton.Checked ? "Dark" : "Light",
                languageComboBox.SelectedItem.ToString(),
                notificationsCheckBox.Checked.ToString()
            });

            MessageBox.Show("Settings saved successfully!");
            this.Close();
        }
    }
}
