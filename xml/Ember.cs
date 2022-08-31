using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xml
{
    internal class Ember
    {
        #region Adattagok
        private string nev;
        private string email;
        private uint kor;
        private bool nem;
        #endregion

        #region Konstruktor
        public Ember(string nev, string email, uint kor, bool nem)
        {
            Nev = nev;
            Email = email;
            Kor = kor;
            this.nem = nem;
        }
        #endregion

        #region Alprogramok
        public string Kiir()
        {
            return $"{nev} ({kor}, {(nem)}): {email}";
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
        
        public string Email 
        { 
            get => email; 
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Az e-mail cim megadasa kotelezo!");
                }
                else
                {
                    email = value;
                }
            }
        }
        
        public uint Kor 
        {
            get => kor; 
            set
            {
                if (value >= 0)
                {
                    kor = value;
                }
                else
                {
                    throw new ArgumentException("A kor nem lehet kisebb 0-nal!");
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
