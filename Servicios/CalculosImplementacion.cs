using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5MixCondicionalYBucles.Servicios
{
    /// <summary>
    /// Metodo que recibe un int y calcula si el año dado es biciesto o no
    /// jzg - 061123
    /// </summary>
    internal class CalculosImplementacion : CalculosInterfaz
    {
        /// <summary>
        /// Metodo que recibe el año y calcula si es bisiesto o no
        ///  jzg - 071123
        /// </summary>
        /// <param name="anyo"></param>
        /// <returns></returns>
        public bool bisiesto(int anyo) 
        {

            bool bisiesto = false;

            if ((anyo % 4) == 0)
            {
                bisiesto = false;

                if ((anyo % 100) == 0)
                {
                    bisiesto = false;

                    if ((anyo % 400) == 0)
                        bisiesto = true;
                    else
                        bisiesto = false;
                }
            }

                return bisiesto;

        }


    }
}
