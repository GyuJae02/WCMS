using System;
using log4net;
using MetroFramework;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace Wato_Commuting_management
{
    public partial class Setting : MetroFramework.Forms.MetroForm
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Setting));

        public Setting()
        {
            InitializeComponent();
        }

        private void Setting_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            if (MetroMessageBox.Show(this, $"정말 삭제 하시겠습니까?", "삭제 알림", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                try
                {
                    using (MySqlConnection conn = new MySqlConnection(DB_info_xml.db_info))
                    {
                        conn.Open();
                        string sql = $"DELETE FROM commuting_history_tb WHERE name = '{Login.name}'";
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
                    MetroMessageBox.Show(this, $"근태 내역을 삭제하지 못했습니다.", "오류 알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    log.Error($"An exception occurred from {MethodBase.GetCurrentMethod().Name}", ex);
                    return;
                }

                MetroMessageBox.Show(this, $"근태 내역을 삭제했습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void VacDelmetroTile_Click(object sender, EventArgs e)
        {
            if (MetroMessageBox.Show(this, $"정말 삭제 하시겠습니까?", "삭제 알림", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                try
                {
                    using (MySqlConnection conn = new MySqlConnection(DB_info_xml.db_info))
                    {
                        conn.Open();
                        string sql = $"DELETE FROM vacation_tb WHERE name = '{Login.name}'";
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
                    MetroMessageBox.Show(this, $"휴가 내역을 삭제하지 못했습니다.", "오류 알림 ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    log.Error($"An exception occurred from {MethodBase.GetCurrentMethod().Name}", ex);
                    return;
                }

                MetroMessageBox.Show(this, $"휴가 내역을 삭제했습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void MemoDelmetroTile_Click(object sender, EventArgs e)
        {
            if (MetroMessageBox.Show(this, $"정말 삭제 하시겠습니까?", "삭제 알림", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                try
                {
                    using (MySqlConnection conn = new MySqlConnection(DB_info_xml.db_info))
                    {
                        conn.Open();
                        string sql = $"UPDATE user_tb SET memo = '' WHERE name = '{Login.name}'";
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
                    MetroMessageBox.Show(this, $"메모 데이터를 삭제하지 못했습니다.", "오류 알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    log.Error($"An exception occurred from {MethodBase.GetCurrentMethod().Name}", ex);
                    return;
                }

                MetroMessageBox.Show(this, $"메모 데이터를 삭제했습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void MyinfoDelmetroTile_Click(object sender, EventArgs e)
        {
            if (MetroMessageBox.Show(this, $"정말 삭제 하시겠습니까?", "삭제 알림", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                if (MetroMessageBox.Show(this, $"회원 정보 및 모든 데이터가 삭제됩니다.", "삭제 알림", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    try
                    {
                        using (MySqlConnection conn = new MySqlConnection(DB_info_xml.db_info))
                        {
                            conn.Open();
                            string sql = $"DELETE FROM commuting_history_tb WHERE name = '{Login.name}'";
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
                        MetroMessageBox.Show(this, $"근태 내역을 삭제하지 못했습니다.", "오류 알림 ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        log.Error($"An exception occurred from {MethodBase.GetCurrentMethod().Name}", ex);
                        return;
                    }

                    try
                    {
                        using (MySqlConnection conn = new MySqlConnection(DB_info_xml.db_info))
                        {
                            conn.Open();
                            string sql = $"DELETE FROM vacation_tb WHERE name = '{Login.name}'";
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
                        MetroMessageBox.Show(this, $"삭제하지 못했습니다.", "오류 알림 ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        log.Error($"An exception occurred from {MethodBase.GetCurrentMethod().Name}", ex);
                        return;
                    }

                    try
                    {
                        using (MySqlConnection conn = new MySqlConnection(DB_info_xml.db_info))
                        {
                            conn.Open();
                            string sql = $"UPDATE user_tb SET memo = '' WHERE name = '{Login.name}'";
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
                        MetroMessageBox.Show(this, $"메모 데이터를 삭제하지 못했습니다.", "오류 알림 ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        log.Error($"An exception occurred from {MethodBase.GetCurrentMethod().Name}", ex);
                        return;
                    }

                    try
                    {
                        using (MySqlConnection conn = new MySqlConnection(DB_info_xml.db_info))
                        {
                            conn.Open();
                            string sql = $"DELETE FROM user_tb WHERE name = '{Login.name}'";
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
                        MetroMessageBox.Show(this, $"유저 데이터를 삭제하지 못했습니다.", "오류 알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        log.Error($"An exception occurred from {MethodBase.GetCurrentMethod().Name}", ex);
                        return;
                    }

                    MetroMessageBox.Show(this, $"유저 데이터 및 모든 데이터를 삭제했습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    Environment.Exit(0);
                }
            }
        }

        private void OkmetroButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
