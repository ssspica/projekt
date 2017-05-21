using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.Klasy
{
    abstract class Figura
    {
        public string kolor;
        public string nazwa;
        public Pozycja pozycja;
        public const string bialy = "biały";
        public const string czarny = "czarny";
        public static List<Figura> figury = new List<Figura>();
        public delegate void infruch(bool tak);

        public override string ToString()
        {
            return string.Format("{3,1}  {0,8}  {1,8}  {2,4}",
                                this.nazwa.PadRight(7),
                                this.pozycja.Pole.PadRight(3),
                                this.kolor.PadRight(7)
                                 ); 
        }

        public virtual bool moze(Pozycja nowapozycja)
        {
            if (figury.Count(z => z.pozycja.Pole == nowapozycja.Pole) > 0)
            {
                return false;
            }
            return true;
        }
        public virtual void pozycjaNa(Pozycja nowapozycja)
        {
            infruch info = new infruch(Info);

            if (this.moze(nowapozycja))
            {
                this.pozycja = nowapozycja;
                info(true);
            }
            else
            {
                info(false);
            }
                
        }
        public static void Info(bool tak)
        {
            if (tak)
            {
                Console.WriteLine("Udalo sie");
            }
            else
            {
                Console.WriteLine("Nie udalo sie");
            }
        }

        public static Figura FiguraFabryka(string figura, string kolor)
        {
            switch (figura)
            {
                case "goniec":
                    return new Goniec(kolor);
                case "hetman":
                    return new Hetman(kolor);
                case "krol":
                    return new Krol(kolor);
                case "wieza":
                    return new Wieza(kolor);
                default:
                    throw new NotSupportedException("brak figury");
            }
        }

    }

}
