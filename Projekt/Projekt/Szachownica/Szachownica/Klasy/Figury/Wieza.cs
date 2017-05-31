using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Szachownica.Klasy;

namespace Szachownica.Klasy.Figury
{
    class Wieza : Figura
    {
        public Wieza(string kolor)
            : base(kolor)
        {
            nazwa = "Wieża";
            switch (kolor)
            {
                case kolorbialy:
                    pozycja = wyborPozycji(kolorbialy);
                    break;
                case kolorczarny:
                    pozycja = wyborPozycji(kolorczarny);
                    break;
            }
        }
        private Pozycja wyborPozycji(string kolor)
        {
            switch (Figura.figury.Count(f => f.kolor == kolor && f is Wieza))
            {
                case 1:
                    if (kolor == kolorbialy)
                    {
                        pozycja = new Pozycja("A1");
                    }
                    else
                    {
                        pozycja = new Pozycja("A8");
                    }
                    break;
                case 2:
                    if (kolor == kolorbialy)
                    {
                        pozycja = new Pozycja("H1");
                    }
                    else
                    {
                        pozycja = new Pozycja("H8");
                    }
                    break;
            }
            return pozycja;
        }
        public override bool RuchMozliwy(Pozycja nadajPozycje)
        {
            int aktA = pozycja.A;
            int aktB = pozycja.B;
            List<Pozycja> mozliwaPozycja = new List<Pozycja>();
            mozliwaPozycja.Add(new Pozycja(aktA + 1, aktB));
            mozliwaPozycja.Add(new Pozycja(aktA + 2, aktB));
            mozliwaPozycja.Add(new Pozycja(aktA + 3, aktB));
            mozliwaPozycja.Add(new Pozycja(aktA + 4, aktB));
            mozliwaPozycja.Add(new Pozycja(aktA + 5, aktB));
            mozliwaPozycja.Add(new Pozycja(aktA + 6, aktB));
            mozliwaPozycja.Add(new Pozycja(aktA + 7, aktB));
            mozliwaPozycja.Add(new Pozycja(aktA + 8, aktB));
            mozliwaPozycja.Add(new Pozycja(aktA - 1, aktB));
            mozliwaPozycja.Add(new Pozycja(aktA - 2, aktB));
            mozliwaPozycja.Add(new Pozycja(aktA - 3, aktB));
            mozliwaPozycja.Add(new Pozycja(aktA - 4, aktB));
            mozliwaPozycja.Add(new Pozycja(aktA - 5, aktB));
            mozliwaPozycja.Add(new Pozycja(aktA - 6, aktB));
            mozliwaPozycja.Add(new Pozycja(aktA - 7, aktB));
            mozliwaPozycja.Add(new Pozycja(aktA - 8, aktB));
            mozliwaPozycja.Add(new Pozycja(aktA, aktB + 1));
            mozliwaPozycja.Add(new Pozycja(aktA, aktB + 2));
            mozliwaPozycja.Add(new Pozycja(aktA, aktB + 3));
            mozliwaPozycja.Add(new Pozycja(aktA, aktB + 4));
            mozliwaPozycja.Add(new Pozycja(aktA, aktB + 5));
            mozliwaPozycja.Add(new Pozycja(aktA, aktB + 6));
            mozliwaPozycja.Add(new Pozycja(aktA, aktB + 7));
            mozliwaPozycja.Add(new Pozycja(aktA, aktB + 8));
            mozliwaPozycja.Add(new Pozycja(aktA, aktB - 1));
            mozliwaPozycja.Add(new Pozycja(aktA, aktB - 2));
            mozliwaPozycja.Add(new Pozycja(aktA, aktB - 3));
            mozliwaPozycja.Add(new Pozycja(aktA, aktB - 4));
            mozliwaPozycja.Add(new Pozycja(aktA, aktB - 5));
            mozliwaPozycja.Add(new Pozycja(aktA, aktB - 6));
            mozliwaPozycja.Add(new Pozycja(aktA, aktB - 7));
            mozliwaPozycja.Add(new Pozycja(aktA, aktB - 8));
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
