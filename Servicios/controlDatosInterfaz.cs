using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5MixCondicionalYBucles.Servicios
{
    internal interface controlDatosInterfaz
    {
        /// <summary>
        /// Cabecera del metodo que pide el mes
        ///  jzg - 071123
        /// </summary>
        /// <returns></returns>
        public int pedirMes();

        /// <summary>
        /// Cabecera del metodo que pide el año
        ///  jzg - 071123
        /// </summary>
        /// <returns></returns>
        public int pedirAnyo();

    }
}
