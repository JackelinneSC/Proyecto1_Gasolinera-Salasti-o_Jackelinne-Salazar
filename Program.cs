using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gasolinera_SALASTIÑO_Proyecto1
{
    class Program
    {
        static void Main(string[] args)
        {

            Deposito objDepositoDiesel = new Deposito("Diesel", 50, 11.00, 78, 5, 13.50);
            Deposito objDepositoRegular = new Deposito("Regular", 30, 12.50, 78, 5, 17.00);
            Deposito objDepositoSuper = new Deposito("Super", 30, 14.50, 78, 5, 19.00);

            Bombas objBomba1 = new Bombas();
            Bombas objBomba2 = new Bombas();
            Bombas objBomba3 = new Bombas();
            Bombas objBomba4 = new Bombas();
            Bombas objBomba5 = new Bombas();
            Bombas objBomba6 = new Bombas();
            Bombas objBomba7 = new Bombas();
            Bombas objDiesel = new Bombas();
          
            bool seleccion = false;
            Deposito depositoSeleccionado = new Deposito();
            while (seleccion == true)
            {
                string opcionTipoCombustible;
                opcionTipoCombustible = Console.ReadLine();
                switch (opcionTipoCombustible)
                {
                    case "1":
                        depositoSeleccionado = objDepositoDiesel;
                        seleccion = true;
                        break;
                }
            }
           
        
       /* Deposito CombustibleAUsar = new Deposito();
            bool seleccion = true;
            while (seleccion == true)
            {
                string opcion;
                opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        CombustibleAUsar = objDepositoDiesel;
                        break;
                }
            }*/
                  
        //Color de fondo y letra para el encabezado
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("\t\t\t\t\t\tGasolinera SALASTIÑO \t\t\t\t\t\t\t\t");
            //Color de fondo para el título del menú principal
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n\t\t\t\tIngreso combustible a los depósitos\t\t\t\t\t\t\t\t");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(objDepositoDiesel.MostrardatosDefault());
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine(objDepositoRegular.MostrardatosDefault());
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine(objDepositoSuper.MostrardatosDefault());
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("¿Desea ingresar una nueva cantidad de galones para Diesel?: ");
            Console.WriteLine("[1]     Si\n[0]     No");
            int opcion1 = 0;
                try
                {
                    opcion1 = int.Parse(Console.ReadLine());
                    Console.Clear();
                    if (opcion1 == 1)
                    {
                        Console.WriteLine("Ingrese la cantidad de galones:");
                        double entradaDiesel = double.Parse(Console.ReadLine());
                        bool obtenerFuncionD = objDepositoDiesel.agregarGalonesGasolina(entradaDiesel);
                        if (obtenerFuncionD)
                        {
                            Console.WriteLine("Ingrese el costo por galón: ");
                            double costoDiesel = double.Parse(Console.ReadLine());
                            objDepositoDiesel.ObtenerNuevoCosto(costoDiesel, entradaDiesel);
                        }

                    }
                    Console.WriteLine("-------------------------------------------------------");
                    Console.WriteLine(objDepositoDiesel.MostrardatosDefault());
                    Console.WriteLine("-------------------------------------------------------");
                }


                catch
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\t\t\t\t\tNo se ingresó un número válido\t\t\t");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                }

                Console.WriteLine("¿Desea ingresar una nueva cantidad de galones para gasolina Regular?: ");
                Console.WriteLine("[1]     Si\n[0]     No");
                int opcion2 = 0;
                try
                {
                    opcion2 = int.Parse(Console.ReadLine());
                    Console.Clear();
                    if (opcion2 == 1)
                    {
                        Console.WriteLine("Ingrese la cantidad de galones:");
                        double entradaRegular = double.Parse(Console.ReadLine());
                        bool obtenerFuncionR = objDepositoRegular.agregarGalonesGasolina(entradaRegular);
                        if (obtenerFuncionR)
                        {
                            Console.WriteLine("Ingrese el costo por galón: ");
                            double costoRegular = double.Parse(Console.ReadLine());
                            objDepositoRegular.ObtenerNuevoCosto(costoRegular, entradaRegular);
                        }

                    }
                    Console.WriteLine("-------------------------------------------------------");
                    Console.WriteLine(objDepositoRegular.MostrardatosDefault());
                    Console.WriteLine("-------------------------------------------------------");
                }
                catch
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\t\t\t\t\tIngrese un número válidoo\t\t\t");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                }
               
                Console.WriteLine("\n¿Desea ingresar una nueva cantidad de galones para gasolina Super?: ");
                Console.WriteLine("[1]     Si\n[0]     No");
                int opcion3 = 0;
                try
                {
                    opcion3 = int.Parse(Console.ReadLine());
                    Console.Clear();
                    if (opcion3 == 1)
                    {
                        Console.WriteLine("Ingrese la cantidad de galones:");
                        double entradaSuper = double.Parse(Console.ReadLine());
                        bool obtenerFuncionS = objDepositoSuper.agregarGalonesGasolina(entradaSuper);
                        if (obtenerFuncionS)
                        {
                            Console.WriteLine("Ingrese el costo por galón: ");
                            double costoSuper = double.Parse(Console.ReadLine());
                            objDepositoSuper.ObtenerNuevoCosto(costoSuper, entradaSuper);
                        }
                                                
                    }
                    Console.WriteLine("-------------------------------------------------------");
                    Console.WriteLine(objDepositoSuper.MostrardatosDefault());
                    Console.WriteLine("-------------------------------------------------------");
                    Console.ReadLine();

                }
                catch
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\t\t\t\tIngrese un número válido\t\t\t");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                }
                
                
                
                //Encabezado de la gasolinería
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.DarkCyan;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("\t\t\t\t\t\tGasolinera JS Coutiño\t\t\t\t\t\t\t\t");
                //Título: definir precio por galón
                Console.BackgroundColor = ConsoleColor.DarkMagenta;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\t\t\t\tDefinir precio por galón de cada tipo de combustible\t\t\t\t\t\t");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("¿Desea ingresar un nuevo precio por galones para Diesel?: ");
                Console.WriteLine("[1]     Si\n[0]     No");
                int opcion4 = 0;
                try
                {
                    opcion4 = int.Parse(Console.ReadLine());
                    if (opcion4 == 1)
                    {
                        Console.WriteLine(objDepositoDiesel.MostrarPrecios());
                        Console.WriteLine("Ingrese el nuevo precio en quetzales por galón: ");
                        double precioD = double.Parse(Console.ReadLine());
                        objDepositoDiesel.ObtenerNuevoPrecio(precioD);
                    }

                }
                catch
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\t\t\t\t\tHubo un error al ingresar un precio\t\t\t");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.WriteLine("¿Desea ingresar un nuevo precio por galones para Regular?: ");
                Console.WriteLine("[1]     Si\n[0]     No");
                int opcion5 = 0;
                try
                {
                    opcion5 = int.Parse(Console.ReadLine());
                    if (opcion5 == 1)
                    {
                        Console.WriteLine(objDepositoRegular.MostrarPrecios());
                        Console.WriteLine("Ingrese el nuevo precio en quetzales por galón: ");
                        double precioR = double.Parse(Console.ReadLine());
                        objDepositoRegular.ObtenerNuevoPrecio(precioR);
                    }

                }
                catch
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\t\t\t\t\tHubo un error a la hora de ingresar el precio\t\t\t");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.WriteLine("¿Desea ingresar un nuevo precio por galones para Super?: ");
                Console.WriteLine("[1]     Si\n[0]     No");
                int opcion6 = 0;
                try
                {
                    opcion6 = int.Parse(Console.ReadLine());
                    if (opcion6 == 1)
                    {
                        Console.WriteLine(objDepositoSuper.MostrarPrecios());
                        Console.WriteLine("Ingrese el nuevo precio en quetzales por galón: ");
                        double precioS = double.Parse(Console.ReadLine());
                        objDepositoSuper.ObtenerNuevoPrecio(precioS);
                    }

                }
                catch
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\t\t\t\t\tHubo un error a la hora de ingresar el precio\t\t\t");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                }

                Console.Clear();
                Console.BackgroundColor = ConsoleColor.DarkCyan;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("\t\t\t\t\t\tGasolinera JS Coutiño\t\t\t\t\t\t\t\t");
                //Título: definir precio por galón
                Console.BackgroundColor = ConsoleColor.DarkYellow;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\t\t\t\t\tVenta de gasolina\t\t\t\t\t\t\t\t\t");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Elija el tipo de venta: ");
                Console.WriteLine("[1]     Venta manual\n[0]     Venta automática");
                int opcion7 = 0;
                try
                {
                    opcion7 = int.Parse(Console.ReadLine());
                    if (opcion7 == 1)
                    {
                        Console.Clear();
                        Console.BackgroundColor = ConsoleColor.DarkCyan;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("\t\t\t\t\t\tGasolinera JS Coutiño\t\t\t\t\t\t\t\t");
                        //Título: definir precio por galón
                        Console.BackgroundColor = ConsoleColor.DarkYellow;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("\t\t\t\t\tVenta de gasolina\t\t\t\t\t\t\t\t\t");
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Diesel :");
                        Console.WriteLine(objDepositoDiesel.MostrarCantYPrecio());
                        Console.WriteLine("---------------------------------------");
                        Console.WriteLine("Regular");
                        Console.WriteLine(objDepositoRegular.MostrarCantYPrecio());
                        Console.WriteLine("---------------------------------------");
                        Console.WriteLine("Super");
                        Console.WriteLine(objDepositoSuper.MostrarCantYPrecio());
                        Console.WriteLine("---------------------------------------");
                        bool opciones = true;
                        while (opciones == true)
                        {
                            Console.WriteLine("Elija una bomba:");
                            Console.WriteLine("[1]     Bomba 1\n[2]     Bomba 2\n[3]     Bomba 3\n[4]     Bomba 4\n[5]     Bomba 5\n[6]     Bomba 6\n[7]     Bomba 7");
                           string ingresarOpcion = Console.ReadLine();

                            switch (ingresarOpcion)
                            {
                                case "1":
                                    Console.WriteLine("Bomba 1");
                                    Console.WriteLine("[1]     Venta por medio de galones\n[0]     Venta por medio de quetzales");
                                    string opcionG1 = Console.ReadLine();
                                    
                                    if (opcionG1 == "1")
                                    {
                                        Console.WriteLine("Que tipo de combustible desea:  \n[1] Diesel\n[2] Regular\n[3] Super");
                                        string tipo = Console.ReadLine();
                                        Console.WriteLine("Ingrese la cantidad: ");
                                        double cantidad = double.Parse(Console.ReadLine());
                                        switch (tipo)
                                        {
                                            case "1":
                                                Console.Clear();
                                                //objBomba1.consumo(opcionTipoCombustible, opcionG1,cantidad);
                                                Console.WriteLine(objDepositoDiesel.MostrarCantYPrecio());
                                              //  Console.WriteLine(objBomba1.MostrarcantidadEnDeposito());
                                                break;
                                            case "2":
                                              //  objBomba1.consumo(opcionG1, cantidad);
                                                break;
                                            case "3":
                                               // objBomba1.consumo(opcionG1, cantidad);
                                                break;
                                            default:
                                                Console.Clear();
                                                Console.WriteLine("No seleccionó ningun tipo de combustible");
                                                break;
                                        }
                                            
                                        
                                    }
                                    else
                                    {
                                        Console.BackgroundColor = ConsoleColor.Red;
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Console.WriteLine("Seleccione 1 o 0");
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.White;
                                    }
                                    break;
                                case "2":
                                    Console.WriteLine("Bomba 2");
                                    break;
                                case "3":
                                    Console.WriteLine("Bomba 3");
                                    break;
                                case "4":
                                    Console.WriteLine("Bomba 4");
                                    break;
                                case "5":
                                    Console.WriteLine("Bomba 5");
                                    break;
                                case "6":
                                    Console.WriteLine("Bomba 6");
                                    break;
                                case "7":
                                    Console.WriteLine("Bomba 7");
                                    break;
                                default:
                                    Console.WriteLine("No seleccionó ninguna opción dentro del contexto");
                                    break;
                                    
                            }
                            

                        }
                        } 

                    else
                    {
                        //Condicion con venta automática
                    }

                     }
                catch
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\t\t\t\t\tNo se ingresó un número válido\t\t\t");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                }



            Console.ReadLine();
        }
        
    }
}
