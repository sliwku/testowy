using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace testowaZ
{
    class Obraz:Plik
    {
        public override string Otworz()
        {
            return "Otwieram obrazek";
        }
        public override string Wyswietl()
        {
            return "Wyswietlam";
        }

       
    }
}
