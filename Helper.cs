using System;
using System.Collections.Generic;
using System.Text;

namespace EsercizioBolletta
{
    public static class Helper
    {
        public static Bolletta CreaBolletta()
        {
            Console.WriteLine("inserisci il tuo nome");
            string n = Console.ReadLine();

            Console.WriteLine("inserisci il tuo cognome");
            string c = Console.ReadLine();
            Console.WriteLine("inserisci quanti kwh hai consumato");
            double kwh=double.Parse( Console.ReadLine());
            Utente utente = new Utente(n, c);
            
            Bolletta bolletta = new Bolletta(kwh);
            bolletta.DatiAnagrafici = utente;

            return bolletta;


        }
    }
}
