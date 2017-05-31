using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szachownica.Klasy.Figury
{
    class Goniec : Figura
    {
        public Goniec(string kolor)
            : base(kolor)
        {
            nazwa = "Goniec";
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
            switch (Figura.figury.Count(f => f.kolor == kolor && f is Goniec))
            {
                case 1:
                    if (kolor == kolorbialy)
                    {
                        pozycja = new Pozycja("C1");
                    }
                    else
                    {
                        pozycja = new Pozycja("C8");
                    }
                    break;
                case 2:
                    if (kolor == kolorbialy)
                    {
                        pozycja = new Pozycja("F1");
                    }
                    else
                    {
                        pozycja = new Pozycja("F8");
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
            mozliwaPozycja.Add(new Pozycja(aktA - 1, aktA - 1));
            mozliwaPozycja.Add(new Pozycja(aktA - 2, aktA - 2));
            mozliwaPozycja.Add(new Pozycja(aktA - 3, aktA - 3));
            mozliwaPozycja.Add(new Pozycja(aktA - 4, aktA - 4));
            mozliwaPozycja.Add(new Pozycja(aktA - 5, aktA - 5));
            mozliwaPozycja.Add(new Pozycja(aktA - 6, aktA - 6));
            mozliwaPozycja.Add(new Pozycja(aktA - 7, aktA - 7));
            mozliwaPozycja.Add(new Pozycja(aktA - 8, aktA - 8));
            mozliwaPozycja.Add(new Pozycja(aktA + 1, aktA + 1));
            mozliwaPozycja.Add(new Pozycja(aktA + 2, aktA + 2));
            mozliwaPozycja.Add(new Pozycja(aktA + 3, aktA + 3));
            mozliwaPozycja.Add(new Pozycja(aktA + 4, aktA + 4));
            mozliwaPozycja.Add(new Pozycja(aktA + 5, aktA + 5));
            mozliwaPozycja.Add(new Pozycja(aktA + 6, aktA + 6));
            mozliwaPozycja.Add(new Pozycja(aktA + 7, aktA + 7));
            mozliwaPozycja.Add(new Pozycja(aktA + 8, aktA + 8));
            mozliwaPozycja.Add(new Pozycja(aktA - 1, aktA + 1));
            mozliwaPozycja.Add(new Pozycja(aktA - 2, aktA + 2));
            mozliwaPozycja.Add(new Pozycja(aktA - 3, aktA + 3));
            mozliwaPozycja.Add(new Pozycja(aktA - 4, aktA + 4));
            mozliwaPozycja.Add(new Pozycja(aktA - 5, aktA + 5));
            mozliwaPozycja.Add(new Pozycja(aktA - 6, aktA + 6));
            mozliwaPozycja.Add(new Pozycja(aktA - 7, aktA + 7));
            mozliwaPozycja.Add(new Pozycja(aktA - 8, aktA + 8));
            mozliwaPozycja.Add(new Pozycja(aktA + 1, aktA - 1));
            mozliwaPozycja.Add(new Pozycja(aktA + 2, aktA - 2));
            mozliwaPozycja.Add(new Pozycja(aktA + 3, aktA - 3));
            mozliwaPozycja.Add(new Pozycja(aktA + 4, aktA - 4));
            mozliwaPozycja.Add(new Pozycja(aktA + 5, aktA - 5));
            mozliwaPozycja.Add(new Pozycja(aktA + 6, aktA - 6));
            mozliwaPozycja.Add(new Pozycja(aktA + 7, aktA - 7));
            mozliwaPozycja.Add(new Pozycja(aktA + 8, aktA - 8));
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
