using System;
using log4net;
using MetroFramework;
using System.Reflection;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Wato_Commuting_management
{
    public partial class forumdetails : MetroFramework.Forms.MetroForm
    {
        forum _forum;

        int SelectRow;
        string typeselectdate;
        string titleselectdate;
        string nameselectdate;
        string adddateselectdate;        

        private static readonly ILog log = LogManager.GetLogger(typeof(forumdetails));

        public forumdetails(forum forum)
        {
            InitializeComponent();
            this._forum = forum;

            SelectRow = _forum.forumListView.SelectedItems[0].Index;
            typeselectdate = _forum.forumListView.Items[SelectRow].SubItems[0].Text;
            titleselectdate = _forum.forumListView.Items[SelectRow].SubItems[1].Text;
            nameselectdate = _forum.forumListView.Items[SelectRow].SubItems[2].Text;
            adddateselectdate = _forum.forumListView.Items[SelectRow].SubItems[3].Text;

            titlemetroLabel.Text = titleselectdate;
            adduseranddatemetroLabel.Text = $"{adddateselectdate}   |   {nameselectdate}   |   {typeselectdate}";
            ContentSelect();
        }

        private void Okbutton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        public void ContentSelect()
        {
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
                        ContentmetroLabel.Text = rdr["content"].ToString();
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
        }
    }
}
