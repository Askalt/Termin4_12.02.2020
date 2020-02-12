using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Kolos_t4
{
    public class Poczta
    {
        public event EventHandler NOWY_MAIL;

        public void nowy_mail()
        {
            NOWY_MAIL.Invoke(this, EventArgs.Empty);
        }
    }
        public class SmartPhone
        {
            public void nowy_mail(object sender,EventArgs e)
            {
                Console.WriteLine("Witaj masz nowa wiadomość email.Dotkinij tutaj aby przeczytac teraz");
            }
      
        }
        public class Chorme
        {
        int licznik = 0;
        public void nowy_mail(object sender, EventArgs e)
        {
            Console.WriteLine($"Gmail<{licznik}>");
            licznik++;
        }

        }

        public class Outlook
         {
        public void nowy_mail(object sender, EventArgs e)
        {
            string mes = "ads";
            string autor = "Jan";
            Console.WriteLine($"Wiadomosc:{mes} Autor{autor}");
        }
         }
  
}


