using System;
using log4net;
using System.Reflection;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MetroFramework;
using Microsoft.WindowsAPICodePack.Dialogs;
using System.Text;
using System.Collections.Generic;

namespace Wato_Commuting_management
{
    public partial class Commuting_history : MetroFramework.Forms.MetroForm
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Commuting_history));

        public Commuting_history()
        {
            InitializeComponent();

            dateTimePicker1.Value = DateTime.Now.AddMonths(-1);

            listboxstyle();
        }

        public void listboxstyle()
        {
            historylistView1.View = View.Details; 
            historylistView1.FullRowSelect = true;

            historylistView1.Columns.Add("이름", 100);
            historylistView1.Columns.Add("날짜", 100);
            historylistView1.Columns.Add("출근시간", 100);
            historylistView1.Columns.Add("퇴근시간",100);

            DataAddToList();
        }

        private void DataAddToList()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(DB_info_xml.db_info))
                {
                    conn.Open();
                    string sql = $"SELECT * FROM commuting_history_tb WHERE Name = '{Login.name}'";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    MySqlDataReader rdr = cmd.ExecuteReader();
                    historylistView1.BeginUpdate();
                    ListViewItem[] lvi = new ListViewItem[100];
                    int lvi_count = 0;

                    while (rdr.Read())
                    {
                        lvi[lvi_count] = new ListViewItem(Login.name);
                        string[] _at_splite = rdr["attendance"].ToString().Split('\'', ' ');
                        string[] _le_splite = rdr["leave_work"].ToString().Split('\'', ' ');

                        lvi[lvi_count].SubItems.Add(_at_splite[0]);
                        lvi[lvi_count].SubItems.Add($"{_at_splite[1]} {_at_splite[2]}");

                        if (_le_splite[2] == "12:00:00")
                        {
                            lvi[lvi_count].SubItems.Add("null");
                        }
                        else
                        {
                            lvi[lvi_count].SubItems.Add($"{_le_splite[1]} {_le_splite[2]}");
                        }
                        lvi[lvi_count].ImageIndex = 0;

                        historylistView1.Items.Add(lvi[lvi_count]);
                        historylistView1.EndUpdate();
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (historylistView1.SelectedItems.Count != 0)
            {
                int SelectRow = historylistView1.SelectedItems[0].Index;
                string selectdate = historylistView1.Items[SelectRow].SubItems[1].Text;

                string repdate = selectdate.Replace("-", "");

                string pkdate = $"{repdate}{Login.name}";

                try
                {
                    using (MySqlConnection conn = new MySqlConnection(DB_info_xml.db_info))
                    {
                        conn.Open();
                        string sql = $"DELETE FROM commuting_history_tb WHERE date_key = '{pkdate}'";
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
                historylistView1.Items[SelectRow].Remove();
            }
            else
            {
                MetroMessageBox.Show(this, "삭제할 아이템을 선택하세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void datesearchbutton_Click(object sender, EventArgs e)
        {
           historylistView1.Items.Clear();

            try
            {
                using (MySqlConnection conn = new MySqlConnection(DB_info_xml.db_info))
                {
                    conn.Open();
                    string sql = $"select * from commuting_history_tb where attendance between DATE('{dateTimePicker1.Value.ToString("yyyy-MM-dd")}') and " +
                        $"date('{dateTimePicker2.Value.ToString("yyyy-MM-dd")}')+1 AND NAME  = '{Login.name}'";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    MySqlDataReader rdr = cmd.ExecuteReader();
                    ListViewItem[] lvi = new ListViewItem[100];
                    int lvi_count = 0;

                    while (rdr.Read())
                    {
                        lvi[lvi_count] = new ListViewItem(Login.name);
                        string[] _at_splite = rdr["attendance"].ToString().Split('\'', ' ');
                        string[] _le_splite = rdr["leave_work"].ToString().Split('\'', ' ');

                        lvi[lvi_count].SubItems.Add(_at_splite[0]);
                        lvi[lvi_count].SubItems.Add($"{_at_splite[1]} {_at_splite[2]}");

                        if (_le_splite[2] == "12:00:00")
                        {
                            lvi[lvi_count].SubItems.Add("null");
                        }
                        else
                        {
                            lvi[lvi_count].SubItems.Add($"{_le_splite[1]} {_le_splite[2]}");
                        }
                        lvi[lvi_count].ImageIndex = 0;

                        historylistView1.Items.Add(lvi[lvi_count]);
                        historylistView1.EndUpdate();
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

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(DB_info_xml.db_info))
                {
                    List<string> list = new List<string>();
                    string str = null;
                    conn.Open();
                    string sql = $"SELECT * FROM commuting_history_tb WHERE Name = '{Login.name}'";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    MySqlDataReader rdr = cmd.ExecuteReader();
                    historylistView1.BeginUpdate();
                    ListViewItem[] lvi = new ListViewItem[100];
                    int lvi_count = 0;
                    
                    list.Add("날짜, 출근, 퇴근");
                    while (rdr.Read())
                    {
                        lvi[lvi_count] = new ListViewItem(Login.name);
                        string[] _at_splite = rdr["attendance"].ToString().Split('\'', ' ');
                        string[] _le_splite = rdr["leave_work"].ToString().Split('\'', ' ');

                        if (_le_splite[2] == "12:00:00")
                        {
                            list.Add($"{_at_splite[0]}, {_at_splite[1]} {_at_splite[2]}, null");
                        }
                        else
                        {
                            list.Add($"{_at_splite[0]}, {_at_splite[1]} {_at_splite[2]}, {_le_splite[1]} {_le_splite[2]}");
                        }
                        lvi[lvi_count].ImageIndex = 0;

                        ++lvi_count;
                    }
                    rdr.Close();
                    log.Info($"{sql}");

                    CommonOpenFileDialog dialog = new CommonOpenFileDialog();
                    dialog.IsFolderPicker = true;
                    if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
                    {
                        string savePath = $@"{dialog.FileName}\{Login.name} 출, 퇴근 기록 ({DateTime.Now.ToString("yyyy-MM-dd")}).csv";
                        System.IO.File.WriteAllText(savePath, string.Join(Environment.NewLine, list.ToArray()), Encoding.Default);

                        MetroMessageBox.Show(this, $"출, 퇴근 기록을 추출 했습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        System.Diagnostics.Process.Start(dialog.FileName);
                    }
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, "출, 퇴근 기록을 추출할 수 없습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
                log.Error($"An exception occurred from {MethodBase.GetCurrentMethod().Name}", ex);
            }
        }
    }
}
