using System;
using log4net;
using System.Net;
using System.Drawing;
using MetroFramework;
using System.Threading;
using System.Reflection;
using System.Net.Sockets;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Wato_Commuting_management
{
    public partial class Staffinfo : MetroFramework.Forms.MetroForm
    {
        Main _main = null;

        private static readonly ILog log = LogManager.GetLogger(typeof(Staffinfo));

        public Staffinfo(Main main)
        {
            InitializeComponent();

            this._main = main;

            listboxstyle();
        }

        public void listboxstyle()
        {
            online_check_listView.View = View.Details;
            online_check_listView.FullRowSelect = true;

            online_check_listView.Columns.Add("이름", 70);
            online_check_listView.Columns.Add("상태", 50);

            DataAddToList();
        }

        private void DataAddToList()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(DB_info_xml.db_info))
                {
                    conn.Open();
                    string sql = $"SELECT * FROM user_tb";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    MySqlDataReader rdr = cmd.ExecuteReader();
                    online_check_listView.BeginUpdate();
                    ListViewItem[] lvi = new ListViewItem[100];
                    int lvi_count = 0;

                    while (rdr.Read())
                    {
                        lvi[lvi_count] = new ListViewItem(rdr["name"].ToString());
                        lvi[lvi_count].SubItems.Add(rdr["online_check"].ToString());
                        lvi[lvi_count].ImageIndex = 0;

                        online_check_listView.Items.Add(lvi[lvi_count]);
                        online_check_listView.EndUpdate();
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

        private void MyinfoOkbutton_Click(object sender, EventArgs e)
        {
            _main.Staffinfobutton1.BackColor = Color.SkyBlue;
            this.Visible = false;
        }

        private void MailCopymetroButton1_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(Maillabel2.Text);
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, "복사할 값이 없습니다.", "오류 알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
                log.Error($"An exception occurred from {MethodBase.GetCurrentMethod().Name}", ex);
            }
        }

        private void online_check_listView_MouseClick(object sender, MouseEventArgs e)
        {
            if (online_check_listView.SelectedItems.Count == 1)
            {
                string _staffname = "";
                string _staffposition = "";
                string _staffmail = "";
                string _staffonline_check = "";

                try
                {
                    using (MySqlConnection conn = new MySqlConnection(DB_info_xml.db_info))
                    {
                        conn.Open();
                        string sql = $"SELECT * FROM user_tb WHERE name = '{online_check_listView.SelectedItems[0].Text}'";
                        MySqlCommand cmd = new MySqlCommand(sql, conn);
                        MySqlDataReader rdr = cmd.ExecuteReader();
                        while (rdr.Read())
                        {
                            _staffname = rdr["name"].ToString();
                            _staffposition = rdr["position"].ToString();
                            _staffmail = rdr["mail"].ToString();
                            _staffonline_check = rdr["online_check"].ToString();
                        }
                        rdr.Close();
                        log.Info($"{sql}");

                        namelabel2.Text = _staffname;
                        Positionlabel2.Text = _staffposition;
                        Maillabel2.Text = _staffmail;
                        Onlinechecklabel2.Text = _staffonline_check;
                    }
                }
                catch (Exception ex)
                {
                    log.Error($"An exception occurred from {MethodBase.GetCurrentMethod().Name}", ex);
                    return;
                }
            }
        }

        private void Staffinfo_FormClosed(object sender, FormClosedEventArgs e)
        {
            _main.Staffinfobutton1.BackColor = Color.SkyBlue;
        }

        private void Chat_send_Button_Click(object sender, EventArgs e)
        {
            string date_now = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            try
            {
                using (MySqlConnection conn = new MySqlConnection(DB_info_xml.db_info))
                {
                    conn.Open();
                    string sql = $"INSERT INTO chat_tb VALUES ('{Chat_id_add()}', '{Login.name}', '{date_now}', '{Chat_send_textBox.Text}')";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    MySqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {

                    }
                    rdr.Close();
                    log.Info($"{sql}");
                }

                Chat_send_textBox.Text = "";
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, $"채팅을 전송에 실패했습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
                log.Error($"An exception occurred from {MethodBase.GetCurrentMethod().Name}", ex);
                return;
            }
        }

        private string Chat_id_add()
        {
            string date_key = $"{DateTime.Now.ToString("yyyyMMddHHmmss")}{Login.name}";
            return date_key;
        }
    }
}
