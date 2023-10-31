using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5MixCondicionalYBucles.Servicios
{
    internal class CalculosImplementacion : CalculosInterfaz
    {
        public bool bisiesto(int anyo) 
        {

            bool bisiesto;

            if (anyo % 4)
            {
                bisiesto = false;
            }
            else if
                (anyo % 100)
            {
                bisiesto = false;
            }
            else if (anyo % 400)
                bisiesto = true;
            else
                bisiesto= false;


            return bisiesto;

        }


    }
}
