using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ab
{
    public abstract class Jarmu
    {
        #region Adattagok
        private string rendszam;
        private string gyarto;
        private string tipus;
        private double hengerurtartalom;
        #endregion

        #region Konstruktor
        protected Jarmu(string rendszam, string gyarto, string tipus, double hengerurtartalom)
        {
            this.Rendszam = rendszam;
            this.Gyarto = gyarto;
            this.Tipus = tipus;
            this.Hengerurtartalom = hengerurtartalom;
        }
        #endregion

        #region Alprogramok
        public override string ToString()
        {
            return $"{rendszam}: {gyarto} {tipus} ({hengerurtartalom} ccm)";
        }

        public abstract double Fogyasztas();
        #endregion

        #region Tulajdonsagok
        public string Rendszam
        { 
            get => rendszam; 
            set
            {
                if (rendszam != null || String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("A rendszam megadasa kotelezo es csak egyszer lehet megadni!");
                }
                else
                {
                    rendszam = value;
                }
            }
        }

        public string Gyarto
        { 
            get => gyarto;
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("A gyarto megadasa kotelezo!");
                }
                else
                {
                    gyarto = value;
                }
            }
        }

        public string Tipus
        { 
            get => tipus;
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("A tipus megadasa kotelezo!");
                }
                else
                {
                    tipus = value;
                }
            }
        }

        public double Hengerurtartalom 
        { 
            get => hengerurtartalom; 
            set
            {
                if (value < 50.0)
                {
                    throw new ArgumentException("A hengerurtartalomnak minimum 50.0 ccm-nek kell lennie!");
                }
                else
                {
                    hengerurtartalom = value;
                }
            }
        }
        #endregion
    }
}
