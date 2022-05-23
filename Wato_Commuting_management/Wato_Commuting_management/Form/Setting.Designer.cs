
namespace Wato_Commuting_management
{
    partial class Setting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Setting));
            this.CommutingDelmetroTile = new MetroFramework.Controls.MetroTile();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.VacDelmetroTile = new MetroFramework.Controls.MetroTile();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.MemoDelmetroTile = new MetroFramework.Controls.MetroTile();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.MyinfoDelmetroTile = new MetroFramework.Controls.MetroTile();
            this.OkmetroButton = new MetroFramework.Controls.MetroButton();
            this.htmlLabel1 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // CommutingDelmetroTile
            // 
            this.CommutingDelmetroTile.ActiveControl = null;
            this.CommutingDelmetroTile.Location = new System.Drawing.Point(6, 20);
            this.CommutingDelmetroTile.Name = "CommutingDelmetroTile";
            this.CommutingDelmetroTile.Size = new System.Drawing.Size(94, 74);
            this.CommutingDelmetroTile.TabIndex = 0;
            this.CommutingDelmetroTile.Text = "데이터 삭제";
            this.CommutingDelmetroTile.UseSelectable = true;
            this.CommutingDelmetroTile.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CommutingDelmetroTile);
            this.groupBox1.Location = new System.Drawing.Point(23, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(413, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "근태 관리";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.VacDelmetroTile);
            this.groupBox2.Location = new System.Drawing.Point(23, 169);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(413, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "휴가 관리";
            // 
            // VacDelmetroTile
            // 
            this.VacDelmetroTile.ActiveControl = null;
            this.VacDelmetroTile.Location = new System.Drawing.Point(6, 20);
            this.VacDelmetroTile.Name = "VacDelmetroTile";
            this.VacDelmetroTile.Size = new System.Drawing.Size(94, 74);
            this.VacDelmetroTile.TabIndex = 1;
            this.VacDelmetroTile.Text = "데이터 삭제";
            this.VacDelmetroTile.UseSelectable = true;
            this.VacDelmetroTile.Click += new System.EventHandler(this.VacDelmetroTile_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.MemoDelmetroTile);
            this.groupBox3.Location = new System.Drawing.Point(23, 275);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(413, 100);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "메모 관리";
            // 
            // MemoDelmetroTile
            // 
            this.MemoDelmetroTile.ActiveControl = null;
            this.MemoDelmetroTile.Location = new System.Drawing.Point(6, 20);
            this.MemoDelmetroTile.Name = "MemoDelmetroTile";
            this.MemoDelmetroTile.Size = new System.Drawing.Size(94, 74);
            this.MemoDelmetroTile.TabIndex = 2;
            this.MemoDelmetroTile.Text = "데이터 삭제";
            this.MemoDelmetroTile.UseSelectable = true;
            this.MemoDelmetroTile.Click += new System.EventHandler(this.MemoDelmetroTile_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.MyinfoDelmetroTile);
            this.groupBox4.Location = new System.Drawing.Point(23, 381);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(413, 100);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "내정보 관리";
            // 
            // MyinfoDelmetroTile
            // 
            this.MyinfoDelmetroTile.ActiveControl = null;
            this.MyinfoDelmetroTile.Location = new System.Drawing.Point(6, 20);
            this.MyinfoDelmetroTile.Name = "MyinfoDelmetroTile";
            this.MyinfoDelmetroTile.Size = new System.Drawing.Size(94, 74);
            this.MyinfoDelmetroTile.TabIndex = 3;
            this.MyinfoDelmetroTile.Text = "탈퇴";
            this.MyinfoDelmetroTile.UseSelectable = true;
            this.MyinfoDelmetroTile.Click += new System.EventHandler(this.MyinfoDelmetroTile_Click);
            // 
            // OkmetroButton
            // 
            this.OkmetroButton.Location = new System.Drawing.Point(-1, 531);
            this.OkmetroButton.Name = "OkmetroButton";
            this.OkmetroButton.Size = new System.Drawing.Size(461, 33);
            this.OkmetroButton.TabIndex = 4;
            this.OkmetroButton.Text = "확인";
            this.OkmetroButton.UseSelectable = true;
            this.OkmetroButton.Click += new System.EventHandler(this.OkmetroButton_Click);
            // 
            // htmlLabel1
            // 
            this.htmlLabel1.AutoScroll = true;
            this.htmlLabel1.AutoScrollMinSize = new System.Drawing.Size(355, 22);
            this.htmlLabel1.AutoSize = false;
            this.htmlLabel1.BackColor = System.Drawing.SystemColors.Window;
            this.htmlLabel1.Location = new System.Drawing.Point(23, 487);
            this.htmlLabel1.Name = "htmlLabel1";
            this.htmlLabel1.Size = new System.Drawing.Size(413, 23);
            this.htmlLabel1.TabIndex = 4;
            this.htmlLabel1.Text = "* 핀(패스워드), 직급 ,이메일 변경은 내정보 창에서 가능합니다.";
            // 
            // Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 562);
            this.Controls.Add(this.htmlLabel1);
            this.Controls.Add(this.OkmetroButton);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Setting";
            this.Resizable = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "설정";
            this.Load += new System.EventHandler(this.Setting_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile CommutingDelmetroTile;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroTile VacDelmetroTile;
        private System.Windows.Forms.GroupBox groupBox3;
        private MetroFramework.Controls.MetroTile MemoDelmetroTile;
        private System.Windows.Forms.GroupBox groupBox4;
        private MetroFramework.Controls.MetroTile MyinfoDelmetroTile;
        private MetroFramework.Controls.MetroButton OkmetroButton;
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel1;
    }
}