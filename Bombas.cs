using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gasolinera_SALASTIÑO_Proyecto1
{
    class Bombas
    {


        double CantCombustible, compraCombustible;
        private Deposito tipoDeposito;
        Deposito objGasolinera = new Deposito();
        public void vender(Deposito unDeposito)
        {

        }
        
        public void TipoCombustible(Deposito unDeposito)
        {
            if(unDeposito.ObtenerCantidadDeposito <= unDeposito.Minimo)
            {
                tipoDeposito = unDeposito;
            }
        }
        public string MostrarDatosCombustible()
        {
            string Datos = "El total de galones de combustible es: " + CantCombustible.ToString() + "\nEl precio por galón es Q.";
            return Datos;
        }
        
      public void consumo(Deposito unDeposito, string tipodeVenta, double cantidaDeventa)
        {
            switch(tipodeVenta)
            {
                case "1":
                    objGasolinera.QuitarGalones(cantidaDeventa); 
                   
                    break;
                case "0":
                    objGasolinera.QuitarQuetzales(cantidaDeventa);
                    break;
            }
                
        }
        public string MostrarcantidadEnDeposito()
        {
            string datosActuales = objGasolinera.MostrarCantYPrecio();
            return datosActuales;
        }
    }
}

