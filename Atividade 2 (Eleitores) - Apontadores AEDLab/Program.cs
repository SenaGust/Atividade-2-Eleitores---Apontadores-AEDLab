using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Atividade_2__Eleitores____Apontadores_AEDLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Lista ListaEleitores = new Lista();

            #region Testando Carregar Dados
            Console.ForegroundColor = ConsoleColor.DarkMagenta;

            Console.WriteLine("\tTestando Carregar Dados");
            
            string path = "eleitores.txt";
            Console.WriteLine("Nome do arquivo: {0}", path);
            ListaEleitores.CarregarDados(path);

            Console.WriteLine(ListaEleitores.ToString());
            #endregion

            #region Testando Inserir
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine("\tTestando Inserir");

            ListaEleitores.Inserir(new Eleitores("Gustavo Sena", 'm', "52484246247", 5, 4));
            ListaEleitores.Inserir(new Eleitores("Lorena Aguilar", 'f', "86444456548", 2, 3));
            ListaEleitores.Inserir(new Eleitores("Leonardo Souxa", 'm', "13155484555", 5, 4));
            ListaEleitores.Inserir(new Eleitores("Eu não sei", 'm', "89456514879", 2, 3));
            ListaEleitores.Inserir(new Eleitores("olá, mundo", 'm', "52484246247", 5, 4));
            ListaEleitores.Inserir(new Eleitores("Luiza Polewacz", 'f', "65148454954", 2, 3));
            ListaEleitores.Inserir(new Eleitores("Bruna Vitória", 'f', "84645648855", 5, 4));

            Console.WriteLine(ListaEleitores.ToString());
            #endregion

            #region Testando criar sublistas
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("\tTestando SubListas");
            Console.WriteLine("\tMulheres");
            Console.WriteLine(ListaEleitores.EleitoresPorSexo('f').ToString());

            Console.WriteLine("\tHomens");
            Console.WriteLine(ListaEleitores.EleitoresPorSexo('m').ToString());

            Console.WriteLine("\tZona: 2\t Seção: 3");
            Console.WriteLine(ListaEleitores.EleitoresPorSecao(2,3).ToString());

            Console.WriteLine("\tZona: 5\t Seção: 4");
            Console.WriteLine(ListaEleitores.EleitoresPorSecao(5, 4).ToString());
            #endregion

            #region Testando Retirar
            Console.ForegroundColor = ConsoleColor.DarkGray;

            Console.WriteLine("\tTestando Retirar");

            Console.WriteLine("Após retirar o Titulo: 20101112394");
            ListaEleitores.Retirar("20101112394");
            Console.WriteLine(ListaEleitores.ToString());

            Console.WriteLine("Após retirar o Titulo: 10080870655");
            ListaEleitores.Retirar("10080870655");
            Console.WriteLine(ListaEleitores.ToString());
            #endregion

            //Lista list = new Lista();
            //string path = "eleitores.txt";
            //list.CarregarDados(path);
            //Console.WriteLine(list.ToString());

            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("\n\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
    }
}
