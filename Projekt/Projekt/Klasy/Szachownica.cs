using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.Klasy
{
    class Szachownica
    {
        public Figura[] figury;
        public Figura goniecbialy1 = Figura.FiguraFabryka("goniec", "bialy");
        public Figura goniecczarny1 = Figura.FiguraFabryka("goniec", "czarny");
        public Figura goniecbialy2 = Figura.FiguraFabryka("goniec", "bialy");
        public Figura goniecczarny2 = Figura.FiguraFabryka("goniec", "czarny");
        public Figura hetmanbialy = Figura.FiguraFabryka("hetman", "bialy");
        public Figura hetmancczarny = Figura.FiguraFabryka("hetman", "czarny");
        public Figura krolbialy = Figura.FiguraFabryka("krol", "bialy");
        public Figura krolczarny = Figura.FiguraFabryka("krol", "czarny");
        public Figura wiezabialy1 = Figura.FiguraFabryka("wieza", "bialy");
        public Figura wiezaczarny1 = Figura.FiguraFabryka("wieza", "czarny");
        public Figura wiezabialy2 = Figura.FiguraFabryka("wieza", "bialy");
        public Figura wiezaczarny2 = Figura.FiguraFabryka("wieza", "czarny");

        public Szachownica()
        {
            foreach (Figura figura in Figura.figury)
            {
                Console.WriteLine(figura);
            }
            figury = new Figura[12];
            figury[0] = goniecbialy1;
            figury[1] = goniecczarny1;
            figury[2] = goniecbialy2;
            figury[3] = goniecczarny2;
            figury[4] = hetmanbialy;
            figury[5] = hetmancczarny;
            figury[6] = krolbialy;
            figury[7] = krolczarny;
            figury[8] = wiezabialy1;
            figury[9] = wiezaczarny1;
            figury[10] = wiezabialy2;
            figury[11] = wiezaczarny2;
        }
        public Figura this[int index]
        {
            get
            {
                return this.figury[index];
            }
            set
            {
                this.figury[index] = value;
            }
        }
    }
    static class ext
    {
        public static int wartoscfigur(this Szachownica szachownica)
        {
            return szachownica.figury.Length;
        }
    }
}
