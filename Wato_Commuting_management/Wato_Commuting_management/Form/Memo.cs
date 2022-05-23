using System;
using log4net;
using System.Text;
using MetroFramework;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace Wato_Commuting_management
{
    public partial class Memo : MetroFramework.Forms.MetroForm
    {

        Main _main = null;

        private static readonly ILog log = LogManager.GetLogger(typeof(Memo));

        public Memo(Main main)
        {
            InitializeComponent();

            this._main = main;

            #region style
            this.Exporttxtbutton.FlatStyle = FlatStyle.Flat;
            this.Exporttxtbutton.FlatAppearance.BorderSize = 0;

            this.Savebutton.FlatStyle = FlatStyle.Flat;
            this.Savebutton.FlatAppearance.BorderSize = 0;

            this.Exitbutton.FlatStyle = FlatStyle.Flat;
            this.Exitbutton.FlatAppearance.BorderSize = 0;
            #endregion

            #region memo select
            try
            {
                using (MySqlConnection conn = new MySqlConnection(DB_info_xml.db_info))
                {
                    conn.Open();
                    string sql = $"SELECT memo FROM user_tb WHERE name = '{Login.name}'";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    MySqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        MemorichTextBox.Text = rdr["memo"].ToString();
                    }
                    rdr.Close();
                    log.Info($"{sql}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"메모를 불러오지 못했습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
                log.Error($"An exception occurred from {MethodBase.GetCurrentMethod().Name}", ex);
                return;
            }
            #endregion
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MemoSave();
        }
        
        private void MemoSave()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(DB_info_xml.db_info))
                {
                    conn.Open();
                    string sql = $"UPDATE user_tb SET memo = '{MemorichTextBox.Text}' WHERE name = '{Login.name}'";
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
                MetroMessageBox.Show(this, $"메모를 DB에 저장하지 못했습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
                log.Error($"An exception occurred from {MethodBase.GetCurrentMethod().Name}", ex);
                return;
            }

            MetroMessageBox.Show(this, $"메모를 DB에 저장했습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Exporttxtbutton_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                string savePath = $@"{dialog.FileName}\{DateTime.Now.ToString("yyyy-MM-dd")} {Login.name} memo.txt";
                System.IO.File.WriteAllText(savePath, MemorichTextBox.Text, Encoding.Default);

                MetroMessageBox.Show(this, $"메모를 추출 했습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                System.Diagnostics.Process.Start(dialog.FileName);
            }
        }

        private void Exitbutton_Click(object sender, EventArgs e)
        {
            _main.Memobutton.BackColor = Color.SkyBlue;
            this.Visible = false;
        }

        private void Memo_FormClosed(object sender, FormClosedEventArgs e)
        {
            _main.Memobutton.BackColor = Color.SkyBlue;
        }
    }
}
