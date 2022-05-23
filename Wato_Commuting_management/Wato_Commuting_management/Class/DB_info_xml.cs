using System.Xml;

namespace Wato_Commuting_management
{
    public static class DB_info_xml
    {
        public static string db_info;

        public static void DB_info_xml_read()
        {
            Config con = se_de.XmlDeserialize<Config>(@"config.xml");
            db_info = con.DB;
        }
    }
}
