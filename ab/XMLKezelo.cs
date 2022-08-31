using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ab
{
    internal static class XMLKezelo
    {
        #region Adattagok
        static XDocument xml;
        #endregion

        #region Alprogramok
        public static Task JarmuToXML(List<Jarmu> jarmuvek, string fNev)
        {
            return Task.Run(() =>
            {
                xml = new XDocument(new XElement("jarmuvek"));

                foreach (Jarmu j in jarmuvek)
                {
                    if (j is Auto a)
                    {
                        xml.Root.Add(new XElement("jarmu",
                            new XAttribute("fajta", "auto"),
                            new XElement("rendszam", a.Rendszam),
                            new XElement("gyarto", a.Gyarto),
                            new XElement("tipus", a.Tipus),
                            new XElement("hengerurtartalom", a.Hengerurtartalom.ToString().Replace(".", ",")),
                            new XElement("autoTipus", (int)a.AutoTipus),
                            new XElement("csomagterL", a.CsomagterL.ToString().Replace(".", ","))
                            ));
                    }
                    else if (j is Motor m)
                    {
                        xml.Root.Add(new XElement("jarmu",
                            new XAttribute("fajta", "motor"),
                            new XElement("rendszam", m.Rendszam),
                            new XElement("gyarto", m.Gyarto),
                            new XElement("tipus", m.Tipus),
                            new XElement("hengerurtartalom", m.Hengerurtartalom.ToString().Replace(".", ",")),
                            new XElement("motorTipus", (int)m.MotorTipus)
                            ));
                    }
                }

                if (!fNev.EndsWith(".xml"))
                {
                    fNev += ".xml";
                }
                xml.Save(fNev);
            });
        }

        public static List<Jarmu> XMLToJarmu(string path)
        {
            if (File.Exists(path))
            {
                xml = XDocument.Load(path);
                List<Jarmu> jarmuvek = new List<Jarmu>();
                List<XElement> jarmuTagek = (from j in xml.Root.Elements("jarmu")
                                             select j).ToList();

                foreach (XElement node in jarmuTagek)
                {
                    if (node.Attribute("fajta").Value == "auto")
                    {
                        jarmuvek.Add(new Auto(
                            (AutoTipus)Convert.ToInt32(node.Element("autoTipus").Value),
                            Convert.ToDouble(node.Element("csomagterL").Value),
                            node.Element("rendszam").Value,
                            node.Element("gyarto").Value,
                            node.Element("tipus").Value,
                            Convert.ToDouble(node.Element("hengerurtartalom").Value)
                            ));
                    }
                    else
                    {
                        jarmuvek.Add(new Motor(
                            (MotorTipus)Convert.ToInt32(node.Element("motorTipus").Value),
                            node.Element("rendszam").Value,
                            node.Element("gyarto").Value,
                            node.Element("tipus").Value,
                            Convert.ToDouble(node.Element("hengerurtartalom").Value)
                            ));
                    }
                }

                return jarmuvek;
            }
            else
            {
                return new List<Jarmu>();
            }
        }
        #endregion
    }
}
