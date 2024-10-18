namespace ArtificialBrowser
{
    partial class ArtificialBrowser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing"
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArtificialBrowser));
            this.Undo = new System.Windows.Forms.Button();
            this.Redo = new System.Windows.Forms.Button();
            this.Refresh = new System.Windows.Forms.Button();
            this.Home = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Settings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Undo
            // 
            this.Undo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Undo.Location = new System.Drawing.Point(12, 5);
            this.Undo.Name = "Undo";
            this.Undo.Size = new System.Drawing.Size(83, 30);
            this.Undo.TabIndex = 1;
            this.Undo.Text = "Undo";
            this.Undo.UseVisualStyleBackColor = false;
            this.Undo.Click += new System.EventHandler(this.Undo_Click);
            // 
            // Redo
            // 
            this.Redo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Redo.Location = new System.Drawing.Point(101, 5);
            this.Redo.Name = "Redo";
            this.Redo.Size = new System.Drawing.Size(75, 30);
            this.Redo.TabIndex = 2;
            this.Redo.Text = "Redo";
            this.Redo.UseVisualStyleBackColor = false;
            this.Redo.Click += new System.EventHandler(this.Redo_Click);
            // 
            // Refresh
            // 
            this.Refresh.BackColor = System.Drawing.Color.Coral;
            this.Refresh.BackgroundImage = global::ArtificialBrowser.Properties.Resources.Refresh_AB_Deselected;
            this.Refresh.Image = global::ArtificialBrowser.Properties.Resources.Refresh_AB_Deselected;
            this.Refresh.Location = new System.Drawing.Point(182, 5);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(75, 30);
            this.Refresh.TabIndex = 3;
            this.Refresh.Text = "Refresh";
            this.Refresh.UseVisualStyleBackColor = false;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // Home
            // 
            this.Home.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Home.Location = new System.Drawing.Point(263, 5);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(75, 30);
            this.Home.TabIndex = 4;
            this.Home.Text = "Home";
            this.Home.UseVisualStyleBackColor = false;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Search.Location = new System.Drawing.Point(1018, 5);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(137, 31);
            this.Search.TabIndex = 5;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = false;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(368, 11);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(631, 20);
            this.textBox1.TabIndex = 6;
            // 
            // Settings
            // 
            this.Settings.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Settings.Location = new System.Drawing.Point(1161, 5);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(74, 31);
            this.Settings.TabIndex = 7;
            this.Settings.Text = "Settings";
            this.Settings.UseVisualStyleBackColor = false;
            this.Settings.Click += new System.EventHandler(this.Settings_Click);
            // 
            // ArtificialBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 641);
            this.Controls.Add(this.Settings);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Home);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.Redo);
            this.Controls.Add(this.Undo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ArtificialBrowser";
            this.Text = "ArtificialBrowser";
            this.Load += new System.EventHandler(this.ArtificialBrowser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Undo;
        private System.Windows.Forms.Button Redo;
        private System.Windows.Forms.Button Refresh;
        private System.Windows.Forms.Button Home;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Settings;
    }
}
