using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_2__Eleitores____Apontadores_AEDLab
{
    class Elemento
    {
        public Eleitores MeuDado{ get; set; }
        public Elemento Proximo { get; set; }

        public Elemento(Eleitores dado)
        {
            MeuDado = dado;
        }
    }
}
