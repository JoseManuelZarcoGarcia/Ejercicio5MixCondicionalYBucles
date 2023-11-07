using Ejercicio5MixCondicionalYBucles.Servicios;
using System;

namespace Ejercicio5MixCondicionalYBucles.Controladores
{
    /// <summary>
    /// Clase principal 
    /// </summary>
    class Program
    {
        /// <summary>
        /// Metodo principal por el que empieza el programa
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            controlDatosInterfaz cdi = new controlDatosImplementacion();
            CalculosInterfaz ci = new CalculosImplementacion();
            int anyo, mes;
            bool bisiesto;
            string repetir = "";

            do
            {

                mes = cdi.pedirMes();
                anyo = cdi.pedirAnyo();
                bisiesto = ci.bisiesto(anyo);

                switch (mes)
                {
                    case 0:
                        Console.WriteLine("Mi compañero de al lado es Javi");

                        break;

                    case 1: case 3: case 5: case 7: case 8: case 10: case 12:
                        Console.WriteLine("\t31 dias");
                        break;

                    case 4: case 6: case 9: case 11:
                        Console.WriteLine("\t30 dias");
                        break;

                    case 2:

                        if (bisiesto == true)
                        {
                            Console.WriteLine("\t29 dias");
                        }

                        else
                        {
                            Console.WriteLine("\t28 dias");
                        }
                        break;


                    default:
                        Console.WriteLine("[info] - la opcion deseada no existe.");
                        break;
                }


                Console.WriteLine("Si desea continuar escriba s, en caso contrario escriba otra cosa ");
                repetir = Console.ReadLine();

            } while (repetir=="s");


            

        }

    }

}