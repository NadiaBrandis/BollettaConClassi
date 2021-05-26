using System;
using System.Collections.Generic;
using System.Text;

namespace EsercizioBolletta
{
    public class Bolletta
    {
        public Utente DatiAnagrafici { get; set; }
        public double Kwh { get; set; }
        public decimal Conto { get; set; }

        const decimal QuotaFissa = 40;



        public Bolletta()
        {
          DatiAnagrafici = new Utente();
        }
        public Bolletta(double kwh)
        {
            Kwh = kwh;
            Conto = (decimal)(kwh * 10) + QuotaFissa;
        }
        public string StampaBolletta()
        {
            
            

            return $"il nome è {DatiAnagrafici.Nome}, il cognome è {DatiAnagrafici.Cognome} e ha consumato {Kwh} kwh e deve pagare {Conto} Euro";
        }

       
    }

}
