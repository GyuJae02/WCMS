using System;
using log4net;
using System.Xml;
using MetroFramework;
using System.Windows.Forms;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace Wato_Commuting_management
{
    public partial class Login : MetroFramework.Forms.MetroForm
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Login));

        static public string name;
        static public string position;
        static public int vac_count;
        static public string mail;
        static public string pw_result;

        public Login()
        {
            InitializeComponent();

            Config con = se_de.XmlDeserialize<Config>(@"config.xml");

            if (con.Account_save_check == "1")
            {
                textbox.Text = con.ID;
            }
        }

        private void Loginbutton_Click(object sender, EventArgs e)
        {
            LoginToPin();
        }

        public string UserSelectDals()
        {
            string _name = "";
            string _position = "";
            int _vac_count = 0;
            string _mail = "";
            string _pw = "";            

            using (MySqlConnection conn = new MySqlConnection(DB_info_xml.db_info))
            {
                conn.Open();
                string sql = $"SELECT * FROM USER_tb WHERE Name = '{textbox.Text}'";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    _name = rdr["name"].ToString();
                    _position = rdr["position"].ToString();
                    _vac_count = Convert.ToInt32(rdr["vacation_count"]);
                    _mail = rdr["mail"].ToString();
                    _pw = rdr["pin_pw"].ToString();
                }
                rdr.Close();
                log.Info($"{sql}");
            }

            if (_name == null || _name == "" || _name == " ")
            {
                return "NullUser";
            }

            name = textbox.Text;
            position = _position;
            vac_count = _vac_count;
            mail = _mail;

            return _pw;
        }

        private void UserInsertbutton_Click(object sender, EventArgs e)
        {
            UserInsert UI = new UserInsert();
            UI.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.watosolution.com/main");
        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoginToPin();
            }
        }

        private void LoginToPin()
        {
            pw_result = UserSelectDals();

            if (textbox.Text == null || textbox.Text == "" || textbox.Text == " ")
            {
                MetroMessageBox.Show(this, "성함을 입력하세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (pw_result == "NullUser")
            {
                MetroMessageBox.Show(this, "등록되지 않은 직원입니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (pw_result == null || pw_result == "" || pw_result == " ")
            {
                MetroMessageBox.Show(this, "초기 패스워드를 설정합니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Form _pininsert = new PinInsert();
                _pininsert.ShowDialog();
            }
            else
            {
                Form _pinlogin = new PinLogin();
                this.Hide();
                _pinlogin.ShowDialog();
            }
        }
    }
}
