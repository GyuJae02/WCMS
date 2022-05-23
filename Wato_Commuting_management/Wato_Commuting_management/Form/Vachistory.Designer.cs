
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
            this.label1.Location = new System.Drawing.Point(153, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 23);
            this.label1.TabIndex = 14;
            this.label1.Text = "* 최근 100일 데이터";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // historylistView
            // 
            this.historylistView.HideSelection = false;
            this.historylistView.Location = new System.Drawing.Point(12, 101);
            this.historylistView.Name = "historylistView";
            this.historylistView.Size = new System.Drawing.Size(305, 307);
            this.historylistView.TabIndex = 3;
            this.historylistView.UseCompatibleStateImageBehavior = false;
            // 
            // Vaccountlabel
            // 
            this.Vaccountlabel.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Vaccountlabel.Location = new System.Drawing.Point(12, 48);
            this.Vaccountlabel.Name = "Vaccountlabel";
            this.Vaccountlabel.Size = new System.Drawing.Size(135, 23);
            this.Vaccountlabel.TabIndex = 15;
            this.Vaccountlabel.Text = "Null";
            this.Vaccountlabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(131, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "~";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(11, 74);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(116, 21);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(154, 74);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(116, 21);
            this.dateTimePicker2.TabIndex = 1;
            // 
            // Okbutton
            // 
            this.Okbutton.Location = new System.Drawing.Point(161, 414);
            this.Okbutton.Name = "Okbutton";
            this.Okbutton.Size = new System.Drawing.Size(169, 33);
            this.Okbutton.TabIndex = 5;
            this.Okbutton.Text = "확인";
            this.Okbutton.UseSelectable = true;
            this.Okbutton.Click += new System.EventHandler(this.Okbutton_Click);
            // 
            // Deletebutton
            // 
            this.Deletebutton.Location = new System.Drawing.Point(0, 414);
            this.Deletebutton.Name = "Deletebutton";
            this.Deletebutton.Size = new System.Drawing.Size(162, 33);
            this.Deletebutton.TabIndex = 4;
            this.Deletebutton.Text = "삭제";
            this.Deletebutton.UseSelectable = true;
            this.Deletebutton.Click += new System.EventHandler(this.Deletebutton_Click);
            // 
            // oksearchbutton
            // 
            this.oksearchbutton.Location = new System.Drawing.Point(276, 74);
            this.oksearchbutton.Name = "oksearchbutton";
            this.oksearchbutton.Size = new System.Drawing.Size(41, 21);
            this.oksearchbutton.TabIndex = 2;
            this.oksearchbutton.Text = "검색";
            this.oksearchbutton.UseSelectable = true;
            this.oksearchbutton.Click += new System.EventHandler(this.oksearchbutton_Click);
            // 
            // Vachistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 447);
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
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Vachistory";
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