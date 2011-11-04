using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace testowaZ
{
    /// <summary>
    /// Inny opis
    /// </summary>
    abstract class Plik
    {
        public virtual string Otworz()
        {
            //i tak
            return "Otwieram standardowo. Pewnie źle.";
        }
        public abstract string Wyswietl();
    }
}
