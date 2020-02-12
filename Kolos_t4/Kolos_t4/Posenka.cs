using System;
using System.Collections.Generic;
using System.Text;

namespace Kolos_t4
{
    public class Pisenka
    {


        public string tytul { get; set; }
        public string autor { get; set; }
        public TimeSpan TimeSpan;

        public Pisenka(string tytul, string autor, TimeSpan timeSpan)
        {
            this.tytul = tytul;
            this.autor = autor;
            TimeSpan = timeSpan;
        }

    }
  
}
