using System;
using System.Collections.Generic;
using System.Text;

namespace Kolos_t4
{
    public static class ExtensionMethod
    {
        
        public static int Tablica_x10(this int[] tablica_int,int mnoznik)
        {

            foreach (var item in tablica_int)
            {
                Console.WriteLine(tablica_int[item * mnoznik]);
                int wynik = (tablica_int[item * mnoznik]);
                return wynik;
            }
            return mnoznik;
        }  
    }
}
