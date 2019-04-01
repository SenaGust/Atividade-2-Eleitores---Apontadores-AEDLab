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

        #region Construtor
        public Lista() //Lorena
        {
            this.Primeiro = new Elementos(null);
            this.Ultimo = this.Primeiro;
        }
        #endregion

        #region Métodos
        public void Inserir(Eleitores dado) //Lorena
        {
            // insira elementos ao final da lista
            Elementos novo_eleitor = new Elementos(dado);

            //if (this.Vazia())
            //{
            //    this.Ultimo = novo_eleitor;
            //    this.Ultimo.Proximo = null;
            //}
            //else
            //{
            //    this.Ultimo.Proximo = novo_eleitor;
            //    novo_eleitor = this.Ultimo;
            //    this.Ultimo = novo_eleitor;
            //}

            Ultimo.Proximo = novo_eleitor;
            Ultimo = Ultimo.Proximo;
        }

        public Eleitores Retirar(string Titulo) //Gustavo
        {
            // Este método deve receber como
            // parâmetro o título da pessoa que deve ser excluída;

            if (this.Vazia())
                return null;

            Elementos aux = this.Primeiro;

            while ((aux.Proximo!=null)&&(!aux.Proximo.MeuDado.Equals(Titulo)))
                aux = aux.Proximo;

            if (aux.Proximo == null)
            {
                return null;
            }
            else
            {
                Elementos Retirar = aux.Proximo;
                aux.Proximo = Retirar.Proximo;
                if (Retirar == this.Ultimo)
                    this.Ultimo = aux;
                else
                    Retirar.Proximo = null;

                return Retirar.MeuDado;
            }
        }

        public int CarregarDados(string nomeArquivo) //Lorena
        {
            int cont = 0;

            if (!File.Exists(nomeArquivo))
            {
                Console.WriteLine("O arquivo " + nomeArquivo + " não existe.");
                return -1;
            }

            StreamReader arquivoLeitura = new StreamReader(nomeArquivo);
            string linha;
            string[] vetorAux;

            while (!arquivoLeitura.EndOfStream)
            {
                cont++;
                linha = arquivoLeitura.ReadLine();
                vetorAux = linha.Split('-');
                if (vetorAux.Length == 5)
                {
                    string Nome = vetorAux[0];
                    char Sexo = Convert.ToChar(vetorAux[1]);
                    string Titulo_Eleitor = vetorAux[2];
                    int Zona_Eleitoral = int.Parse(vetorAux[3]);
                    int Secao_Eleitoral = int.Parse(vetorAux[4]);

                    Eleitores eleitores = new Eleitores(Nome, Sexo, Titulo_Eleitor, Zona_Eleitoral, Secao_Eleitoral);
                    this.Inserir(eleitores);
                }
            }

            arquivoLeitura.Close();

            return cont;
        }

        public Lista EleitoresPorSecao(int zona, int secao) //Lorena
        {
            // localiza, na lista de eleitores, aqueles que pertençam à zona e seção especificados. 
            // Este método retorna uma lista com os eleitores encontrados.
            Lista epzes = new Lista(); //criando a lista que vai abrigar as pessoas daquela zona e seção
            Elementos auxiliar = Primeiro.Proximo;

            while (auxiliar != null)
            {
                if (auxiliar.MeuDado.Equals(zona, secao))
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

            sexo = char.ToUpper(sexo);
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
            if (this.Vazia()) return "Impressão\nLista está vazia";

            StringBuilder auxImpressao = new StringBuilder();
            Elementos atual = this.Primeiro.Proximo;
            while (atual != null)
            {
                auxImpressao.AppendLine(atual.MeuDado.ToString());
                atual = atual.Proximo;
            }

            return "Impressão\n" + auxImpressao.ToString();
        }
        #endregion
    }
}
