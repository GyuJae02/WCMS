using System;
using log4net;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using System.Reflection;

namespace Wato_Commuting_management
{
    public partial class forum : MetroFramework.Forms.MetroForm
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(forum));

        public forum()
        {
            InitializeComponent();
            
            SetHeight(forumListView, 50);

            listboxstyle();
        }

        private void SetHeight(ListView LV, int height)
        {
            ImageList imgList = new ImageList();
            imgList.ImageSize = new Size(1, height);
            LV.SmallImageList = imgList;
        }

        public void listboxstyle()
        {
            forumListView.View = View.Details;
            forumListView.FullRowSelect = true;

            forumListView.Columns.Add("타입", 40, HorizontalAlignment.Center);
            forumListView.Columns.Add("제목", 300, HorizontalAlignment.Center);
            forumListView.Columns.Add("작성자", 100, HorizontalAlignment.Center);
            forumListView.Columns.Add("작성일", 200, HorizontalAlignment.Center);
            forumListView.Columns.Add("수정일", 200, HorizontalAlignment.Center);

            DataAddToList();
        }

        private void DataAddToList()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(DB_info_xml.db_info))
                {
                    conn.Open();
                    string sql = $"SELECT * FROM forum_tb";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    MySqlDataReader rdr = cmd.ExecuteReader();
                    ListViewItem[] lvi = new ListViewItem[100];
                    int lvi_count = 0;

                    while (rdr.Read())
                    {
                        lvi[lvi_count] = new ListViewItem(rdr["type"].ToString());
                        lvi[lvi_count].SubItems.Add(rdr["title"].ToString());
                        lvi[lvi_count].SubItems.Add(rdr["name"].ToString());
                        lvi[lvi_count].SubItems.Add(rdr["create date"].ToString());
                        string lastdatecheck = rdr["last_revised_date"].ToString();

                        if (lastdatecheck == "0001-01-01 오전 12:00:00")
                        {
                            lvi[lvi_count].SubItems.Add("null");
                        }
                        else
                        {
                            lvi[lvi_count].SubItems.Add(rdr["last_revised_date"].ToString());
                        }
                        lvi[lvi_count].ImageIndex = 0;

                        forumListView.Items.Add(lvi[lvi_count]);
                        forumListView.EndUpdate();
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

        private void addButton_Click(object sender, EventArgs e)
        {
            Form _forumadd = new forumadd(this);
            _forumadd.ShowDialog();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (forumListView.SelectedItems.Count != 0)
            {
                int SelectRow = forumListView.SelectedItems[0].Index;
                string titleselectdate = forumListView.Items[SelectRow].SubItems[1].Text;
                string nameselectdate = forumListView.Items[SelectRow].SubItems[2].Text;

                if (nameselectdate != Login.name)
                {
                    MetroMessageBox.Show(this, $"삭제 권한이 없습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string pkdate = $"{titleselectdate} {nameselectdate}";

                try
                {
                    using (MySqlConnection conn = new MySqlConnection(DB_info_xml.db_info))
                    {
                        conn.Open();
                        string sql = $"DELETE FROM forum_tb WHERE pk = '{pkdate}'";
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

                MetroMessageBox.Show(this, $"선택한 글을 삭제했습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                forumListView.Items[SelectRow].Remove();

                refreshForum();
            }
            else
            {
                MetroMessageBox.Show(this, "삭제할 글을 선택하세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (forumListView.SelectedItems.Count != 0)
            {
                int SelectRow = forumListView.SelectedItems[0].Index;
                string nameselectdate = forumListView.Items[SelectRow].SubItems[2].Text;

                if (nameselectdate != Login.name)
                {
                    MetroMessageBox.Show(this, $"수정 권한이 없습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Form _forumadd = new forumadd(this, "1");
                _forumadd.ShowDialog();
            }
            else
            {
                MetroMessageBox.Show(this, "수정할 글을 선택하세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void refreshForum()
        {
            forumListView.Items.Clear();

            try
            {
                using (MySqlConnection conn = new MySqlConnection(DB_info_xml.db_info))
                {
                    conn.Open();
                    string sql = $"SELECT * FROM forum_tb";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    MySqlDataReader rdr = cmd.ExecuteReader();
                    ListViewItem[] lvi = new ListViewItem[100];
                    int lvi_count = 0;

                    while (rdr.Read())
                    {
                        lvi[lvi_count] = new ListViewItem(rdr["type"].ToString());
                        lvi[lvi_count].SubItems.Add(rdr["title"].ToString());
                        lvi[lvi_count].SubItems.Add(rdr["name"].ToString());
                        lvi[lvi_count].SubItems.Add(rdr["create date"].ToString());
                        string lastdatecheck = rdr["last_revised_date"].ToString();

                        if (lastdatecheck == "0001-01-01 오전 12:00:00")
                        {
                            lvi[lvi_count].SubItems.Add("null");
                        }
                        else
                        {
                            lvi[lvi_count].SubItems.Add(rdr["last_revised_date"].ToString());
                        }
                        lvi[lvi_count].ImageIndex = 0;

                        forumListView.Items.Add(lvi[lvi_count]);
                        forumListView.EndUpdate();
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

        private void forumListView_DoubleClick(object sender, EventArgs e)
        {
            Form _forumdetails = new forumdetails(this);
            _forumdetails.ShowDialog();
        }
    }
}
