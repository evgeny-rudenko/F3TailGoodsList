using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;


namespace F3TailGoodsList
{
    [XmlRoot("DocumentElement")]
    public class F3TailRemainsList
    {
        [XmlElement("v_site_goods_import")]
        public List<F3TailRemain> F3TailRemains { get; set; }
    }

    /// <summary>
    /// Остаток товара по партии 
    /// </summary>
    public class F3TailRemain
    {
        [XmlElement("ID_GOODS_GLOBAL")]
        public Guid ID_GOODS_GLOBAL { get; set; }    // код товара
        
        
        [XmlElement("NAME")]
        public String NAME { get; set; }

        [XmlElement("NM")]
        public String NM { get; set; }

        [XmlElement("PRODUCER")]
        public String PRODUCER { get; set; }


        [XmlElement("DESCRIPTION")]
        public String DESCRIPTION { get; set; }

        [XmlElement("incoming_date")]
        public DateTime incoming_date { get; set; }

        [XmlElement("quantity")]
        public decimal quantity { get; set; }
        /*
        [XmlElement("ID_STORE_GLOBAL")]
        public Guid ID_STORE_GLOBAL { get; set; }    // код отдела
        [XmlElement("ID_LOT_GLOBAL")]
        public Guid ID_LOT_GLOBAL { get; set; }      // код партии
        
        [XmlElement("QUANTITY_REM")]
        public decimal QUANTITY_REM { get; set; }    // остаток товара по партии
        [XmlElement("MAX_DATE_OP")]
        public DateTime MAX_DATE_OP { get; set; }    // дата последней операции
        [XmlElement("DDATE")]
        public DateTime DDATE { get; set; }          // дата и время выгрузки
        */
    }

    /// <summary>
    /// Загрузка файла
    /// </summary>
    class XMLDoc
    {
     //   public dtype Dtype;
        private XmlDocument xmldoc = new XmlDocument();
        public XMLDoc(XmlDocument doc, string fName)
        {
            /*
            if (fName.Contains("remainsall"))
            {
                Dtype = dtype.RemainsAll;
            }
            if (fName.Contains("remaindiff"))
            {
                Dtype = dtype.RemainsDiff;
            }
            if (fName.Contains("remaindiff"))
            {
                Dtype = dtype.Documents;
            }
            */
            xmldoc.Load(fName);
        }
    }
}
