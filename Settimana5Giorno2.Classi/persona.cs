using System;
using System.Collections.Generic;
using System.Text;

namespace Settimana5Giorno2.Classi
{ 
    
    public class persona//abbiamo bisgono di renderla pubbluca se vogliamo utilizzarla nel program
    {
        public string Nome { get; set; }//scrivere prop e poi premere due vuole il tasto TAB(tasto sopra il tasto della maiuscola)
        //get permette di accedere in lettura alla proprietà,il set permette di settarla
        public string Cognome{ get; set; }
        public Sex Sesso { get; set; }

        public int Eta { get; set; }
        //creo una classe annidata che mi indichi le informazioni sulla nascita
        public Indirizzo IndirizzoResidenza { get; set; }
       // public InfoDatiNascita DatiNascita { get; set; }
        //associamo alla persona altri dati che posso rappresentare altre entità

        public persona()
        {
            IndirizzoResidenza = new Indirizzo();
        }

        public persona(string nome,string cognome,Sex sesso,int eta)
        {
            Nome = nome;
            Cognome = cognome;
            Sesso = sesso;
            Eta = eta;
        }
        public string StampaDati()
        {
            return $"Nome:{Nome},Cognome:{Cognome},Età:{Eta}";
        }
    }
    public enum Sex //proprità della persona ma creata con enum e non con string
    {
        uomo = 1,
        donna = 2
    }
    //public class InfoDatiNascita
    //{
    //    public DateTime DataNascita { get; set; }
    //    public string ComuneNascita { get; set; }

    //}
}
