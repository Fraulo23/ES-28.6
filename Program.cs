using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES_28._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Scuola scuola = new Scuola();
            Corso c=new Corso();
            c.Nome = "Info";
            c.Edizione=2023;
            scuola.Corsi.Add(c);
            Lezione l1 = new Lezione();
            l1.Data=DateTime.Now;
            l1.Durata = 40;
            l1.docente = scuola.Docenti[5];
            l1.Descrizione = "Esercizi";
            c.Lezioni.Add(l1);
            Studente Luca=new Studente();
            Luca.Nome = "Luca";
            Luca.Cognome = "Verdi";
            l1.Presenti.AddRange(c.Studenti);
            foreach (Corso corso in scuola.Corsi)
            {
                Console.WriteLine(corso.Nome);
            }
            c.StampaLezioni();
            c.StampaStudenti();
            c.MediaStudenti();

        }
    }
}
