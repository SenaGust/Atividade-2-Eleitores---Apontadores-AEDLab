using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Atividade_2__Eleitores____Apontadores_AEDLab
{
    class Lista
    {
        public Elementos Primeiro { get; set; }
        public Elementos Ultimo { get; set; }

        public Lista() //Lorena
        {
            this.Primeiro = null;
            this.Ultimo = null;
        }

        public void Inserir(Eleitores dado) //Lorena
        {

            // insira elementos ao final da lista
            Elementos novo_eleitor = new Elementos(dado);
            if (this.Vazia())
            {
                this.Ultimo = novo_eleitor;
                this.Ultimo.Proximo = null;
            }
            else
            {
                this.Ultimo.Proximo = novo_eleitor;
                novo_eleitor = this.Ultimo;
                this.Ultimo = novo_eleitor;
            }

        }

        public Eleitores Retirar(string Titulo) //Gustavo
        {
            // Este método deve receber como
            // parâmetro o título da pessoa que deve ser excluída;

            Elementos aux = Primeiro.Proximo;

            while (aux != null && !aux.Proximo.MeuDado.Equals(Titulo))
            {
                aux = aux.Proximo;
            }



            return aux.MeuDado;
        }

        public int CarregarDados(string nomeArquivo) //Lorena
        {
            int cont = 0;
            Lista lista = new Lista();

            if (!File.Exists(nomeArquivo))
            {
                StreamWriter criar = new StreamWriter(nomeArquivo);
                criar.Close();
            }

            StreamReader arq = new StreamReader(nomeArquivo);
            string linha;
            string[] vetoraux;


            while (!arq.EndOfStream)
            {
                cont++;
                linha = arq.ReadLine();
                vetoraux = linha.Split('-');
                if (vetoraux.Length == 5)
                {
                    Eleitores eleitores = new Eleitores();
                    eleitores.Nome = vetoraux[0];
                    eleitores.Sexo = Convert.ToChar(vetoraux[1]);
                    eleitores.Titulo_Eleitor = vetoraux[2];
                    eleitores.Zona_Eleitoral = int.Parse(vetoraux[3]);
                    eleitores.Secao_Eleitoral = int.Parse(vetoraux[4]);

                    lista.Inserir(eleitores);
                }
            }

            arq.Close();

            return cont;
        }

        public Lista EleitoresPorSecao(int zona, int secao) //Lorena
        {
            // localiza, na lista de eleitores, aqueles que pertençam à zona e seção especificados. 
            // Este método retorna uma lista com os eleitores encontrados.
            Lista epzes = new Lista(); //criando a lista que vai abrigar as pessoas daquela zona e seção
            Elementos auxiliar = Primeiro.Proximo;

            while(epzes!=null)
            {
                if(auxiliar.MeuDado.Equals(zona,secao))
                {
                    epzes.Inserir(auxiliar.MeuDado);
                }

                auxiliar = auxiliar.Proximo;
            }

            return epzes;
        }

        public Lista EleitoresPorSexo(char sexo) //Gustavo
        {
            // Este método recebe como parâmetro um caractere indicando o sexo(masculino ou feminino) e retorna a lista de eleitores
            // formada exclusivamente por pessoas do sexo informado.

            Lista EleitoresPorSexo = new Lista();
            Elementos aux = Primeiro.Proximo;

            while (aux != null)
            {
                if (aux.MeuDado.Equals(sexo))
                    EleitoresPorSexo.Inserir(aux.MeuDado);

                aux = aux.Proximo;
            }

            return EleitoresPorSexo;
        }

        public bool Vazia()
        {
            return (this.Ultimo == this.Primeiro);
        }

        public override string ToString()
        {
            if (this.Vazia()) return null;

            StringBuilder auxImpressao = new StringBuilder();
            Elementos atual = this.Primeiro.Proximo;
            while(atual!=null)
            {
                auxImpressao.AppendLine(atual.MeuDado.Nome);
                atual = atual.Proximo;
                   
            }
            return "Teste" + auxImpressao.ToString();
        }
    }
}
