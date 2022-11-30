using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Data;
using System.IO;
using System.Reflection;
using System.Xml.Serialization;

namespace F3TailGoodsList
{
       
    internal class GoodsList
    {

        public DataTable goods;
        public F3TailRemainsList result;
        private string xmldbFile;
        public GoodsList()
        {

            string LocalFolder = System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            xmldbFile = Path.Combine (LocalFolder, "xmldb",  "v_site_goods_import.xml");

            XmlSerializer serializerRemains = new XmlSerializer(typeof(F3TailRemainsList));
            using (FileStream fileStream = new FileStream(xmldbFile, FileMode.Open))
            {
                result = (F3TailRemainsList)serializerRemains.Deserialize(fileStream);
                goods = result.F3TailRemains.ToDataTable();


            }


        }



        }



}
