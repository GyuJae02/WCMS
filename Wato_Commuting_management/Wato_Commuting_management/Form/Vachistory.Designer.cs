
namespace Wato_Commuting_management
{
    partial class Vachistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vachistory));
            this.label1 = new System.Windows.Forms.Label();
            this.historylistView = new System.Windows.Forms.ListView();
            this.Vaccountlabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.Okbutton = new MetroFramework.Controls.MetroButton();
            this.Deletebutton = new MetroFramework.Controls.MetroButton();
            this.oksearchbutton = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(175, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 29);
            this.label1.TabIndex = 14;
            this.label1.Text = "* 최근 1년 데이터";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // historylistView
            // 
            this.historylistView.HideSelection = false;
            this.historylistView.Location = new System.Drawing.Point(14, 126);
            this.historylistView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.historylistView.Name = "historylistView";
            this.historylistView.Size = new System.Drawing.Size(348, 383);
            this.historylistView.TabIndex = 3;
            this.historylistView.UseCompatibleStateImageBehavior = false;
            // 
            // Vaccountlabel
            // 
            this.Vaccountlabel.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Vaccountlabel.Location = new System.Drawing.Point(14, 60);
            this.Vaccountlabel.Name = "Vaccountlabel";
            this.Vaccountlabel.Size = new System.Drawing.Size(154, 29);
            this.Vaccountlabel.TabIndex = 15;
            this.Vaccountlabel.Text = "Null";
            this.Vaccountlabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(150, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "~";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(13, 92);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(132, 25);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(176, 92);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(132, 25);
            this.dateTimePicker2.TabIndex = 1;
            // 
            // Okbutton
            // 
            this.Okbutton.Location = new System.Drawing.Point(184, 518);
            this.Okbutton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Okbutton.Name = "Okbutton";
            this.Okbutton.Size = new System.Drawing.Size(193, 41);
            this.Okbutton.TabIndex = 5;
            this.Okbutton.Text = "확인";
            this.Okbutton.UseSelectable = true;
            this.Okbutton.Click += new System.EventHandler(this.Okbutton_Click);
            // 
            // Deletebutton
            // 
            this.Deletebutton.Location = new System.Drawing.Point(0, 518);
            this.Deletebutton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Deletebutton.Name = "Deletebutton";
            this.Deletebutton.Size = new System.Drawing.Size(185, 41);
            this.Deletebutton.TabIndex = 4;
            this.Deletebutton.Text = "삭제";
            this.Deletebutton.UseSelectable = true;
            this.Deletebutton.Click += new System.EventHandler(this.Deletebutton_Click);
            // 
            // oksearchbutton
            // 
            this.oksearchbutton.Location = new System.Drawing.Point(315, 92);
            this.oksearchbutton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.oksearchbutton.Name = "oksearchbutton";
            this.oksearchbutton.Size = new System.Drawing.Size(47, 26);
            this.oksearchbutton.TabIndex = 2;
            this.oksearchbutton.Text = "검색";
            this.oksearchbutton.UseSelectable = true;
            this.oksearchbutton.Click += new System.EventHandler(this.oksearchbutton_Click);
            // 
            // Vachistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 559);
            this.Controls.Add(this.oksearchbutton);
            this.Controls.Add(this.Deletebutton);
            this.Controls.Add(this.Okbutton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.Vaccountlabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.historylistView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Vachistory";
            this.Padding = new System.Windows.Forms.Padding(23, 75, 23, 25);
            this.Resizable = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "내 휴가 조회";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView historylistView;
        private System.Windows.Forms.Label Vaccountlabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private MetroFramework.Controls.MetroButton Okbutton;
        private MetroFramework.Controls.MetroButton Deletebutton;
        private MetroFramework.Controls.MetroButton oksearchbutton;
    }
}