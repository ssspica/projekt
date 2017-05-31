using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szachownica.Klasy
{
    class Toolbox
    {
        private static SzachownicaPlansza szachownica = new SzachownicaPlansza();
        private Toolbox() { }
        public static SzachownicaPlansza szachownicaInstancja
        {
            get
            {
                return szachownica;
            }
        }
    }
}
