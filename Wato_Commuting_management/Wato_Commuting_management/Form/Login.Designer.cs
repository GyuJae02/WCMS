
namespace Wato_Commuting_management
{
    partial class Login
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.Title = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textbox = new System.Windows.Forms.TextBox();
            this.LoginInfolabel = new System.Windows.Forms.Label();
            this.Loginbutton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.UserInsertbutton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Title.Location = new System.Drawing.Point(70, 302);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(228, 27);
            this.Title.TabIndex = 1;
            this.Title.Text = "근태 관리 시스템";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Location = new System.Drawing.Point(105, 409);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(143, 1);
            this.panel1.TabIndex = 9;
            // 
            // textbox
            // 
            this.textbox.BackColor = System.Drawing.Color.White;
            this.textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textbox.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textbox.Location = new System.Drawing.Point(105, 386);
            this.textbox.Name = "textbox";
            this.textbox.Size = new System.Drawing.Size(143, 18);
            this.textbox.TabIndex = 0;
            // 
            // LoginInfolabel
            // 
            this.LoginInfolabel.AutoSize = true;
            this.LoginInfolabel.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LoginInfolabel.ForeColor = System.Drawing.Color.Gray;
            this.LoginInfolabel.Location = new System.Drawing.Point(100, 359);
            this.LoginInfolabel.Name = "LoginInfolabel";
            this.LoginInfolabel.Size = new System.Drawing.Size(42, 16);
            this.LoginInfolabel.TabIndex = 3;
            this.LoginInfolabel.Text = "이름";
            // 
            // Loginbutton
            // 
            this.Loginbutton.BackColor = System.Drawing.Color.SkyBlue;
            this.Loginbutton.FlatAppearance.BorderSize = 0;
            this.Loginbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Loginbutton.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Loginbutton.ForeColor = System.Drawing.Color.White;
            this.Loginbutton.Location = new System.Drawing.Point(91, 443);
            this.Loginbutton.Name = "Loginbutton";
            this.Loginbutton.Size = new System.Drawing.Size(116, 29);
            this.Loginbutton.TabIndex = 1;
            this.Loginbutton.Text = "로그인";
            this.Loginbutton.UseVisualStyleBackColor = false;
            this.Loginbutton.Click += new System.EventHandler(this.Loginbutton_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::Wato_Commuting_management.Properties.Resources.LoginBackground;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(0, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(368, 270);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Wato_Commuting_management.Properties.Resources.wato_logo;
            this.pictureBox1.Location = new System.Drawing.Point(89, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(184, 163);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // UserInsertbutton
            // 
            this.UserInsertbutton.BackColor = System.Drawing.Color.SkyBlue;
            this.UserInsertbutton.FlatAppearance.BorderSize = 0;
            this.UserInsertbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UserInsertbutton.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.UserInsertbutton.ForeColor = System.Drawing.Color.White;
            this.UserInsertbutton.Location = new System.Drawing.Point(91, 478);
            this.UserInsertbutton.Name = "UserInsertbutton";
            this.UserInsertbutton.Size = new System.Drawing.Size(116, 29);
            this.UserInsertbutton.TabIndex = 2;
            this.UserInsertbutton.Text = "사용자 등록";
            this.UserInsertbutton.UseVisualStyleBackColor = false;
            this.UserInsertbutton.Click += new System.EventHandler(this.UserInsertbutton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SkyBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(213, 443);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 64);
            this.button1.TabIndex = 3;
            this.button1.Text = "종료";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(368, 552);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.UserInsertbutton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Loginbutton);
            this.Controls.Add(this.textbox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LoginInfolabel);
            this.Controls.Add(this.Title);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.Resizable = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "로그인";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Login_KeyDown);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textbox;
        private System.Windows.Forms.Label LoginInfolabel;
        private System.Windows.Forms.Button Loginbutton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button UserInsertbutton;
        private System.Windows.Forms.Button button1;
    }
}

