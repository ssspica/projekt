using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Szachownica.Klasy;
using Szachownica.Klasy.Figury;

namespace Szachownica.Klasy
{
    abstract class Figura
    {
        public string nazwa;
        public string kolor;
        public Pozycja pozycja;
        public static List<Figura> figury = new List<Figura>();
        public delegate void moveMessage(bool success);
        public const string kolorczarny = "Czarny";
        public const string kolorbialy = "Biały";
        public Figura(string kolor)
        {
            kolor.ToLower();
            if (!(kolor == kolorbialy || kolor == kolorczarny))
            {
                Console.WriteLine("BŁĄD - Zły kolor");
                return;
            }
            else
            {
                this.kolor = kolor;
            }
            figury.Add(this);
        }
        public override string ToString()
        {
            return string.Format("+{3,1}+{0,8}+{1,8}+{2,4}+",
                                 this.nazwa.PadRight(7),
                                 this.kolor.PadRight(7),
                                 this.pozycja.Pole.PadRight(3));
                                 
        }
        public virtual bool RuchMozliwy(Pozycja nadajPozycje)
        {
            if (figury.Count(f => f.pozycja.Pole == nadajPozycje.Pole) > 0)
            {
                return false;
            }
            return true;
        }
        public virtual void RuchNa(Pozycja nadajPozycje)
        {
            moveMessage info = new moveMessage(Info);
            if (this.RuchMozliwy(nadajPozycje))
            {
                this.pozycja = nadajPozycje;
                info(true);
            }
            else
            {
                info(false);
            }
        }
        public static void Info(bool success)
        {
            if (success)
            {
                Console.WriteLine("Figura przesunięta");
            }
            else
            {
                Console.WriteLine("Błąd, ruch niemożliwy");
            }
        }
        public static Figura FiguraFactory(string figura, string kolor)
        {
            switch (figura)
            {
                case "Król":
                    return new Krol(kolor);
                case "Goniec":
                    return new Goniec(kolor);
                case "Królowa":
                    return new Krolowa(kolor);
                case "Wieza":
                    return new Wieza(kolor);
                default:
                    throw new NotSupportedException("Brak figury");
            }
        }
    }
}
