
namespace Wato_Commuting_management
{
    partial class UserInsert
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserInsert));
            this.LoginInfolabel = new System.Windows.Forms.Label();
            this.usertextbox = new System.Windows.Forms.TextBox();
            this.positiontextBox = new System.Windows.Forms.TextBox();
            this.Okbutton = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // LoginInfolabel
            // 
            this.LoginInfolabel.AutoSize = true;
            this.LoginInfolabel.Font = new System.Drawing.Font("굴림", 12F);
            this.LoginInfolabel.Location = new System.Drawing.Point(61, 79);
            this.LoginInfolabel.Name = "LoginInfolabel";
            this.LoginInfolabel.Size = new System.Drawing.Size(321, 16);
            this.LoginInfolabel.TabIndex = 4;
            this.LoginInfolabel.Text = "추가할 사용자의 성함과 직급을 입력하세요.";
            // 
            // usertextbox
            // 
            this.usertextbox.Location = new System.Drawing.Point(121, 109);
            this.usertextbox.Name = "usertextbox";
            this.usertextbox.Size = new System.Drawing.Size(99, 21);
            this.usertextbox.TabIndex = 0;
            // 
            // positiontextBox
            // 
            this.positiontextBox.Location = new System.Drawing.Point(226, 109);
            this.positiontextBox.Name = "positiontextBox";
            this.positiontextBox.Size = new System.Drawing.Size(67, 21);
            this.positiontextBox.TabIndex = 1;
            // 
            // Okbutton
            // 
            this.Okbutton.Location = new System.Drawing.Point(0, 158);
            this.Okbutton.Name = "Okbutton";
            this.Okbutton.Size = new System.Drawing.Size(421, 33);
            this.Okbutton.TabIndex = 2;
            this.Okbutton.Text = "확인";
            this.Okbutton.UseSelectable = true;
            this.Okbutton.Click += new System.EventHandler(this.Okbutton_Click);
            // 
            // UserInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(421, 191);
            this.Controls.Add(this.Okbutton);
            this.Controls.Add(this.positiontextBox);
            this.Controls.Add(this.usertextbox);
            this.Controls.Add(this.LoginInfolabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserInsert";
            this.Resizable = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "사용자 추가";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LoginInfolabel;
        private System.Windows.Forms.TextBox usertextbox;
        private System.Windows.Forms.TextBox positiontextBox;
        private MetroFramework.Controls.MetroButton Okbutton;
    }
}