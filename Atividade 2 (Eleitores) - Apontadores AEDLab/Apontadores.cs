using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_2__Eleitores____Apontadores_AEDLab
{
    class Apontadores
    {
        public Eleitores MeuDado { get; set; }
        public Apontadores Proximo { get; set; }

        public Apontadores(Eleitores dado)
        {
            MeuDado = dado;
        }
    }
}
