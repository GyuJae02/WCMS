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
    public partial class Main : MetroFramework.Forms.MetroForm
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Main));

        Double _vac_check_select = 0;

        public Main()
        {
            InitializeComponent();

            #region main button style
            //this.Commutingcehckbutton.FlatStyle = FlatStyle.Flat;
            //this.Commutingcehckbutton.FlatAppearance.BorderSize = 0;
            #endregion

            string[] data = { "온라인", "자리비움", "오프라인"};
            onlinecheckcomboBox.Items.AddRange(data);
            OnlineUpdate();
            online_check_select();
            this.onlinecheckcomboBox.SelectedIndexChanged += onlinecheckcomboBox_SelectedIndexChanged;

            dateLabel.Text = DateTime.Now.ToString("yyyy-MM-dd (ddd)");
            namelabel.Text = $"{Login.name} {Login.position}님 환영합니다.";
        }

        public void online_check_select()
        {
            string _online_check_select = "";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(DB_info_xml.db_info))
                {
                    conn.Open();
                    string sql = $"SELECT * FROM user_tb WHERE name = '{Login.name}';";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    MySqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        _online_check_select = rdr["online_check"].ToString();
                        _vac_check_select = Convert.ToDouble(rdr["vacation_count"].ToString());
                    }
                    rdr.Close();
                    log.Info($"{sql}");
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, $"조회에 실패했습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
                log.Error($"An exception occurred from {MethodBase.GetCurrentMethod().Name}", ex);
            }

            if (_online_check_select == "online")
            {
                onlinecheckcomboBox.SelectedIndex = 0;
                onlinecheckpanel.BackColor = Color.Green;
            }
            else if (_online_check_select == "away")
            {
                onlinecheckcomboBox.SelectedIndex = 1;
                onlinecheckpanel.BackColor = Color.Gold;
            }
            else if (_online_check_select == "offline")
            {
                onlinecheckcomboBox.SelectedIndex = 2;
                onlinecheckpanel.BackColor = Color.Gray;
            }
        }

        public void onlinecheckcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ko_to_en = "";

            if (onlinecheckcomboBox.SelectedItem.ToString() == "온라인")
            {
                onlinecheckpanel.BackColor = Color.Green;
                ko_to_en = "online";
            }
            else if (onlinecheckcomboBox.SelectedItem.ToString() == "자리비움")
            {
                onlinecheckpanel.BackColor = Color.Gold;
                ko_to_en = "away";
            }
            else if (onlinecheckcomboBox.SelectedItem.ToString() == "오프라인")
            {
                onlinecheckpanel.BackColor = Color.Gray;
                ko_to_en = "offline";
            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection(DB_info_xml.db_info))
                {
                    conn.Open();
                    string sql = $"UPDATE user_tb SET online_check = '{ko_to_en}' WHERE name = '{Login.name}'";
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
                MetroMessageBox.Show(this, $"상태를 변경하지 못했습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
                log.Error($"An exception occurred from {MethodBase.GetCurrentMethod().Name}", ex);
                return;
            }
        }

        private void OnlineUpdate()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(DB_info_xml.db_info))
                {
                    conn.Open();
                    string sql = $"UPDATE user_tb SET online_check = 'online' WHERE name = '{Login.name}'";
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
                MetroMessageBox.Show(this, $"상태를 변경하지 못했습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
                log.Error($"An exception occurred from {MethodBase.GetCurrentMethod().Name}", ex);
                return;
            }
        }

        private void OfflineUpdate()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(DB_info_xml.db_info))
                {
                    conn.Open();
                    string sql = $"UPDATE user_tb SET online_check = 'offline' WHERE name = '{Login.name}'";
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
                MetroMessageBox.Show(this, $"상태를 변경하지 못했습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
                log.Error($"An exception occurred from {MethodBase.GetCurrentMethod().Name}", ex);
                return;
            }
        }


        private void Logoutbutton_Click(object sender, EventArgs e)
        {
            Memobutton.BackColor = Color.SteelBlue;
            Form _memo = new Memo(this);
            _memo.ShowDialog();
        }

        private void Commutingcehckbutton_Click(object sender, EventArgs e)
        {
            if (Attendancebutton.Visible == false)
            {
                Commutingcehckbutton.BackColor = Color.SteelBlue;
                Attendancebutton.Visible = true;
                Leaveworkbutton.Visible = true;
                historybutton.Visible = true;
                Commutinglabel.Visible = true;
            }
            else  if (Attendancebutton.Visible == true)
            {
                Commutingcehckbutton.BackColor = Color.SkyBlue;
                Attendancebutton.Visible = false;
                Leaveworkbutton.Visible = false;
                historybutton.Visible = false;
                Commutinglabel.Visible = false;
            }

            string _date_key = "";
            string _attendance = "";
            string _leave_work = "";

            using (MySqlConnection conn = new MySqlConnection(DB_info_xml.db_info))
            {
                conn.Open();
                string sql = $"SELECT * FROM commuting_history_tb WHERE date_key = '{Date_key_check()}'";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    _date_key = rdr["date_key"].ToString();
                    _attendance = rdr["attendance"].ToString();
                    _leave_work = rdr["leave_work"].ToString();
                }
                rdr.Close();
                log.Info($"{sql}");
            }

            if (_attendance == "")
            {
                Attendancebutton.Enabled = true;
                Commutinglabel.Text = "현재 근무 중이 아닙니다.";
            }
            else if (_attendance != "0001-01-01 오전 12:00:00")
            {
                Attendancebutton.Enabled = false;
                Commutinglabel.Text = "현재 근무 중 입니다.";
            }

            if (_leave_work == "")
            {
                Leaveworkbutton.Enabled = true;
            }
            else if (_leave_work != "0001-01-01 오전 12:00:00")
            {
                Leaveworkbutton.Enabled = false;
                Commutinglabel.Text = "현재 근무 중이 아닙니다.";
            }
        }
        private void Attendancebutton_Click(object sender, EventArgs e)
        {
            string date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            try
            {
                using (MySqlConnection conn = new MySqlConnection(DB_info_xml.db_info))
                {
                    conn.Open();
                    string sql = $"INSERT INTO commuting_history_tb VALUES ('{Date_key_check()}', '{Login.name}', '{date}', '0000-00-00 00:00:00')";
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
                MetroMessageBox.Show(this, $"출근을 등록하지 못했습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
                log.Error($"An exception occurred from {MethodBase.GetCurrentMethod().Name}", ex);
                return;
            }

            Attendancebutton.Enabled = false;
            MetroMessageBox.Show(this, $"{DateTime.Now.ToString("HH:mm")}\n출근 등록 되었습니다.", "출근 알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Commutinglabel.Text = "현재 근무 중 입니다.";
        }

        private void Leaveworkbutton_Click(object sender, EventArgs e)
        {
            string date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            try
            {
                using (MySqlConnection conn = new MySqlConnection(DB_info_xml.db_info))
                {
                    conn.Open();
                    string sql = $"UPDATE commuting_history_tb SET leave_work = '{date}' WHERE date_key = '{Date_key_check()}'";
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
                MetroMessageBox.Show(this, $"퇴근을 등록하지 못했습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
                log.Error($"An exception occurred from {MethodBase.GetCurrentMethod().Name}", ex);
                return;
            }

            Leaveworkbutton.Enabled = false;
            MetroMessageBox.Show(this, $"{DateTime.Now.ToString("HH:mm")}\n퇴근 등록 되었습니다.", "퇴근 알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Commutinglabel.Text = "현재 근무 중이 아닙니다.";
        }

        private void historybutton_Click(object sender, EventArgs e)
        {
            Form _commuting_history = new Commuting_history();
            _commuting_history.ShowDialog();
        }

        private string Date_key_check()
        {
            string date_key = $"{DateTime.Now.ToString("yyyyMMdd")}{Login.name}";
            return date_key;
        }

        private void Myinfobutton_Click(object sender, EventArgs e)
        {
            Myinfobutton.BackColor = Color.SteelBlue;
            Form _myinfo = new Myinfo(this);
            _myinfo.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Staffinfobutton1.BackColor = Color.SteelBlue;
            Form _staffinfo = new Staffinfo(this);
            _staffinfo.ShowDialog();
        }

        private void Vacationbutton_Click(object sender, EventArgs e)
        {
            if (Calendar.Visible == false)
            {
                Vacationbutton.BackColor = Color.SteelBlue;
                Calendar.Visible = true;
                Ban_button.Visible = true;
                Eon_button.Visible = true;
                Vacselectbutton.Visible = true;
                StaffVacselectbutton.Visible = true;
            }
            else
            {
                Vacationbutton.BackColor = Color.SkyBlue;
                Calendar.Visible = false;
                Ban_button.Visible = false;
                Eon_button.Visible = false;
                Vacselectbutton.Visible = false;
                StaffVacselectbutton.Visible = false;
            }
        }        

        private void button1_Click(object sender, EventArgs e)
        {
            string[] click_date = Calendar.SelectionStart.ToString().Split('\'', ' ');

            if (MetroMessageBox.Show(this, $"{click_date[0]} 에 반차를 등록할까요?", "등록 알림", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                online_check_select();
                try
                {
                    using (MySqlConnection conn = new MySqlConnection(DB_info_xml.db_info))
                    {
                        conn.Open();
                        string sql = $"INSERT INTO vacation_tb VALUES ('{click_date[0]}{Login.name}', '{Login.name}', '반차', '{click_date[0]}')";
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
                    MetroMessageBox.Show(this, $"반차를 등록하지 못했습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    log.Error($"An exception occurred from {MethodBase.GetCurrentMethod().Name}", ex);
                    return;
                }

                try
                {
                    using (MySqlConnection conn = new MySqlConnection(DB_info_xml.db_info))
                    {
                        conn.Open();
                        string sql = $"UPDATE user_tb SET vacation_count = '{_vac_check_select - 0.5}' WHERE name = '{Login.name}'";
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
                    MetroMessageBox.Show(this, "휴가 일수를 반영하지 못했습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    log.Error($"An exception occurred from {MethodBase.GetCurrentMethod().Name}", ex);
                    return;
                }

                MetroMessageBox.Show(this, "반차. 등록이 완료 되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Date_key_check();

            string[] click_date = Calendar.SelectionStart.ToString().Split('\'', ' ');

            if (MetroMessageBox.Show(this, $"{click_date[0]} 에 연차를 등록할까요?", "등록 알림", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                online_check_select();

                try
                {
                    using (MySqlConnection conn = new MySqlConnection(DB_info_xml.db_info))
                    {
                        conn.Open();
                        string sql = $"INSERT INTO vacation_tb VALUES ('{click_date[0]}{Login.name}', '{Login.name}', '연차', '{click_date[0]}')";
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
                    MetroMessageBox.Show(this, $"연차를 등록하지 못했습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    log.Error($"An exception occurred from {MethodBase.GetCurrentMethod().Name}", ex);
                    return;
                }

                try
                {
                    using (MySqlConnection conn = new MySqlConnection(DB_info_xml.db_info))
                    {
                        conn.Open();
                        string sql = $"UPDATE user_tb SET vacation_count = '{_vac_check_select - 1}' WHERE name = '{Login.name}'";
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
                    MetroMessageBox.Show(this, $"휴가일수를 반영하지 못했습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    log.Error($"An exception occurred from {MethodBase.GetCurrentMethod().Name}", ex);
                    return;
                }

                MetroMessageBox.Show(this, "연차 등록이 완료 되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form _Vachistory = new Vachistory();
            _Vachistory.ShowDialog();
        }

        private void settingpictureBox_Click(object sender, EventArgs e)
        {
            Form _setting = new Setting();
            _setting.ShowDialog();
        }

        private void StaffVacselectbutton_Click(object sender, EventArgs e)
        {
            Form _staffVachistory = new StaffVachistory();
            _staffVachistory.ShowDialog();
        }

        private void ExitButton2_Click(object sender, EventArgs e)
        {
            OfflineUpdate();
            Environment.Exit(0);
        }

        private void ForumButton_Click(object sender, EventArgs e)
        {
            Form _forum = new forum();
            _forum.ShowDialog();
        }
    }
}
