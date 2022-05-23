
namespace Wato_Commuting_management
{
    partial class Commuting_history
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Commuting_history));
            this.historylistView1 = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.datesearchbutton = new System.Windows.Forms.Button();
            this.Okbutton = new MetroFramework.Controls.MetroButton();
            this.Deletebutton = new MetroFramework.Controls.MetroButton();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // historylistView1
            // 
            this.historylistView1.HideSelection = false;
            this.historylistView1.Location = new System.Drawing.Point(12, 90);
            this.historylistView1.Name = "historylistView1";
            this.historylistView1.Size = new System.Drawing.Size(395, 297);
            this.historylistView1.TabIndex = 10;
            this.historylistView1.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(207, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "* 최근 100일 데이터";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(197, 63);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(116, 21);
            this.dateTimePicker2.TabIndex = 1;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(54, 63);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(116, 21);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(174, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "~";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // datesearchbutton
            // 
            this.datesearchbutton.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.datesearchbutton.Location = new System.Drawing.Point(319, 63);
            this.datesearchbutton.Name = "datesearchbutton";
            this.datesearchbutton.Size = new System.Drawing.Size(41, 21);
            this.datesearchbutton.TabIndex = 2;
            this.datesearchbutton.Text = "검색";
            this.datesearchbutton.UseVisualStyleBackColor = true;
            this.datesearchbutton.Click += new System.EventHandler(this.datesearchbutton_Click);
            // 
            // Okbutton
            // 
            this.Okbutton.Location = new System.Drawing.Point(209, 414);
            this.Okbutton.Name = "Okbutton";
            this.Okbutton.Size = new System.Drawing.Size(210, 33);
            this.Okbutton.TabIndex = 4;
            this.Okbutton.Text = "확인";
            this.Okbutton.UseSelectable = true;
            this.Okbutton.Click += new System.EventHandler(this.Okbutton_Click);
            // 
            // Deletebutton
            // 
            this.Deletebutton.Location = new System.Drawing.Point(-1, 414);
            this.Deletebutton.Name = "Deletebutton";
            this.Deletebutton.Size = new System.Drawing.Size(210, 33);
            this.Deletebutton.TabIndex = 3;
            this.Deletebutton.Text = "삭제";
            this.Deletebutton.UseSelectable = true;
            this.Deletebutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Location = new System.Drawing.Point(366, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(41, 21);
            this.button1.TabIndex = 16;
            this.button1.Text = "추출";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Commuting_history
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(419, 447);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Deletebutton);
            this.Controls.Add(this.Okbutton);
            this.Controls.Add(this.datesearchbutton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.historylistView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Commuting_history";
            this.Resizable = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "출, 퇴근 기록";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView historylistView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button datesearchbutton;
        private MetroFramework.Controls.MetroButton Okbutton;
        private MetroFramework.Controls.MetroButton Deletebutton;
        private System.Windows.Forms.Button button1;
    }
}