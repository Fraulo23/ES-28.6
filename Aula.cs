using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES_28._6
{
    enum Risorse
    {
        VideoProiettore,
        PC,
        NoteBook,
        Tablet,
        LIM
    }
    internal class Aula
    {
        public int Capienza { get; set; }
        public string Nome { get; set; }
        public Risorse Risorse { get; set; }
    }
}
