using System;
using log4net;
using MetroFramework;
using System.Reflection;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Wato_Commuting_management
{
    public partial class Vachistory : MetroFramework.Forms.MetroForm
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Vachistory));

        private double _vac_count = 0;

        public Vachistory()
        {
            InitializeComponent();

            dateTimePicker1.Value = DateTime.Now.AddYears(-1);

            #region style
            this.Deletebutton.FlatStyle = FlatStyle.Flat;
            this.Deletebutton.FlatAppearance.BorderSize = 0;

            this.Okbutton.FlatStyle = FlatStyle.Flat;
            this.Okbutton.FlatAppearance.BorderSize = 0;
            #endregion

            VacCount();

            listboxstyle();
        }

        private void VacCount()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(DB_info_xml.db_info))
                {
                    conn.Open();
                    string sql = $"SELECT vacation_count FROM user_tb WHERE Name = '{Login.name}'";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    MySqlDataReader rdr = cmd.ExecuteReader();
                    historylistView.BeginUpdate();
                    ListViewItem[] lvi = new ListViewItem[364];

                    while (rdr.Read())
                    {
                        _vac_count = Convert.ToDouble(rdr["vacation_count"]);
                    }
                    rdr.Close();
                    log.Info($"{sql}");
                }

                Vaccountlabel.Text = $"잔여 : {_vac_count}일";
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, "잔여 휴가 수를 조회할 수 없습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
                log.Error($"An exception occurred from {MethodBase.GetCurrentMethod().Name}", ex);
            }
        }

        public void listboxstyle()
        {
            historylistView.View = View.Details;
            historylistView.FullRowSelect = true;

            historylistView.Columns.Add("이름", 100);
            historylistView.Columns.Add("종류", 100);
            historylistView.Columns.Add("날짜", 100);

            DataAddToList();
        }

        private void DataAddToList()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(DB_info_xml.db_info))
                {
                    conn.Open();
                    string sql = $"SELECT * FROM vacation_tb WHERE Name = '{Login.name}'";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    MySqlDataReader rdr = cmd.ExecuteReader();
                    historylistView.BeginUpdate();
                    ListViewItem[] lvi = new ListViewItem[100];
                    int lvi_count = 0;

                    while (rdr.Read())
                    {
                        lvi[lvi_count] = new ListViewItem(Login.name);
                        lvi[lvi_count].SubItems.Add(rdr["vac_type"].ToString());

                        string[] _at_splite = rdr["vac_date"].ToString().Split('\'', ' ');
                        lvi[lvi_count].SubItems.Add(_at_splite[0]);
                        lvi[lvi_count].ImageIndex = 0;

                        historylistView.Items.Add(lvi[lvi_count]);
                        historylistView.EndUpdate();
                        ++lvi_count;
                    }
                    rdr.Close();
                    log.Info($"{sql}");
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, "조회할 수 없습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
                log.Error($"An exception occurred from {MethodBase.GetCurrentMethod().Name}", ex);
            }
        }

        private void Okbutton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {
            if (historylistView.SelectedItems.Count != 0)
            {
                int SelectRow = historylistView.SelectedItems[0].Index;
                string selectdate = historylistView.Items[SelectRow].SubItems[2].Text;
                string vac_type = historylistView.Items[SelectRow].SubItems[1].Text;

                string pkdate = $"{selectdate}{Login.name}";

                try
                {
                    using (MySqlConnection conn = new MySqlConnection(DB_info_xml.db_info))
                    {
                        conn.Open();
                        string sql = $"DELETE FROM vacation_tb WHERE date_key = '{pkdate}'";
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
                    MetroMessageBox.Show(this, $"삭제하지 못했습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    log.Error($"An exception occurred from {MethodBase.GetCurrentMethod().Name}", ex);
                    return;
                }

                MetroMessageBox.Show(this, $"선택한 아이템을 삭제했습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                historylistView.Items[SelectRow].Remove();

                if (vac_type == "반차")
                {
                    try
                    {
                        using (MySqlConnection conn = new MySqlConnection(DB_info_xml.db_info))
                        {
                            conn.Open();
                            string sql = $"UPDATE user_tb SET vacation_count = '{_vac_count + 0.5}' WHERE name = '{Login.name}'";
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
                        MetroMessageBox.Show(this, $"잔여 휴가일수를 변경하지 못했습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        log.Error($"An exception occurred from {MethodBase.GetCurrentMethod().Name}", ex);
                        return;
                    }
                }
                else if (vac_type == "연차")
                {
                    try
                    {
                        using (MySqlConnection conn = new MySqlConnection(DB_info_xml.db_info))
                        {
                            conn.Open();
                            string sql = $"UPDATE user_tb SET vacation_count = '{_vac_count + 1}' WHERE name = '{Login.name}'";
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
                        MetroMessageBox.Show(this, $"잔여 휴가일수를 변경하지 못했습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        log.Error($"An exception occurred from {MethodBase.GetCurrentMethod().Name}", ex);
                        return;
                    }
                }
            }
            else
            {
                MetroMessageBox.Show(this,"삭제할 아이템을 선택하세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Deletebutton.Enabled = false;
        }

        private void oksearchbutton_Click(object sender, EventArgs e)
        {
            historylistView.Items.Clear();

            try
            {
                using (MySqlConnection conn = new MySqlConnection(DB_info_xml.db_info))
                {
                    conn.Open();
                    string sql = $"select * from vacation_tb where vac_date between DATE('{dateTimePicker1.Value.ToString("yyyy-MM-dd")}') and " +
                        $"DATE('{dateTimePicker2.Value.ToString("yyyy-MM-dd")}')+1 AND NAME  = '{Login.name}'";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    MySqlDataReader rdr = cmd.ExecuteReader();
                    ListViewItem[] lvi = new ListViewItem[100];
                    int lvi_count = 0;

                    while (rdr.Read())
                    {
                        lvi[lvi_count] = new ListViewItem(Login.name);
                        lvi[lvi_count].SubItems.Add(rdr["vac_type"].ToString());

                        string[] _at_splite = rdr["vac_date"].ToString().Split('\'', ' ');
                        lvi[lvi_count].SubItems.Add(_at_splite[0]);
                        lvi[lvi_count].ImageIndex = 0;

                        historylistView.Items.Add(lvi[lvi_count]);
                        historylistView.EndUpdate();
                        ++lvi_count;
                    }
                    rdr.Close();
                    log.Info($"{sql}");
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, "조회할 수 없습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
                log.Error($"An exception occurred from {MethodBase.GetCurrentMethod().Name}", ex);
            }
        }
    }
}
