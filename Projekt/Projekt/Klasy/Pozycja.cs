using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.Klasy
{
    class Pozycja
    {
        private int x;
        private int y;
        private string pole;

        public string Pole
        {
            get { return pole; }
            set
            {
                pole = value;
                this.x = ConX(pole);
                this.y = Int32.Parse(pole[1].ToString());
            }
        }

        public int x2
        {
            get { return x; }
            set { x = value; }
        }

        public int y2
        {
            get { return y; }
            set { y = value;  }
        }

        private int ConX(string str)
        {
            switch (str[0].ToString().ToUpper())
            {
                case "a":
                    return 1;
                case "b":
                    return 2;
                case "c":
                    return 3;
                case "d":
                    return 4;
                case "e":
                    return 5;
                case "f":
                    return 6;
                case "g":
                    return 7;
                case "h":
                    return 8;
                default:
                    Console.WriteLine("Błąd - zła pozycja");
                    this.x = 0;
                    this.y = 0;
                    this.pole = "BRAK";
                    return 0;
            }
        }

        public Pozycja() { }

        public Pozycja(string pole)
        {
            this.Pole = pole;
        }

        public override string ToString()
        {
            return string.Format("Pole = {0}, x = {1}, y = {2}", Pole, x2, y2);
        }

        public Pozycja(int x2, int y2)
        {
            if (x2 > 0 && y2 > 0)
            {
                this.x2 = x2;
                this.y2 = y2;

                switch (x2)
                {
                    case 1:
                        this.pole = "a" + y2; break;
                    case 2:
                        this.pole = "b" + y2; break;
                    case 3:
                        this.pole = "c" + y2; break;
                    case 4:
                        this.pole = "d" + y2; break;
                    case 5:
                        this.pole = "e" + y2; break;
                    case 6:
                        this.pole = "f" + y2; break;
                    case 7:
                        this.pole = "g" + y2; break;
                    case 8:
                        this.pole = "h" + y2; break;
                    default:
                        this.x = 0;
                        this.y = 0;
                        this.pole = "BRAK";
                        break;

                }
            }
            else
            {
                this.pole = "BRAK";
            }
        }
    }
}
