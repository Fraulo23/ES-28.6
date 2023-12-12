using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES_28._6
{
    internal class Lezione
    {
        public string Descrizione { get; set; }
        public DateTime Data { get; set; }
        public DateTime OrarioInizio { get; set; }
        public int Durata { get; set; }
        public Docente docente { get; set; }
        public Aula aula { get; set; }
        public List<Studente> Presenti { get; set; }
        public void Assenza(Studente studente)
        {
            studente.Presente = false;
            Presenti.Add(studente);
        }
    }
}
