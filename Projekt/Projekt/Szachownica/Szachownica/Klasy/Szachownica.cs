using System;
using System.Collections.Generic;
using Szachownica.Klasy.Figury;

namespace Szachownica.Klasy
{
    class SzachownicaPlansza
    {

        public Figura[] figury;
        public Figura czarnygoniec1 = Figura.FiguraFactory("Goniec", "Czarny");
        public Figura czarnygoniec2 = Figura.FiguraFactory("Goniec", "Czarny");
        public Figura bialygoniec1 = Figura.FiguraFactory("Goniec", "Biały");
        public Figura bialygoniec2 = Figura.FiguraFactory("Goniec", "Biały");
        public Figura czarnykrol = Figura.FiguraFactory("Krol", "Czarny");
        public Figura bialykrol = Figura.FiguraFactory("Krol", "Biały");
        public Figura czarnykrolowa = Figura.FiguraFactory("Krolowa", "Czarny");
        public Figura bialykrolowa = Figura.FiguraFactory("Krolowa", "Biały");
        public Figura czarnywieza1 = Figura.FiguraFactory("Wieża", "Czarny");
        public Figura czarnywieza2 = Figura.FiguraFactory("Wieża", "Czarny");
        public Figura bialywieza1 = Figura.FiguraFactory("Wieża", "Biały");
        public Figura bialywieza2 = Figura.FiguraFactory("Wieża", "Biały");

        public SzachownicaPlansza()
        {
            foreach (Figura figura in Figura.figury)
            {
                Console.WriteLine(figura);
            }
            figury = new Figura[12];
            figury[0] = czarnygoniec1;
            figury[1] = czarnygoniec2;
            figury[2] = bialygoniec1;
            figury[3] = bialygoniec2;
            figury[4] = czarnykrol;
            figury[5] = bialykrol;
            figury[6] = czarnykrolowa;
            figury[7] = bialykrolowa;
            figury[8] = czarnywieza1;
            figury[9] = czarnywieza2;
            figury[10] = bialywieza1;
            figury[11] = bialywieza2;
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
    static class extenstion
    {
        public static int contFigury(this SzachownicaPlansza szachownica)
        {
            return szachownica.figury.Length;
        }
    }
   
}
