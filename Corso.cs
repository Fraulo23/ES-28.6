using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES_28._6
{
    internal class Corso
    {
        public string Nome { get; set; }
        public int Edizione { get; set; }
        public List<Lezione> Lezioni { get; set; }
        public List<Studente> Studenti { get; set; }
        public void AggiungiLezione(Lezione lezione)
        {
            Lezioni.Add(lezione);
        }
        public void PresenzaStudente(Studente studente)
        {
            Studenti.Add(studente);
        }
        public void StampaLezioni()
        {
            foreach (Lezione lezione in Lezioni)
            {
                Console.WriteLine(lezione.Descrizione);
            }
        }
        public void StampaStudenti()
        {
            foreach (Studente studente in Studenti)
            {
                Console.WriteLine("{0} {1}",studente.Nome,studente.Cognome);
            }
        }
        public void MediaStudenti()
        {
            float somma = 0;
            foreach (Lezione lezione in Lezioni)
            {
                somma = somma + lezione.Presenti.Count;
            }
            Console.WriteLine(somma/Lezioni.Count);
        }
        
    }
}
