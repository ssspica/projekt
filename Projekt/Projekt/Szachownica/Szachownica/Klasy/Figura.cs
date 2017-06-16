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
       
        public Figura(string kolor)
        {
            this.kolor = kolor.ToLower();
            figury.Add(this);
        }
        
        public override string ToString()
        {
            return string.Format("{0} - {1} - {2}",
                                 this.nazwa,
                                 this.kolor,
                                 this.pozycja.Pole);
                                 
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
