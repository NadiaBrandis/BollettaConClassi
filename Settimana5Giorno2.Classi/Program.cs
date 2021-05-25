using System;

namespace Settimana5Giorno2.Classi
{
    class Program
    {
        static void Main(string[] args)
        {
            persona p = new persona();//costruttore vuoto con valori di dafault
            //persona p1 = new persona("Nadia", "Brandis");//uso il secondo costruttore 
            Console.WriteLine( "Crea persona !");
            persona p1 = new persona("Nadia", "Brandis",Sex.donna,25);
            Indirizzo indirizzoP1 = new Indirizzo("Sassari", "via Umbria",18,"italia");
            p1.IndirizzoResidenza = indirizzoP1;//associo l'indirizzo alla persona p1
            //oppure riempio il costruttore vuoto
            p.Nome = "Gina";
            p.Cognome = "pina";
            p.Eta = 29;
            p.Sesso = (Sex)2;
            
            
            p.IndirizzoResidenza.Citta = "Matera";
            p.IndirizzoResidenza.Via = "via bologna";
            p.IndirizzoResidenza.NumeroCivico = 56;
            p.IndirizzoResidenza.Nazione = "italia";

            
            
          
            persona nuovaPersona = Helper.CreaPersona();
            nuovaPersona.StampaDati();
        }
    }
}
