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
        public bool bisiesto(int anyo) 
        {

            bool bisiesto = false;
            /*
            if ((anyo % 4) == 0)
            {
                bisiesto = false;
            }
            else if
                ((anyo % 100) == 0)
            {
                bisiesto = false;
            }
            else if ((anyo % 400) == 0)
                bisiesto = true;
            else
                bisiesto = false;
            */

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
