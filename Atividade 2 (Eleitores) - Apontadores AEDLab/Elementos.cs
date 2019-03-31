using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_2__Eleitores____Apontadores_AEDLab
{
    class Elementos
    {
        public Eleitores MeuDado { get; set; }
        public Elementos Proximo { get; set; }

        public Elementos(Eleitores dado)
        {
            MeuDado = dado;
        }
    }
}
