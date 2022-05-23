using System;
using log4net;
using System.Xml;
using System.Text;
using MetroFramework;
using System.Reflection;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;
using System.IO;
using System.Xml.Serialization;

namespace Wato_Commuting_management
{
    public partial class PinLogin : MetroFramework.Forms.MetroForm
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(PinLogin));

        public static string de_pw;

        public PinLogin()
        {
            InitializeComponent();

            Config con = se_de.XmlDeserialize<Config>(@"config.xml"); 

            if (con.Account_save_check == "1")
            {
                idsavecheckBox.Checked = true;
                Pinlabel.Text = con.PW;
            }
        }

        #region numpad
        private void num0button_Click_1(object sender, EventArgs e)
        {
            Pinlabel.Text += "0";
        }

        private void num1button_Click(object sender, EventArgs e)
        {
            Pinlabel.Text += "1";
        }

        private void num2button_Click(object sender, EventArgs e)
        {
            Pinlabel.Text += "2";
        }

        private void num3button_Click(object sender, EventArgs e)
        {
            Pinlabel.Text += "3";
        }

        private void num4button_Click(object sender, EventArgs e)
        {
            Pinlabel.Text += "4";
        }

        private void num5button_Click(object sender, EventArgs e)
        {
            Pinlabel.Text += "5";
        }

        private void num6button_Click(object sender, EventArgs e)
        {
            Pinlabel.Text += "6";
        }

        private void num7button_Click(object sender, EventArgs e)
        {
            Pinlabel.Text += "7";
        }

        private void num8button_Click(object sender, EventArgs e)
        {
            Pinlabel.Text += "8";
        }

        private void num9button_Click(object sender, EventArgs e)
        {
            Pinlabel.Text += "9";
        }

        private void numbackbutton_Click(object sender, EventArgs e)
        {
            try
            {
                Pinlabel.Text = Pinlabel.Text.Remove(Pinlabel.Text.Length - 1);
            }
            catch (Exception)
            {

            }
        }
        #endregion

        private void Okbutton_Click(object sender, EventArgs e)
        {
            string user_name = "";

            if (Pinlabel.Text.Length > 4)
            {
                MetroMessageBox.Show(this, "핀은 4자리를 초과할 수 없습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Pinlabel.Text.Length < 4)
            {
                MetroMessageBox.Show(this, "핀은 4자리보다 작을 수 없습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    using (MySqlConnection conn = new MySqlConnection(DB_info_xml.db_info))
                    {
                        conn.Open();
                        string sql = $"SELECT * FROM USER_tb WHERE pin_pw = '{sha_265_protect(Pinlabel.Text)}'";
                        MySqlCommand cmd = new MySqlCommand(sql, conn);
                        MySqlDataReader rdr = cmd.ExecuteReader();
                        while (rdr.Read())
                        {
                            user_name = rdr["name"].ToString();
                        }
                        rdr.Close();
                        log.Info($"{sql}");
                    }

                    de_pw = Pinlabel.Text;
                }
                catch (Exception ex)
                {
                    MetroMessageBox.Show(this, $"로그인 하지 못했습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    log.Error($"An exception occurred from {MethodBase.GetCurrentMethod().Name}", ex);
                    return;
                }

                if (user_name != Login.name)
                {
                    MetroMessageBox.Show(this, $"핀 번호를 확인하세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    isChecked(idsavecheckBox.Checked);
                    this.Visible = false;

                    Form _Main = new Main();
                    _Main.ShowDialog();
                }
            }
        }

        public void isChecked(bool Checked)
        {
            if (Checked)
            {
                SetXml(Login.name, Pinlabel.Text, "1");
            }
            else
            {
                SetXml("null", "null", "0");
            }
        }

        protected XmlNode CreateNode(XmlDocument xmlDoc, string name, string innerXml)
        {
            XmlNode node = xmlDoc.CreateElement(string.Empty, name, string.Empty);
            node.InnerXml = innerXml;

            return node;
        }

        public void SetXml(string id, string pw, string account_save_check)
        {
            Config con = new Config
            {
                DB = "Server=192.168.0.240; Port=3306; Database=wato_commuting_management_db; Uid=root; Pwd=wato1201; convert zero datetime=True;",
                ID = id,
                PW = pw,
                Account_save_check = account_save_check
            };

            se_de.Xmlserialize<Config>(@"config.xml", con);
        }

        public string sha_265_protect(string data)
        {
            SHA256 sha = new SHA256Managed();
            byte[] hash = sha.ComputeHash(Encoding.ASCII.GetBytes(data));
            StringBuilder stringBuilder = new StringBuilder();
            foreach (byte b in hash)
            {
                stringBuilder.AppendFormat("{0:x2}", b);
            }
            return stringBuilder.ToString();
        }

        private void PinLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form _login = new Login();
            _login.ShowDialog();
        }
    }
}
