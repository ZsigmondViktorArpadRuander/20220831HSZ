using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ab
{
    public enum AutoTipus
    {
        Sedan, Egyteru, Cabrio, Pickup, SUV
    }

    public class Auto: Jarmu
    {
        #region Adattagok
        private AutoTipus autoTipus;
        private double csomagterL;
        #endregion

        #region Konstruktor
        public Auto(AutoTipus autoTipus, double csomagterL, string rendszam, string gyarto, string tipus, double hengerurtartalom)
            : base(rendszam, gyarto, tipus, hengerurtartalom)
        {
            this.autoTipus = autoTipus;
            this.CsomagterL = csomagterL;
        }
        #endregion

        #region Alprogramok
        public override double Fogyasztas()
        {
            double alap = 2;
            switch (autoTipus)
            {
                case AutoTipus.Cabrio:
                    alap = alap * 3;
                    break;

                case AutoTipus.Egyteru:
                    alap = alap * 2;
                    break;

                case AutoTipus.SUV:
                    alap = alap * 2.5;
                    break;

                case AutoTipus.Pickup:
                    alap = alap * 4;
                    break;

                case AutoTipus.Sedan:
                    alap = alap * 2.2;
                    break;
            }

            return alap;
        }

        public override string ToString()
        {
            return "(A) " + base.ToString() + $" - {autoTipus}, {csomagterL} liter";
        }
        #endregion

        #region Tulajdonsagok
        public AutoTipus AutoTipus { get => autoTipus; }
        
        public double CsomagterL 
        { 
            get => csomagterL; 
            set
            {
                if (value < 0.0)
                {
                    throw new ArgumentException("A csomagtarto legalabb 0.0 literes kell legyen!");
                }
                else
                {
                    csomagterL = value;
                }
            }
        }
        #endregion
    }
}
