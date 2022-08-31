using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace onallo1
{
    internal static class XMLKezelo
    {
        #region Adattagok
        static XDocument xml;
        #endregion

        #region Alprogramok
        public static Task EmberToXML(List<Ember> emberek, string path)
        {
            return Task.Run(() =>
            {
                xml = new XDocument(new XElement("emberek"));

                foreach (Ember e in emberek)
                {
                    xml.Root.Add(e.XML());
                }

                if (!path.EndsWith(".xml"))
                {
                    path += ".xml";
                }
                xml.Save(path);
            }); 
        }
        #endregion
    }
}
