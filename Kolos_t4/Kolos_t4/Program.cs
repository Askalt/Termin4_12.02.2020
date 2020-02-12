using System;
using System.Collections.Generic;
using System.Linq;

namespace Kolos_t4
{
    class Program
    {
        static void Main(string[] args)
        {

            Cytat cytat = new Cytat("AAA", "SSS", "VVV", "EEE", DateTime.Now);
            var (autor, tytul, wydanie, miejsce, data) = cytat;
            Console.WriteLine($"{autor} {tytul} {miejsce} {wydanie} {data.Year}");
            var (autor1, data1) = cytat;
            Console.WriteLine($"{autor1} {data1.Year}");

            Kopiarka kopiarka = new Kopiarka();
            kopiarka.Kopiuj("Alicja");

            SmartPhone smartPhone=new SmartPhone();
            Chorme chorme = new Chorme();
            Poczta poczta = new Poczta();
            Outlook outlook = new Outlook();
            poczta.NOWY_MAIL += smartPhone.nowy_mail;
            poczta.NOWY_MAIL += smartPhone.nowy_mail;
            poczta.NOWY_MAIL += smartPhone.nowy_mail;
            poczta.NOWY_MAIL += smartPhone.nowy_mail;
            poczta.NOWY_MAIL += chorme.nowy_mail;
            poczta.NOWY_MAIL += chorme.nowy_mail;
            poczta.NOWY_MAIL += chorme.nowy_mail;
            poczta.NOWY_MAIL += outlook.nowy_mail;




            poczta.nowy_mail();




        }
    }
}
