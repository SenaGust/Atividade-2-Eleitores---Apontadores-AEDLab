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
            Lista list = new Lista();
            string path = "eleitores.txt";
            list.CarregarDados(path);
            Console.WriteLine(list.ToString());
            Console.ReadKey();
        }

        

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
