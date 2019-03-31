using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_2__Eleitores____Apontadores_AEDLab
{
    class Lista
    {
        public Lista() //Lorena
        {

        }

        public void Inserir(Eleitores dado) //Lorena
        {
            // insira elementos ao final da lista

        }

        public Eleitores Retirar(string Titulo) //Gustavo
        {
            // Este método deve receber como
            // parâmetro o título da pessoa que deve ser excluída;

            return null;
        }

        public int CarregarDados (string nomeArquivo) //Lorena
        {
            // Este método deve receber como parâmetro o nome de um arquivo texto e
            // carregar (ler) os dados constantes deste arquivo para a lista. O retorno do método é a
            // quantidade de registros lidos.
            
            return -1;
        }

        public Lista EleitoresPorSecao(int zona, int secao) //Lorena
        {
            // localiza, na lista de eleitores, aqueles que pertençam à zona e seção especificados. 
            // Este método retorna uma lista com os eleitores encontrados.

            return null;
        }   

        public Lista EleitoresPorSexo(char sexo) //Gustavo
        {
            // Este método recebe como parâmetro um caractere indicando o sexo(masculino ou feminino) e retorna a lista de eleitores
            // formada exclusivamente por pessoas do sexo informado.

            return null;
        }
    }
}
