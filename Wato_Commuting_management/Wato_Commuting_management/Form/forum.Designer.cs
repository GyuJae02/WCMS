
namespace Wato_Commuting_management
{
    partial class forum
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(forum));
            this.forumListView = new System.Windows.Forms.ListView();
            this.Okbutton = new MetroFramework.Controls.MetroButton();
            this.addButton = new MetroFramework.Controls.MetroButton();
            this.deleteButton = new MetroFramework.Controls.MetroButton();
            this.EditButton = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // forumListView
            // 
            this.forumListView.HideSelection = false;
            this.forumListView.Location = new System.Drawing.Point(23, 63);
            this.forumListView.Name = "forumListView";
            this.forumListView.Size = new System.Drawing.Size(847, 422);
            this.forumListView.TabIndex = 5;
            this.forumListView.UseCompatibleStateImageBehavior = false;
            this.forumListView.DoubleClick += new System.EventHandler(this.forumListView_DoubleClick);
            // 
            // Okbutton
            // 
            this.Okbutton.Location = new System.Drawing.Point(669, 501);
            this.Okbutton.Name = "Okbutton";
            this.Okbutton.Size = new System.Drawing.Size(224, 33);
            this.Okbutton.TabIndex = 3;
            this.Okbutton.Text = "확인";
            this.Okbutton.UseSelectable = true;
            this.Okbutton.Click += new System.EventHandler(this.Okbutton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(0, 501);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(224, 33);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "글쓰기";
            this.addButton.UseSelectable = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(446, 501);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(224, 33);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "삭제";
            this.deleteButton.UseSelectable = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(223, 501);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(224, 33);
            this.EditButton.TabIndex = 1;
            this.EditButton.Text = "수정";
            this.EditButton.UseSelectable = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // forum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 534);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.Okbutton);
            this.Controls.Add(this.forumListView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "forum";
            this.Resizable = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "게시판";
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroButton Okbutton;
        private MetroFramework.Controls.MetroButton addButton;
        private MetroFramework.Controls.MetroButton deleteButton;
        private MetroFramework.Controls.MetroButton EditButton;
        public System.Windows.Forms.ListView forumListView;
    }
}