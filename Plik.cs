using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace testowaZ
{
    /// <summary>
    /// Opis klasy
    /// </summary>
    abstract class Plik
    {
        public virtual string Otworz()
        {
            return "Otwieram standardowo. Pewnie źle.";
        }
        public abstract string Wyswietl();
    }
}
