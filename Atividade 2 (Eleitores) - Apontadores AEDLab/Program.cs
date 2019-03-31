using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Atividade_2__Eleitores____Apontadores_AEDLab
{
    /*
     *1. Implementar classe Lista
     *2. Implementar classe Eleitores
     *3. Implementar método LeituraArquivo()
     *4. Implementar método EliminarEleitor()
     *5. Implementar método LocalizaPorSecao()
     *6. Implementar método LocalizaPorSexo()
     */
    class Program
    {
        static void Main(string[] args)
        {
            Leitura_de_arquivos();
            Console.ReadKey();
        }

        #region Leitura_de_arquivos (Lorena)
        static void Leitura_de_arquivos() 
        {
            Lista lista = new Lista();
            string path = "eleitores.txt";
            if(!File.Exists(path))
            {
                StreamWriter criar = new StreamWriter(path);
                criar.Close();
            }

            StreamReader arq = new StreamReader(path);
            string linha;
            string[] vetoraux;
           

            while(!arq.EndOfStream)
            {
                linha = arq.ReadLine();
                vetoraux = linha.Split('-');
                if(vetoraux.Length==5)
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

            

        }
        #endregion

        #region Eliminar_Eleitor (Gustavo)
        static void Eliminar_Eleitor()
        {

        }
        #endregion

        #region Localizar_por_seção (Lorena)
        static void Localizar_por_seção()
        {

        }
        #endregion

        #region Localizar_por_sexo (Gustavo)
        static void Localizar_por_sexo()
        {

        }
        #endregion 

    }
}
