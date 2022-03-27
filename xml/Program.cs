using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace xml
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        public static Hotels LoadXml()
        {
            string path = "Hotel_new.xml";
            XmlDocument doc = new XmlDocument();
            doc.Load(path);
            try
            {
                MemoryStream rawData = new MemoryStream(File.ReadAllBytes(path));
                XmlSerializer xmls = new XmlSerializer(typeof(Hotels));
                var xmlsList = (Hotels)xmls.Deserialize(rawData);
                return xmlsList;
            }
            catch (Exception e)
            {
                MessageBox.Show("ошибка десериализации", "Error");
                return null;
            }
        }

    }
}
