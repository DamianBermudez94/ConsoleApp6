using System;
using ConsoleTables;
namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] temSemana = new[] { 14.5, 7, 8.5, 16.8, 10, 3.7, 2 }; 
            do
            {
                Console.Clear();
                #region MenuPrincipal
                int intOpcion;
                Console.Clear();
                Console.WriteLine("Menu principal");
                Console.WriteLine("0-Salir");
                Console.WriteLine("1-Ingresar datos");
                Console.WriteLine("2-Modificar datos");
                Console.WriteLine("3-listar datos");
                Console.WriteLine("4-Estadisticas de datos");
                Console.WriteLine("5-Listado estadisticos");
                Console.WriteLine("6-Ordenar datos");
                Console.WriteLine("7-Reiniciar");
                Console.WriteLine();

                do
                {
                    Console.Write("Ingrese una opcion del menu:");
                    if (!int.TryParse(Console.ReadLine(), out intOpcion))
                    {
                        Console.WriteLine("opcion mal ingresada, por favor verificar la opcion ingresada");
                    }
                    else
                    {
                        break;
                    }

                } while (true);
                #endregion

                #region opcionElegida
                string opcionElegida;
                switch (intOpcion)
                {
                    case 0:
                        Environment.Exit(0);
                        break;
                    case 1:
                        opcionElegida = "Ingreso de datos";
                        IngresarDatos(opcionElegida,temSemana);
                        break;
                    case 2:
                        opcionElegida = "Modificacion de datos";
                        ModificarDatos(opcionElegida,temSemana);
                        break;
                    case 3:
                        opcionElegida = "Listados de datos";
                        listarDatos(opcionElegida,temSemana);
                        break;
                    case 4:
                        opcionElegida = "Estadisticas de datos";
                        EstadisticasDeDatos(opcionElegida,temSemana);
                        break;
                    case 5:
                        opcionElegida = "Listado de datos";
                        ListadoEstadistico(opcionElegida,temSemana);
                        break;
                    case 6:
                        opcionElegida = "Ordenar datos";
                        OrdenarDatos(opcionElegida,temSemana);
                        break;
                    default:
                        Console.WriteLine("Opcion no valida");
                        break;
                }
                #endregion 

            } while (true);

        }

        private static void OrdenarDatos(string opcionElegida, double[] temSemana)
        {
            NewMethod(opcionElegida);
            //TODO:Desarrollar ingreso de datos
            NewMethod1(opcionElegida);
        }

        private static void NewMethod(string opcionElegida)
        {
            Console.Clear();
            Console.WriteLine($"{opcionElegida}");
        }

        private static void ListadoEstadistico(string opcionElegida, double[] temSemana)
        {
            NewMethod(opcionElegida);
            //TODO:Desarrollar ingreso de datos
            NewMethod1(opcionElegida);
        }

        private static void EstadisticasDeDatos(string opcionElegida, double[] temSemana)
        {
            NewMethod(opcionElegida);
            //TODO:Desarrollar ingreso de datos
            NewMethod1(opcionElegida);
        }

        private static void listarDatos(string opcionElegida, double[] temSemana)
        {
            var tabla = new ConsoleTable("Tempetatura");
            NewMethod(opcionElegida);
            for (int i = 0; i < temSemana.Length; i++)
            {
                tabla.AddRow(i+1,temSemana[i]);
            }
            tabla.Write();
            NewMethod1(opcionElegida);
        }

        private static void ModificarDatos(string opcionElegida, double[] temSemana)
        {
            NewMethod(opcionElegida);
            var tabla = new ConsoleTable("Tempetatura");
            NewMethod(opcionElegida);
            for (int i = 0; i < temSemana.Length; i++)
            {
                tabla.AddRow(i + 1, temSemana[i]);
            }
            tabla.Write();
            NewMethod1(opcionElegida);
            var IntIndex=0;
            do
            {
                Console.Write("Ingrese el nro de elemento a modificar:");
                if (!int.TryParse(Console.ReadLine(), out IntIndex))
                {
                    Console.WriteLine("Error... indice mal ingresado");
                }
                else if (IntIndex<0 || IntIndex>6)
                {
                    Console.WriteLine("Indice fuera del rando permitido, verificar el indice ingresado");
                }
                else
                {
                    break;
                }

            } while (true);
            

            Console.WriteLine($"El alemento {IntIndex} del vector es {temSemana[IntIndex]}");
            Console.Write("Ingrese la nueva temperatura:");
            temSemana[IntIndex] = double.Parse(Console.ReadLine());
            NewMethod1(opcionElegida);
        }

        private static void IngresarDatos(string opcionElegida, double[] temSemana)
        {
            NewMethod(opcionElegida);
            //TODO:Desarrollar ingreso de datos
            NewMethod1(opcionElegida);
        }

        private static void NewMethod1(string opcionElegida)
        {
            Console.WriteLine($"Fin de {opcionElegida} de datos");
            Console.ReadLine();
        }
    }
}
