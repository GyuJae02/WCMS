using System;
using log4net;
using System.Net;
using System.Reflection;
using System.Windows.Forms;

namespace Wato_Commuting_management
{
    static class Program
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Program));
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            log.Info("=============  Started Client application  =============");
            
            if (GetExternalIPAddress() != "121.137.90.73")
            {
                MessageBox.Show("와토솔루션 본사에서만 사용하실 수 있습니다.", "접근 거부 알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                DB_info_xml.DB_info_xml_read();

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Login());
            }
        }

        public static string GetExternalIPAddress()
        {
            string externalip = "";

            try
            {
                externalip = new WebClient().DownloadString("http://ipinfo.io/ip").Trim();
            }
            catch (Exception ex)
            {
                MessageBox.Show("인터넷 연결을 확인하세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
                log.Error($"An exception occurred from {MethodBase.GetCurrentMethod().Name}", ex);
            }

            return externalip;
        }
    }
}
