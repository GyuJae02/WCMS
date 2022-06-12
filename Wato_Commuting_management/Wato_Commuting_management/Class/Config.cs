using log4net;
using System.IO;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Wato_Commuting_management
{
    public class Config
    {
        public string DB { get; set; }
        public string ID { get; set; }
        public string PW { get; set; }
        public string Account_save_check { get; set; }
    }

    public static class se_de
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(PinLogin));

        public static void Xmlserialize<T>(string xmlpath, T _class) where T : class
        {
            log.Info($"Xmlserialize");

            using (StreamWriter wr = new StreamWriter(xmlpath))
            {
                XmlSerializer xs = new XmlSerializer(typeof(T));
                xs.Serialize(wr, _class);
            }
        }

        public static T XmlDeserialize<T>(string xmlpath) where T : class
        {
            log.Info($"XmlDeserialize");

            using (var reader = new StreamReader(xmlpath))
            {
                XmlSerializer xs = new XmlSerializer(typeof(T));
                return (T)xs.Deserialize(reader);
            }
        }

        public static void CreateXml()
        {
            XElement doc = new XElement("Config",
                           new XElement("DB", "Server=127.0.0.1; Port=3306; Database=wato_commuting_management_db; Uid=root; Pwd=0273; convert zero datetime=True;"),
                           //new XElement("DB", "Server=192.168.0.240; Port=3306; Database=wato_commuting_management_db; Uid=root; Pwd=wato1201; convert zero datetime=True;"),
                           new XElement("ID", ""),
                           new XElement("PW", ""),
                           new XElement("Account_save_check", "")
                           );

            doc.Save(@"config.xml");
        }
    }

}
