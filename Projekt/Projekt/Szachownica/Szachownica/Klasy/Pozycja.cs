using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szachownica.Klasy
{
    class Pozycja
    {
        private int a;
        private int b;
        private string pole;

        public string Pole
        {
            get
            {
                return pole;
            }
            set
            {
                pole = value;
                this.a = KonwA(pole);
                this.b = Int32.Parse(pole[1].ToString());
            }
        }
        public int A
        {
            get
            {
                return a;
            }
            set
            {
                a = value;
            }
        }
        public int B
        {
            get
            {
                return b;
            }
            set
            {
                b = value;
            }
        }
        private int KonwA(string str)
        {
            switch (str[0].ToString().ToUpper())
            {
                case "A":
                    return 1;
                case "B":
                    return 2;
                case "C":
                    return 3;
                case "D":
                    return 4;
                case "E":
                    return 5;
                case "F":
                    return 6;
                case "G":
                    return 7;
                case "H":
                    return 8;
                default:
                    Console.WriteLine("BŁĄD - Zła pozycja");
                    this.a = 0;
                    this.b = 0;
                    this.pole = "BRAK";
                    return 0;
            }
        }
        public Pozycja() { }
        public Pozycja(string field)
        {
            this.Pole = pole;
        }
        public override string ToString()
        {
 	        return string.Format("Pole = {0}, X = {1}, Y = {2}", Pole, A, B);
        }
        public Pozycja(int A, int B)
        {
            if (A > 0 && B > 0)
            {
                this.A = A;
                this.B = B;

                switch (A)
                {
                    case 1:
                        this.pole = "A" + B;
                        break;
                    case 2:
                        this.pole = "B" + B;
                        break;
                    case 3:
                        this.pole = "C" + B;
                        break;
                    case 4:
                        this.pole = "D" + B;
                        break;
                    case 5:
                        this.pole = "E" + B;
                        break;
                    case 6:
                        this.pole = "F" + B;
                        break;
                    case 7:
                        this.pole = "G" + B;
                        break;
                    case 8:
                        this.pole = "H" + B;
                        break;
                    default:
                        this.a = 0;
                        this.b = 0;
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
