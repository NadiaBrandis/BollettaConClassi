using System;
using System.Collections.Generic;
using System.Text;

namespace Settimana5Giorno2.Classi
{
   public class Indirizzo
    {
        public string Citta { get; set; }
        public string Via { get; set; }
        public int NumeroCivico { get; set; }
        public string Nazione { get; set; }
        public Indirizzo()
        {

        }
        public Indirizzo(string citta, string via, int numero, string nazione)
        {
            Citta = citta;
            Via = via;
            NumeroCivico = numero;
            Nazione = nazione;

        }
    }
}
