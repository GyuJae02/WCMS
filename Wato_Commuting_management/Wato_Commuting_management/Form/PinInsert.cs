using System;
using log4net;
using System.Text;
using MetroFramework;
using System.Reflection;
using System.Windows.Forms;
using System.Configuration;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;

namespace Wato_Commuting_management
{
    public partial class PinInsert : MetroFramework.Forms.MetroForm
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(PinInsert));

        public PinInsert()
        {
            InitializeComponent();
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
            if (Pinlabel.Text.Length > 4)
            {
                MetroMessageBox.Show(this, "핀은 4자리를 초과할 수 없습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Pinlabel.Text.Length < 4)
            {
                MetroMessageBox.Show(this, "핀은 4자리보다 작을 수 없습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Pinlabel.Text == "0000" || Pinlabel.Text == "1111" || Pinlabel.Text == "2222" || Pinlabel.Text == "3333" || Pinlabel.Text == "4444" || Pinlabel.Text == "5555"
                || Pinlabel.Text == "6666" || Pinlabel.Text == "7777" || Pinlabel.Text == "8888" || Pinlabel.Text == "9999")
            {
                MetroMessageBox.Show(this,"사용하실 수 없습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    using (MySqlConnection conn = new MySqlConnection(DB_info_xml.db_info))
                    {
                        conn.Open();
                        string sql = $"UPDATE USER_tb SET pin_pw = '{sha_265_protect(Pinlabel.Text)}' WHERE NAME = '{Login.name}'";
                        MySqlCommand cmd = new MySqlCommand(sql, conn);
                        MySqlDataReader rdr = cmd.ExecuteReader();
                        while (rdr.Read())
                        {

                        }
                        rdr.Close();
                        log.Info($"{sql}");
                    }
                }
                catch (Exception ex)
                {
                    MetroMessageBox.Show(this, $"핀을 등록하지 못했습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    log.Error($"An exception occurred from {MethodBase.GetCurrentMethod().Name}", ex);
                    return;
                }

                MetroMessageBox.Show(this, $"핀을 등록했습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Visible = false;
            }
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
    }
}
