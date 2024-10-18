using CefSharp;
using CefSharp.WinForms;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ArtificialBrowser
{
    public partial class ArtificialBrowser : Form
    {
        private ChromiumWebBrowser browser;

        public ArtificialBrowser()
        {
            InitializeComponent();
            InitializeBrowser();
            LoadUserSettings();
            textBox1.KeyDown += TextBox1_KeyDown;
            this.Resize += ArtificialBrowser_Resize;
        }

        private void InitializeBrowser()
        {
            browser = new ChromiumWebBrowser("https://www.google.com");
            this.Controls.Add(browser);
            browser.Dock = DockStyle.Bottom;
            AdjustBrowserSize();
        }

        private void AdjustBrowserSize()
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                browser.Height = 980;
            }
            else
            {
                browser.Height = this.ClientSize.Height - 25;
                browser.Top = this.ClientSize.Height - browser.Height;
            }
        }

        private void ArtificialBrowser_Resize(object sender, EventArgs e)
        {
            AdjustBrowserSize();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            PerformSearch();
        }

        private void PerformSearch()
        {
            string url = textBox1.Text;

            if (!url.StartsWith("http://") && !url.StartsWith("https://"))
            {
                if (url.Contains("."))
                {
                    url = "http://" + url;
                }
                else
                {
                    url = "https://www.google.com/search?q=" + Uri.EscapeDataString(url);
                }
            }

            try
            {
                browser.Load(url);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while trying to load the page: " + ex.Message);
            }
        }

        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                PerformSearch();
            }
        }

        private void Home_Click(object sender, EventArgs e)
        {
            browser.Load("https://www.google.com");
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            browser.Reload();
        }

        private void Undo_Click(object sender, EventArgs e)
        {
            if (browser.CanGoBack)
                browser.Back();
        }

        private void Redo_Click(object sender, EventArgs e)
        {
            if (browser.CanGoForward)
                browser.Forward();
        }

        private void ArtificialBrowser_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void Settings_Click(object sender, EventArgs e)
        {
            Settings settingsForm = new Settings();
            settingsForm.ShowDialog();
        }

        private void LoadUserSettings()
        {
            if (File.Exists("settings.txt"))
            {
                var settings = File.ReadAllLines("settings.txt");
                if (settings.Length > 0)
                {
                    ApplyTheme(settings[0]);
                }
            }
        }

        /*private void ApplyTheme(string theme)
        {
            if (theme == "Dark")
            {
                this.BackColor = Color.Black;
                foreach (Control control in this.Controls)
                {
                    control.ForeColor = Color.White;
                }
                InjectCSS("body { background-color: #121212 !important; color: white !important; }");
            }
            else
            {
                this.BackColor = Color.White;
                foreach (Control control in this.Controls)
                {
                    control.ForeColor = Color.Black;
                }
                InjectCSS("body { background-color: white !important; color: black !important; }");
            }
        }

        private void InjectCSS(string css)
        {
            if (browser.IsBrowserInitialized && browser.CanExecuteJavascriptInMainFrame)
            {
                string js = $"var style = document.createElement('style'); style.innerHTML = '{css.Replace("'", "\\'")}'; document.head.appendChild(style);";
                browser.ExecuteScriptAsync(js);
            }
        }*/

        private void ApplyTheme(string theme)
        {
            if (theme == "Dark")
            {
                this.BackColor = Color.Black;
                foreach (Control control in this.Controls)
                {
                    control.ForeColor = Color.White;
                }

                InjectCSS("body { background-color: #121212 !important; color: white !important; } " +
                           "input, textarea, select { background-color: #1e1e1e !important; color: white !important; } " +
                           "a { color: #1e90ff !important; }");
            }
            else
            {
                this.BackColor = Color.White;
                foreach (Control control in this.Controls)
                {
                    control.ForeColor = Color.Black;
                }

                InjectCSS("body { background-color: white !important; color: black !important; } " +
                           "input, textarea, select { background-color: white !important; color: black !important; } " +
                           "a { color: blue !important; }");
            }
        }

        private void InjectCSS(string css)
        {
            if (browser.IsBrowserInitialized && browser.CanExecuteJavascriptInMainFrame)
            {
                string js = $"var style = document.createElement('style'); " +
                            $"style.innerHTML = '{css.Replace("'", "\\'")}'; " +
                            $"document.head.appendChild(style);";
                browser.ExecuteScriptAsync(js);
            }
        }

    }
}
