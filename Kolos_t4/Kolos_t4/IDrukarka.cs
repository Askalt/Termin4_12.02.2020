using System;
using System.Collections.Generic;
using System.Text;

namespace Kolos_t4
{
    interface IDrukarka
    {
        public void Drukuj(string napis);
        
    }
    interface ISkaner
    {
        public void Skanuj();
    }
    interface IKopiarka
    {
        public void Kopiuj(string napis);
    }

    public class Kopiarka : IDrukarka, ISkaner,IKopiarka
    {
        public void Drukuj(string napis)
        {
            Console.WriteLine("Drukuje");
        }

        public void Skanuj()
        {
            Console.WriteLine("Skanuje");
        }
        public void Kopiuj(string napis2)
        {
           
            Skanuj();
            Console.WriteLine($"Kopia napisu:{napis2}");
            Drukuj(napis2);
        }
    }
}
