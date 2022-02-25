using System;
using System.Collections.Generic;
using System.Text;

namespace Projekt_PP
{
    class Książka
    {
        public string autor, tytuł, stan, imięPosiadacza,termin;
        public int strony;
        public Książka(string autor, string tytuł, int strony, string stan, string imięPosiadacza, string termin)
        {
            this.autor = autor;
            this.tytuł = tytuł;
            this.strony = strony;
            this.stan = stan;
            this.imięPosiadacza = imięPosiadacza;
            this.termin = termin;
        }
    }
}
