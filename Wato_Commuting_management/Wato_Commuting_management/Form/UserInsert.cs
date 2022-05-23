using System;
using log4net;
using System.Reflection;
using System.Windows.Forms;
using System.Configuration;
using MySql.Data.MySqlClient;
using MetroFramework;

namespace Wato_Commuting_management
{
    public partial class UserInsert : MetroFramework.Forms.MetroForm
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(UserInsert));

        public UserInsert()
        {
            InitializeComponent();
        }

        private void Okbutton_Click(object sender, EventArgs e)
        {
            if (usertextbox.Text == null || usertextbox.Text == "" || usertextbox.Text == " " || positiontextBox.Text == null || positiontextBox.Text == "" || positiontextBox.Text == " ")
            {
                MetroMessageBox.Show(this, "성함과 직급을 입력하세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    using (MySqlConnection conn = new MySqlConnection(DB_info_xml.db_info))
                    {
                        conn.Open();
                        string sql = $"INSERT INTO user_tb VALUES ('{usertextbox.Text}', '{positiontextBox.Text}', '15', '', '', 'offline', 'user', '')";
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
                    MetroMessageBox.Show(this, $"{usertextbox.Text} {positiontextBox.Text}님을 등록하지 못했습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    log.Error($"An exception occurred from {MethodBase.GetCurrentMethod().Name}", ex);
                    return;
                }

                MetroMessageBox.Show(this, $"{usertextbox.Text} {positiontextBox.Text}님을 등록했습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();
            }
        }
    }
}
