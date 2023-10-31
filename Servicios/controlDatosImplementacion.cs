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
        /// Este metodo pedira el mes y lo devolver como int
        /// </summary>
        /// <returns></returns>
        public int pedirMes()
        {
            Console.Write("Escriba un nuemro del mes: ");
            int mes = Convert.ToInt32(Console.ReadLine());
            return mes;
        }

        public int pedirAnyo()
        {
            Console.Write("Escriba un nuemro del año: ");
            int anyo = Convert.ToInt32(Console.ReadLine());
            return anyo;
        }


    }
}
