using System;
using System.Collections.Generic;
using Szachownica.Klasy;
using Szachownica.Klasy.Figury;

namespace SzachownicaProjekt
{
    class Program
    {
        static void Main(string[] args)
        {
            SzachownicaPlansza szachownica = Toolbox.szachownicaInstancja;
            szachownica.czarnywieza1.RuchNa(new Pozycja("A6"));
            szachownica.bialykrol.RuchNa(new Pozycja("F2"));
            szachownica.bialykrolowa.RuchNa(new Pozycja("E3"));
            Console.WriteLine(szachownica.czarnywieza1);
            Console.WriteLine(szachownica.bialykrol);
            Console.WriteLine(szachownica.bialykrolowa);
            Console.WriteLine("------------");
            Console.WriteLine(szachownica[1]);
            int countFigury = szachownica.contFigury();
            Console.WriteLine("{0} figur.", countFigury.ToString());
            return;
        }
    }
}
