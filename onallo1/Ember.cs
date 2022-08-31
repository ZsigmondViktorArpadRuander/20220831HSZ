using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace onallo1
{
    internal class Ember
    {
        #region Adattagok
        private string nev;
        private DateTime szulDatum;
        private bool nem;
        #endregion

        #region Konstruktor
        public Ember(string nev, DateTime szulDatum, bool nem)
        {
            Nev = nev;
            SzulDatum = szulDatum;
            this.nem = nem;
        }
        #endregion

        #region Alprogramok
        public XElement XML()
        {
            return new XElement("ember", 
                new XElement("nev", nev),
                new XElement("szulDatum", szulDatum.ToShortDateString()),
                new XElement("nem", nem));
        }
        #endregion

        #region Tulajdonsagok
        public string Nev 
        { 
            get => nev; 
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("A nev megadasa kotelezo!");
                }
                else
                {
                    nev = value;
                }
            }
        }
        
        public DateTime SzulDatum
        { 
            get => szulDatum; 
            private set
            {
                if (value < new DateTime(1900, 1, 1))
                {
                    throw new ArgumentException("A szuletesi datum nem lehet kisebb, mint 1900.01.01.!");
                }
                else
                {
                    szulDatum = value;
                }
            }
        }
        
        public bool Nem 
        { 
            get => nem; 
        }
        #endregion
    }
}
