using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gasolinera_SALASTIÑO_Proyecto1
{
    class Deposito
    {
        
        //Definir atributos de la clase Gasolinera
        double cantidadCombustible;
        private double CostoPorGalon;
        private double precioPorGalon;
        private string TipodeCombustible;
        private int limiteDeposito;
        private int minimo;


        //Constructor de la clase "Gasolinera" con los valores de tipo de combustible, cantidad, costo, limite, minimo y precio
         public Deposito(string Untipo, double cantCombustible, double Uncostocombustible, double unLimite, double unMinimo, double PrecioGalon)
        {
            TipodeCombustible = Untipo;
            cantidadCombustible = cantCombustible;
            CostoPorGalon = Uncostocombustible;
            limiteDeposito = 78;
            minimo = 5;
            precioPorGalon = PrecioGalon;

        }

        public Deposito()
        {

        }

        /// <summary>
        /// Definir método para obtener la cantidad de galones del combustible
        /// </summary>
        /// <param name="unaCantidadDeposito">Cantidad de galones</param>
        public double ObtenerCantidadDeposito
        {
            get
            {
                return cantidadCombustible;
            }
            set
            {
                if (cantidadCombustible < limiteDeposito)
                {
                    cantidadCombustible = value;
                }
            }

        }
        /// <summary>
        /// Definir método para el costo por galón
        /// </summary>
        public double ObtenerCosto
        {
            get
            {
                return CostoPorGalon;
            }
            set
            {
                if (CostoPorGalon > precioPorGalon)
                {
                    CostoPorGalon = value;
                }
            }
        }
        //Definir método para tipo de combustible        
        public string ObtenerTipoCombustible
        {
            get
            {
                return TipodeCombustible;
            }
        }
        /// <summary>
        /// Método para definir el límite de cada depósito
        /// </summary>
        /// <param name="unLimite">Límite del depósito</param>
        public int Limite
        {
            get
            {
                return limiteDeposito;
            }

        }
        /// <summary>
        /// Definir el inventario mínimo
        /// </summary>
        /// <param name="unminimo">Minímo de la bomba</param>
        public int Minimo
        {
            get
            {
                return minimo;
            }

        }
        //Método que guardará el nuevo valor de galones si no cumple la condición
        public bool agregarGalonesGasolina(double cantidad)
        {

            if ((cantidadCombustible + cantidad) > limiteDeposito)
            {

                Console.Clear();
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("La operación no es válida porque supera la capacidad del depósito");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                Console.ReadLine();
                return false;

            }
            else
            {

                cantidadCombustible += cantidad;
                return true;

            }


        }
        public bool QuitarGalones(double cantidad)
        {
            if(cantidad>0)
            {
                if (cantidadCombustible > minimo)
                {
                    if ((cantidadCombustible - cantidad) < 0)
                    {

                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("No es posible realizar esta venta");
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.White;
                        string advertencia;
                        advertencia = "Usted solo podrá comprar " + cantidadCombustible + " galones (dejando el depósito totalente vacío)\n Desea continuar con la compra: \n[1] Si \n[0] No";
                        Console.WriteLine(advertencia);
                        string continuar;
                        continuar = Console.ReadLine();
                        if (continuar == "1")
                        {
                            cantidadCombustible -= cantidadCombustible;
                            return true;
                        }
                        else
                        {
                            return false;
                        }

                    }
                    else
                    {

                        if ((cantidadCombustible - cantidad) > 0 && (cantidadCombustible - cantidad) < limiteDeposito)
                        {
                            cantidadCombustible -= cantidad;
                            return true;
                        }

                    }

                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Este depósito no está en servicio, por favor seleccione otro tipo de combustible");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                    return false;
                }

                return true;
            }
            Console.WriteLine("Ingrese un número positivo");
            return true;
        }
        public void QuitarQuetzales(double dinero)
        {
            cantidadCombustible -= precioPorGalon / dinero;
        }
        ///Método para calcular el costo actual de los galones de cada depósito   
        public void ObtenerNuevoCosto(double UnNuevoCosto, double unaNuevaCantidad)
        {
            double CostoActual;
            CostoActual = (cantidadCombustible * CostoPorGalon + unaNuevaCantidad * UnNuevoCosto) / (cantidadCombustible + unaNuevaCantidad);
            CostoPorGalon = Math.Round(CostoActual, 2);

        }
        /// <summary>
        /// Método que mostrará los datos que tienen los depósitos por defecto
        /// </summary>
        /// <returns>Datos por defecto</returns>
        public string MostrardatosDefault()

        {
            string informacion = "El tipo de combustible es: " + TipodeCombustible + "\nTiene un total de: " + cantidadCombustible.ToString() + " galones. \nEl costo es de Q." +CostoPorGalon.ToString();
            return informacion;
            //return informacion;
        }
        //Método que asignará un nuevo precio a la variable de precio
        public void DefenirPrecio(double UnPrecio)
        {
            precioPorGalon = UnPrecio;

        }
        /// <summary>
        /// Método para obtener el nuevo precio por galón de cada combustibles
        /// </summary>
        /// <param name="unPrecio">Nuevo precio por galón</param>
        /// <returns></returns>
        public bool ObtenerNuevoPrecio(double unPrecio)
        {
            if (unPrecio < CostoPorGalon)
            {
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\t\t\tEl precio ingresado generará pérdidas a la Gasolinera SALASTIÑO\t\t\t\t\t\t");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                Console.ReadLine();
                return false;
            }
            else
            {

                precioPorGalon = unPrecio;
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\t\t\tEl precio del combustible es: Q" + precioPorGalon.ToString());
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                Console.ReadLine();
                Console.Clear();
                return true;

            }
        }
        //Método que mostrará el valor del precio por galón
        public string MostrarPrecios()
        {
            string Precios = "El precio actual del combustible Q" + precioPorGalon.ToString();
            return Precios;
        }
        public string MostrarCantYPrecio()
        {
            string datosActuales = "Cantidad de galones: " + cantidadCombustible.ToString() + "\nEl precio por galón es Q." + precioPorGalon.ToString();
            return datosActuales;
        }
       /* public string MostrarConsumo()
        {
            string consumo = "Usted consumió un total de: " +cantidadCombustible.ToString()+ "El precio"
        }
        */

    }
}
