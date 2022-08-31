using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ab
{
    public enum MotorTipus
    {
        Naked, Enduro, Supermoto, Speed, Chopper
    }

    public class Motor: Jarmu
    {
        #region Adattagok
        private MotorTipus motorTipus;
        #endregion

        #region Konstruktor
        public Motor(MotorTipus motorTipus, string rendszam, string gyarto, string tipus, double hengerurtartalom)
            : base(rendszam, gyarto, tipus, hengerurtartalom)
        {
            this.motorTipus = motorTipus;
        }
        #endregion

        #region Alprogramok
        public override double Fogyasztas()
        {
            double alap = 1.5;
            switch (motorTipus)
            {
                case MotorTipus.Chopper:
                    alap = alap * 2;
                    break;

                case MotorTipus.Supermoto:
                    alap = alap * 1.8;
                    break;

                case MotorTipus.Enduro:
                    alap = alap * 2.2;
                    break;

                case MotorTipus.Naked:
                    alap = alap * 2.5;
                    break;

                case MotorTipus.Speed:
                    alap = alap * 3;
                    break;
            }
            return alap;
        }

        public override string ToString()
        {
            return "(M) " + base.ToString() + $", {motorTipus}, {Jogositvany}";
        }
        #endregion

        #region Tulajdonsagok
        public MotorTipus MotorTipus { get => motorTipus; }
        
        public string Jogositvany
        {
            get
            {
                if (Hengerurtartalom > 700)
                {
                    return "A";
                }
                else if (Hengerurtartalom > 125 && Hengerurtartalom <= 700)
                {
                    return "A2";
                }
                else if (Hengerurtartalom > 50 && Hengerurtartalom <= 125)
                {
                    return "A1";
                }
                else
                {
                    return "AM";
                }
            } 
        }
        #endregion
    }
}
