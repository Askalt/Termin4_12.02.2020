using System;
using System.Collections.Generic;
using System.Text;

namespace Kolos_t4
{
   public class Cytat
    {
        public Cytat(string autor, string tytul,  string miejsce_wydania, string wydawnictwo, DateTime data)
        {
            this.autor = autor;
            this.tytul = tytul;
            this.miejsce_wydania = miejsce_wydania;
            this.wydawnictwo = wydawnictwo;
            this.data = data;
        }

        public string autor { get; set; }
        public string tytul { get; set; }
        public string miejsce_wydania { get; set; }
        public string wydawnictwo { get; set; }
        public DateTime data { get; set; }

        public void Deconstruct(out string autor,out DateTime data)
        {
           
            autor = this.autor;
            data = new DateTime(2020, 02, 02);
       
        }
        public void Deconstruct(out string autor,out string tytul,out string miejsce_wydania,out string wydawnictwo,out DateTime data)
        {

            autor = this.autor;
            tytul = this.tytul;
            miejsce_wydania = this.miejsce_wydania;
            wydawnictwo = this.wydawnictwo;
            data = new DateTime(2020, 02, 02);




        }

    }
}
