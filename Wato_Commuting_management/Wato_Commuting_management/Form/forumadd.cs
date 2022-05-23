using System;
using log4net;
using MetroFramework;
using System.Reflection;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Wato_Commuting_management
{
    public partial class forumadd : MetroFramework.Forms.MetroForm
    {
        forum _forum;
        string _updatecheck;

        private static readonly ILog log = LogManager.GetLogger(typeof(forumadd));

        public forumadd(forum forum, string updatecheck)
        {
            InitializeComponent();
            this._forum = forum;

            _updatecheck = updatecheck;
            this.Text = "글 수정";
            typecheck();

            namemetroTextBox.Text = Login.name;
        }

        public forumadd(forum forum)
        {
            InitializeComponent();
            this._forum = forum;
            typemetroComboBox.SelectedIndex = 0;
            _updatecheck = "0";
            this.Text = "글 쓰기";            

            namemetroTextBox.Text = Login.name;
        }

        public void typecheck()
        {
            int SelectRow = _forum.forumListView.SelectedItems[0].Index;
            string typeselectdate = _forum.forumListView.Items[SelectRow].SubItems[0].Text;
            string titleselectdate = _forum.forumListView.Items[SelectRow].SubItems[1].Text;
            string nameselectdate = _forum.forumListView.Items[SelectRow].SubItems[2].Text;

            string pk = $"{titleselectdate} {nameselectdate}";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(DB_info_xml.db_info))
                {
                    conn.Open();
                    string sql = $"SELECT content FROM forum_tb WHERE pk = '{pk}'";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    MySqlDataReader rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        contentmetroTextBox.Text = rdr["content"].ToString();
                    }
                    rdr.Close();
                    log.Info($"{sql}");
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, "해당 게시글의 내용을 조회할 수 없습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
                log.Error($"An exception occurred from {MethodBase.GetCurrentMethod().Name}", ex);
            }

            titlemetroTextBox.Text = titleselectdate;

            if (typeselectdate == "일반")
            {
                typemetroComboBox.SelectedIndex = 0;
            }
            else
            {
                typemetroComboBox.SelectedIndex = 1;
            }
        }

        private void cancelbutton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
            //글 수정
            if (_updatecheck == "1")
            {
                int SelectRow = _forum.forumListView.SelectedItems[0].Index;
                string titleselectdate = _forum.forumListView.Items[SelectRow].SubItems[1].Text;
                string nameselectdate = _forum.forumListView.Items[SelectRow].SubItems[2].Text;

                string pkdate = $"{titleselectdate} {nameselectdate}";

                try
                {
                    using (MySqlConnection conn = new MySqlConnection(DB_info_xml.db_info))
                    {
                        conn.Open();
                        string sql = $"UPDATE forum_tb SET pk = '{titlemetroTextBox.Text} {namemetroTextBox.Text}', title = '{titlemetroTextBox.Text}', content = '{contentmetroTextBox.Text}', type = '{typemetroComboBox.SelectedItem.ToString()}', last_revised_date = '{DateTime.Now.ToString("yyyy-MM-dd H:mm:ss")}' WHERE pk = '{pkdate}'";
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
                    MetroMessageBox.Show(this, $"글을 수정하지 못했습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    log.Error($"An exception occurred from {MethodBase.GetCurrentMethod().Name}", ex);
                    return;
                }

                MetroMessageBox.Show(this, $"글을 수정했습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);

                _forum.refreshForum();

                this.Visible = false;
            }
            //글 작성
            else if (_updatecheck == "0")
            {
                if (titlemetroTextBox.Text == null || titlemetroTextBox.Text == "" || titlemetroTextBox.Text == " " || contentmetroTextBox.Text == null || contentmetroTextBox.Text == "" || contentmetroTextBox.Text == " ")
                {
                    MetroMessageBox.Show(this, "제목과 내용을 채워주세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        using (MySqlConnection conn = new MySqlConnection(DB_info_xml.db_info))
                        {
                            conn.Open();
                            string sql = $"INSERT INTO forum_tb VALUES ('{titlemetroTextBox.Text} {namemetroTextBox.Text}', '{titlemetroTextBox.Text}', '{contentmetroTextBox.Text}', '{namemetroTextBox.Text}', '{typemetroComboBox.SelectedItem.ToString()}', '{DateTime.Now.ToString("yyyy-MM-dd H:mm:ss")}', '0000-00-00 0:00:00')";
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
                        MetroMessageBox.Show(this, $"새로운 글을 등록하지 못했습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        log.Error($"An exception occurred from {MethodBase.GetCurrentMethod().Name}", ex);
                        return;
                    }

                    MetroMessageBox.Show(this, $"새로운 글을 등록했습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    _forum.refreshForum();

                    this.Visible = false;
                }
            }
        }
    }
}
