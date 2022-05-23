
namespace Wato_Commuting_management
{
    partial class StaffVachistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffVachistory));
            this.historylistView = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.Okbutton = new MetroFramework.Controls.MetroButton();
            this.datesearchbutton = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // historylistView
            // 
            this.historylistView.HideSelection = false;
            this.historylistView.Location = new System.Drawing.Point(12, 104);
            this.historylistView.Name = "historylistView";
            this.historylistView.Size = new System.Drawing.Size(305, 304);
            this.historylistView.TabIndex = 3;
            this.historylistView.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(155, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 23);
            this.label1.TabIndex = 19;
            this.label1.Text = "* 최근 100일 데이터";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(132, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "~";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(13, 77);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(116, 21);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(154, 77);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(116, 21);
            this.dateTimePicker2.TabIndex = 1;
            // 
            // Okbutton
            // 
            this.Okbutton.Location = new System.Drawing.Point(0, 414);
            this.Okbutton.Name = "Okbutton";
            this.Okbutton.Size = new System.Drawing.Size(331, 33);
            this.Okbutton.TabIndex = 4;
            this.Okbutton.Text = "확인";
            this.Okbutton.UseSelectable = true;
            this.Okbutton.Click += new System.EventHandler(this.Okbutton_Click);
            // 
            // datesearchbutton
            // 
            this.datesearchbutton.Location = new System.Drawing.Point(276, 77);
            this.datesearchbutton.Name = "datesearchbutton";
            this.datesearchbutton.Size = new System.Drawing.Size(41, 21);
            this.datesearchbutton.TabIndex = 2;
            this.datesearchbutton.Text = "검색";
            this.datesearchbutton.UseSelectable = true;
            this.datesearchbutton.Click += new System.EventHandler(this.datesearchbutton_Click);
            // 
            // StaffVachistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 447);
            this.Controls.Add(this.datesearchbutton);
            this.Controls.Add(this.Okbutton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.historylistView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StaffVachistory";
            this.Resizable = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "직원 휴가 조회";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView historylistView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private MetroFramework.Controls.MetroButton Okbutton;
        private MetroFramework.Controls.MetroButton datesearchbutton;
    }
}