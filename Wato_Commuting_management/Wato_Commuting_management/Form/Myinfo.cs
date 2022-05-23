using System;
using log4net;
using System.Text;
using System.Drawing;
using MetroFramework;
using System.Reflection;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;

namespace Wato_Commuting_management
{
    public partial class Myinfo : MetroFramework.Forms.MetroForm
    {
        Main _main = null;

        private static readonly ILog log = LogManager.GetLogger(typeof(Myinfo));

        public Myinfo(Main main)
        {
            InitializeComponent();

            this._main = main;

            namelabel2.Text = Login.name;
            Positionlabel2.Text = Login.position;
            Maillabel2.Text = Login.mail;
            Pinlabel2.Text = PinLogin.de_pw;
        }

        private void Myinfo_Load(object sender, EventArgs e)
        {

        }

        private void MyinfoUpdatebutton_Click(object sender, EventArgs e)
        {
            if (Pinlabel2.Text.Length > 4)
            {
                MetroMessageBox.Show(this, "핀은 4자리를 초과할 수 없습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Pinlabel2.Text.Length < 4)
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
                        string sql = $"UPDATE USER_tb SET position = '{Positionlabel2.Text}', mail = '{Maillabel2.Text}', pin_pw = '{sha_265_protect(Pinlabel2.Text)}' WHERE NAME = '{Login.name}'";
                        MySqlCommand cmd = new MySqlCommand(sql, conn);
                        MySqlDataReader rdr = cmd.ExecuteReader();
                        while (rdr.Read())
                        {

                        }
                        rdr.Close();
                        log.Info($"{sql}");
                    }

                    PinLogin.de_pw = Pinlabel2.Text;
                }
                catch (Exception ex)
                {
                    MetroMessageBox.Show(this, $"{Login.name} {Login.position}님의 정보를 수정하지 못했습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    log.Error($"An exception occurred from {MethodBase.GetCurrentMethod().Name}", ex);
                    return;
                }

                MetroMessageBox.Show(this, $"{Login.name} {Login.position}님의 정보를 수정했습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void MyinfoOkbutton_Click(object sender, EventArgs e)
        {
            _main.Myinfobutton.BackColor = Color.SkyBlue;
            this.Visible = false;
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

        private void Myinfo_FormClosed(object sender, FormClosedEventArgs e)
        {
            _main.Myinfobutton.BackColor = Color.SkyBlue;
        }
    }
}
