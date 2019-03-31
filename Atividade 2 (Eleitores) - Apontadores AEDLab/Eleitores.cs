using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_2__Eleitores____Apontadores_AEDLab
{
    class Eleitores //Gustavo
    {
        public string Nome { get; private set; }
        public char Sexo { get; private set; }
        public string Titulo_Eleitor { get; private set; }
        public int Zona_Eleitoral { get; private set; }
        public int Secao_Eleitoral { get; private set; }

        public Eleitores(string Nome, char Sexo, string Titulo_Eleitor, int Zona_Eleitoral, int Secao_Eleitoral)
        {
            this.Nome = Nome;
            this.Sexo = Sexo;
            this.Titulo_Eleitor = Titulo_Eleitor;
            this.Zona_Eleitoral = Zona_Eleitoral;
            this.Secao_Eleitoral = Secao_Eleitoral;
        }

        public override string ToString()
        {
            return ("Nome: "+ Nome + "\tSexo: " + Sexo + "\tTítulo de Eleitor: " + Titulo_Eleitor + "\tZona: " + Zona_Eleitoral + "\tSeção: " + Secao_Eleitoral + ".");
        }

        public bool Equals(char sexo)
        {
            return (this.Sexo == sexo);
        }

        public bool Equals(int Zona_Eleitoral, int Secao_Eleitoral)
        {
            return (this.Zona_Eleitoral == Zona_Eleitoral && this.Secao_Eleitoral == Secao_Eleitoral);
        }
    }
}
