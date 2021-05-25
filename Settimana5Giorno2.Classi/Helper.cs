using System;
using System.Collections.Generic;
using System.Text;

namespace Settimana5Giorno2.Classi
{
   public static class Helper
    {
        //metodo che crea una persona
        public static persona CreaPersona()
        {
            Console.WriteLine("ciao come ti chiami ??");
            string n = Console.ReadLine();
            Console.WriteLine("qual è il tuo cognome ??");
            string c = Console.ReadLine();
            Sex s;
            do
            {
                Console.WriteLine("sei uomo o donna ( 1 o 2) ?");

            } while (!Sex.TryParse(Console.ReadLine(), out s));
            Console.WriteLine("qual è la tua Età??");
            int e = int.Parse(Console.ReadLine());
            persona Persona = new persona(n, c, s, e);

            Console.WriteLine("qual è la tu acittà??");
            string city = Console.ReadLine();
            Console.WriteLine("qual è la tua via??");
            string v = Console.ReadLine();
            Console.WriteLine("qual è il numero civico??");
            int civ = int.Parse(Console.ReadLine());
            Console.WriteLine("qual è la tua nazione?");
            string naz = Console.ReadLine();
            Indirizzo indirizzo = new Indirizzo(city, v, civ, naz);
            Persona.IndirizzoResidenza = indirizzo;
            return Persona;
        }
    }
}
