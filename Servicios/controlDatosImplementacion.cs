using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5MixCondicionalYBucles.Servicios
{
    internal class controlDatosImplementacion : controlDatosInterfaz
    {
        /// <summary>
        /// Este metodo pedira el mes y lo devuelve como int
        ///  jzg - 071123
        /// </summary>
        /// <returns></returns>
        public int pedirMes()
        {
            int mes;
            do
            {
                Console.Write("Escriba un nuemro del mes: ");
                mes = Convert.ToInt32(Console.ReadLine());
            }while (mes<1|mes>12);
            


            return mes;
        }

        /// <summary>
        /// Este metodo pedira el año y lo devuelve como int
        ///  jzg - 071123
        /// </summary>
        /// <returns></returns>
        public int pedirAnyo()
        {
            Console.Write("Escriba un nuemro del año: ");
            int anyo = Convert.ToInt32(Console.ReadLine());
            return anyo;
        }



    }
}
