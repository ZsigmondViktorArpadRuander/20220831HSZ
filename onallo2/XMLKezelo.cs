using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace onallo2
{
    internal static class XMLKezelo
    {
        #region Adattagok
        static XDocument xml;
        #endregion

        #region Alprogramok
        public static Task<List<Ember>> XMLToEmber(string path)
        {
            return Task.Run(() =>
            {
                List<Ember> emberek = new List<Ember>();

                xml = XDocument.Load(path);
                List<XElement> elementek = xml.Root.Elements("ember").ToList();

                foreach (XElement e in elementek)
                {
                    emberek.Add(new Ember(
                        e.Element("nev").Value,
                        DateTime.Parse(e.Element("szulDatum").Value),
                        Convert.ToBoolean(e.Element("nem").Value))
                        );
                }

                return emberek;
            });
        }
        #endregion
    }
}
