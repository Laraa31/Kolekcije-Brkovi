using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolekcij_Brkovi
{
    internal class Osoba
    {
        string ime, prezime, spol;
        string godina;


        public override string ToString()
        {
            string ispis = this.ime + "\t" + this.prezime + "\t" + this.spol +"\t"+ this.godina +"\t";
            return ispis;
        }

        public Osoba(string ime, string prezime, string spol, string godina)
        {
            this.Ime = ime;
            this.Prezime = prezime;
            this.Spol = spol;
            this.Godina= godina;
        }

        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public string Spol { get => spol; set => spol = value; }
        public string Godina { get => godina; set => godina = value; }

        
    }
}
