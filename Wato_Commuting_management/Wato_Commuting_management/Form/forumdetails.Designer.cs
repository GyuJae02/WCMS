
namespace Wato_Commuting_management
{
    partial class forumdetails
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(forumdetails));
            this.panel1 = new System.Windows.Forms.Panel();
            this.titlemetroLabel = new MetroFramework.Controls.MetroLabel();
            this.adduseranddatemetroLabel = new MetroFramework.Controls.MetroLabel();
            this.Okbutton = new MetroFramework.Controls.MetroButton();
            this.ContentmetroLabel = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Location = new System.Drawing.Point(23, 105);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(750, 2);
            this.panel1.TabIndex = 11;
            // 
            // titlemetroLabel
            // 
            this.titlemetroLabel.AutoSize = true;
            this.titlemetroLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.titlemetroLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.titlemetroLabel.Location = new System.Drawing.Point(23, 72);
            this.titlemetroLabel.Name = "titlemetroLabel";
            this.titlemetroLabel.Size = new System.Drawing.Size(48, 25);
            this.titlemetroLabel.TabIndex = 12;
            this.titlemetroLabel.Text = "제목";
            // 
            // adduseranddatemetroLabel
            // 
            this.adduseranddatemetroLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.adduseranddatemetroLabel.Location = new System.Drawing.Point(364, 72);
            this.adduseranddatemetroLabel.Name = "adduseranddatemetroLabel";
            this.adduseranddatemetroLabel.Size = new System.Drawing.Size(409, 25);
            this.adduseranddatemetroLabel.TabIndex = 13;
            this.adduseranddatemetroLabel.Text = "작성시간 + 작성자";
            this.adduseranddatemetroLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Okbutton
            // 
            this.Okbutton.Location = new System.Drawing.Point(-1, 439);
            this.Okbutton.Name = "Okbutton";
            this.Okbutton.Size = new System.Drawing.Size(801, 33);
            this.Okbutton.TabIndex = 0;
            this.Okbutton.Text = "확인";
            this.Okbutton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Okbutton.UseSelectable = true;
            this.Okbutton.Click += new System.EventHandler(this.Okbutton_Click);
            // 
            // ContentmetroLabel
            // 
            // 
            // 
            // 
            this.ContentmetroLabel.CustomButton.Image = null;
            this.ContentmetroLabel.CustomButton.Location = new System.Drawing.Point(534, 1);
            this.ContentmetroLabel.CustomButton.Name = "";
            this.ContentmetroLabel.CustomButton.Size = new System.Drawing.Size(215, 215);
            this.ContentmetroLabel.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ContentmetroLabel.CustomButton.TabIndex = 1;
            this.ContentmetroLabel.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ContentmetroLabel.CustomButton.UseSelectable = true;
            this.ContentmetroLabel.CustomButton.Visible = false;
            this.ContentmetroLabel.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.ContentmetroLabel.Lines = new string[0];
            this.ContentmetroLabel.Location = new System.Drawing.Point(23, 113);
            this.ContentmetroLabel.MaxLength = 32767;
            this.ContentmetroLabel.Multiline = true;
            this.ContentmetroLabel.Name = "ContentmetroLabel";
            this.ContentmetroLabel.PasswordChar = '\0';
            this.ContentmetroLabel.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ContentmetroLabel.SelectedText = "";
            this.ContentmetroLabel.SelectionLength = 0;
            this.ContentmetroLabel.SelectionStart = 0;
            this.ContentmetroLabel.ShortcutsEnabled = true;
            this.ContentmetroLabel.Size = new System.Drawing.Size(750, 217);
            this.ContentmetroLabel.TabIndex = 0;
            this.ContentmetroLabel.UseSelectable = true;
            this.ContentmetroLabel.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ContentmetroLabel.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // forumdetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 472);
            this.Controls.Add(this.ContentmetroLabel);
            this.Controls.Add(this.Okbutton);
            this.Controls.Add(this.adduseranddatemetroLabel);
            this.Controls.Add(this.titlemetroLabel);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "forumdetails";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "상세 페이지";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroLabel titlemetroLabel;
        private MetroFramework.Controls.MetroLabel adduseranddatemetroLabel;
        private MetroFramework.Controls.MetroButton Okbutton;
        private MetroFramework.Controls.MetroTextBox ContentmetroLabel;
    }
}