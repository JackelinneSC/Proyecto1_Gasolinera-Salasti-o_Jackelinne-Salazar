using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gasolinera_SALASTIÑO_Proyecto1
{
     public class Gasolinera
    {
        //Definir atributos de la clase Gasolinera
        double cantidadCombustible;
        private double CostoPorGalon ;
        private double precioPorGalon;
        private string TipodeCombustible;
        private int limiteDeposito;
        private int minimo;
        private double PDiesel = 13.50, PRegular = 17.00, PSuper = 19;

        //Constructor de la clase "Gasolinera" con los valores de tipo de combustible, cantidad, costo, limite, minimo y precio
        public Gasolinera(string Untipo, double cantCombustible, double Uncostocombustible, double unLimite, double unMinimo, double PrecioGalon)
        {
            TipodeCombustible = Untipo;
            cantidadCombustible = cantCombustible;
            CostoPorGalon = Uncostocombustible;
            limiteDeposito = 78;
            minimo = 5;
            precioPorGalon = PrecioGalon;

        }

        public Gasolinera()
        {

        }
        /// <summary>
        /// Definir método para obtener la cantidad de galones del combustible
        /// </summary>
        /// <param name="unaCantidadDeposito">Cantidad de galones</param>
        public virtual double ObtenerCantidadDeposito
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
        public virtual string ObtenerTipoCombustible
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

                Console.Clear();
                cantidadCombustible += cantidad;
                Console.WriteLine("El depósito del combustible tiene: " + cantidadCombustible.ToString());
                return true;

            }
           

        }
        public void QuitarGalones(double cantidad)
        {
            cantidadCombustible -= cantidad;
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
            string informacion = "El tipo de combustible es: " + TipodeCombustible + "\nTiene un total de: " + cantidadCombustible.ToString() + " galones.";
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
                Console.ReadLine();
                return false;
            }
            else
            {

                precioPorGalon = unPrecio;
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\t\t\tEl precio del combustible es: Q" + precioPorGalon.ToString());
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

       // public Deposito d1 = new Deposito();
        
    }
}
