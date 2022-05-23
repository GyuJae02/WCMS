
namespace Wato_Commuting_management
{
    partial class Memo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Memo));
            this.MemorichTextBox = new System.Windows.Forms.RichTextBox();
            this.Exitbutton = new MetroFramework.Controls.MetroButton();
            this.Savebutton = new MetroFramework.Controls.MetroButton();
            this.Exporttxtbutton = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // MemorichTextBox
            // 
            this.MemorichTextBox.Location = new System.Drawing.Point(12, 60);
            this.MemorichTextBox.Name = "MemorichTextBox";
            this.MemorichTextBox.Size = new System.Drawing.Size(401, 338);
            this.MemorichTextBox.TabIndex = 0;
            this.MemorichTextBox.Text = "";
            // 
            // Exitbutton
            // 
            this.Exitbutton.Location = new System.Drawing.Point(278, 414);
            this.Exitbutton.Name = "Exitbutton";
            this.Exitbutton.Size = new System.Drawing.Size(148, 33);
            this.Exitbutton.TabIndex = 3;
            this.Exitbutton.Text = "종료";
            this.Exitbutton.UseSelectable = true;
            this.Exitbutton.Click += new System.EventHandler(this.Exitbutton_Click);
            // 
            // Savebutton
            // 
            this.Savebutton.Location = new System.Drawing.Point(139, 414);
            this.Savebutton.Name = "Savebutton";
            this.Savebutton.Size = new System.Drawing.Size(140, 33);
            this.Savebutton.TabIndex = 2;
            this.Savebutton.Text = "저장";
            this.Savebutton.UseSelectable = true;
            this.Savebutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Exporttxtbutton
            // 
            this.Exporttxtbutton.Location = new System.Drawing.Point(0, 414);
            this.Exporttxtbutton.Name = "Exporttxtbutton";
            this.Exporttxtbutton.Size = new System.Drawing.Size(140, 33);
            this.Exporttxtbutton.TabIndex = 1;
            this.Exporttxtbutton.Text = "to txt";
            this.Exporttxtbutton.UseSelectable = true;
            this.Exporttxtbutton.Click += new System.EventHandler(this.Exporttxtbutton_Click);
            // 
            // Memo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 447);
            this.Controls.Add(this.Exporttxtbutton);
            this.Controls.Add(this.Savebutton);
            this.Controls.Add(this.Exitbutton);
            this.Controls.Add(this.MemorichTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Memo";
            this.Resizable = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "메모";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Memo_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox MemorichTextBox;
        private MetroFramework.Controls.MetroButton Exitbutton;
        private MetroFramework.Controls.MetroButton Savebutton;
        private MetroFramework.Controls.MetroButton Exporttxtbutton;
    }
}