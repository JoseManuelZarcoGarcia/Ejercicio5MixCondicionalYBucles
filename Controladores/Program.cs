using Ejercicio5MixCondicionalYBucles.Servicios;

namespace Ejercicio5MixCondicionalYBucles.Controladores
{

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

            mes = cdi.pedirMes();
            anyo = cdi.pedirAnyo();
            bisiesto = ci.bisiesto(anyo);

            switch (mes)
            {
                case 0:
                    Console.WriteLine("Mi compañero de al lado es Javi");
                   
                    break;

                case 1: case 3:  case 5:  case 7: case 8:  case 10: case 12:
                    Console.WriteLine("31");
                    break;

                 case 4: case 6: case 9:case 11:
                    Console.WriteLine("30");
                    break;



                case 2:

                    if (bisiesto == true)
                    {
                        Console.WriteLine("29");
                    }

                    else
                    {
                        Console.WriteLine("28");
                    }
                    break;


                default:
                    Console.WriteLine("[info] - la opcion deseada no existe.");
                    break;
            }

        }

    }

}