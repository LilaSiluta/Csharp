using System;
using System.Collections.Generic;
using System.Text;

namespace Projekt_PP
{
    class Czytelnik
    {
        public string imię, stan1, stan2;
        public int numerAlbumu;
        public Czytelnik(string imię, int numerAlbumu, string stan1, string stan2)
        {
            this.imię = imię;
            this.numerAlbumu = numerAlbumu;
            this.stan1 = stan1;
            this.stan2 = stan2;
        }
    }
}
