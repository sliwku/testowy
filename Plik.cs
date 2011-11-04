using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace testowaZ
{
    abstract class Plik
    {
        public virtual string Otworz()
        {
            return "Otwieram standardowo. Pewnie źle.";
        }
        public abstract string Wyswietl();
    }
}
