using System;
using log4net;
using MySql.Data.MySqlClient;
using System.Reflection;
using System.Configuration;
using System.Windows.Forms;
using MetroFramework;

namespace Wato_Commuting_management
{
    public partial class StaffVachistory : MetroFramework.Forms.MetroForm
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(StaffVachistory));

        public StaffVachistory()
        {
            InitializeComponent();

            dateTimePicker1.Value = DateTime.Now.AddYears(-1);

            #region style
            this.Okbutton.FlatStyle = FlatStyle.Flat;
            this.Okbutton.FlatAppearance.BorderSize = 0;
            #endregion

            listboxstyle();
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
                    string sql = $"SELECT * FROM vacation_tb";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    MySqlDataReader rdr = cmd.ExecuteReader();
                    historylistView.BeginUpdate();
                    ListViewItem[] lvi = new ListViewItem[364];
                    int lvi_count = 0;

                    while (rdr.Read())
                    {
                        lvi[lvi_count] = new ListViewItem(rdr["name"].ToString());
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

        private void datesearchbutton_Click(object sender, EventArgs e)
        {
            historylistView.Items.Clear();

            try
            {
                using (MySqlConnection conn = new MySqlConnection(DB_info_xml.db_info))
                {
                    conn.Open();
                    string sql = $"select * from vacation_tb where vac_date between DATE('{dateTimePicker1.Value.ToString("yyyy-MM-dd")}') and " +
                        $"DATE('{dateTimePicker2.Value.ToString("yyyy-MM-dd")}')+1";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    MySqlDataReader rdr = cmd.ExecuteReader();
                    ListViewItem[] lvi = new ListViewItem[100];
                    int lvi_count = 0;

                    while (rdr.Read())
                    {
                        lvi[lvi_count] = new ListViewItem(rdr["name"].ToString());
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
