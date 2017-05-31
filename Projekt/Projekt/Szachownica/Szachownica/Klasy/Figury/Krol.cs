using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Szachownica.Klasy;

namespace Szachownica.Klasy.Figury
{
    class Krol : Figura
    {
        public Krol(string kolor)
            : base(kolor)
        {
            nazwa = "Król";
            switch (kolor)
            {
                case kolorbialy:
                    pozycja = new Pozycja("E1");
                    break;
                case kolorczarny:
                    pozycja = new Pozycja("E8");
                    break;
            }
        }
        public override bool RuchMozliwy(Pozycja nadajPozycje)
        {
            int aktA = pozycja.A;
            int aktB = pozycja.B;
            List<Pozycja> mozliwaPozycja = new List<Pozycja>();
            mozliwaPozycja.Add(new Pozycja(aktA + 1, aktB));
            mozliwaPozycja.Add(new Pozycja(aktA - 1, aktB));
            mozliwaPozycja.Add(new Pozycja(aktA + 1, aktB + 1));
            mozliwaPozycja.Add(new Pozycja(aktA + 1, aktB - 1));
            mozliwaPozycja.Add(new Pozycja(aktA, aktB + 1));
            mozliwaPozycja.Add(new Pozycja(aktA, aktB - 1));
            mozliwaPozycja.Add(new Pozycja(aktA - 1, aktB + 1));
            mozliwaPozycja.Add(new Pozycja(aktA - 1, aktB - 1));
            foreach (Pozycja poz in mozliwaPozycja)
            {
                if (base.RuchMozliwy(poz) && poz.Pole == nadajPozycje.Pole) 
                {
                    return true;
                }
            }
            return false;
        }
    }
}
