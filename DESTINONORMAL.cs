using System;
using System.Collections.Generic;
using System.Text;

namespace AgenciaDeViajesTaolin
{
    class DESTINONORMAL: RESERVAR
    {
        //Declaración de datos miembros    
        private double precioDelViaje = 0.0;
        private int destinoElegido;
        private int paqueteDeViaje;
        // private double cargoExtra = 0.05;
        protected double descuento = 0.10;

        public DESTINONORMAL(int touristicSpot, int peoplesQuantity, double precioDelViaje, int destinoElegido,
        int paqueteDeViaje, double descuento) : base(touristicSpot, peoplesQuantity)
        {
            this.precioDelViaje = precioDelViaje;
            this.destinoElegido = destinoElegido;
            this.paqueteDeViaje = paqueteDeViaje;
            this.descuento = descuento;
        }
        public DESTINONORMAL(int touristicSpot, int peoplesQuantity) : base(touristicSpot, peoplesQuantity)
        {

        }

        public void ObtenerPrecioNormalSimple()
        {
            //Método heredado de la clase padre
            Informacion();
            if (touristicSpot == 2)
            {
                double subtotal = 18700 * peoplesQuantity;
                System.Console.WriteLine("El precio del viaje a Tatooine es de: " + subtotal);
                System.Console.WriteLine("El cálculo no incluye cargos extra ni descuentos. Para más detalles planifica un viaje en la opción 1 del menú.");
            }
            else if (touristicSpot == 2)
            {
                double subtotal = 7900 * peoplesQuantity;
                System.Console.WriteLine("El precio del viaje a Hoth es de: " + subtotal);
                System.Console.WriteLine("El cálculo no incluye cargos extra ni descuentos. Para más detalles planifica un viaje en la opción 1 del menú.");
            }
        }
        public void ObtenerPrecioNormal()
        {
            System.Console.WriteLine("****************************");
            System.Console.WriteLine("***** Destino normal *****");
            System.Console.WriteLine("****************************");
            //Método heredado de la clase padre
            Informacion();
            if (paqueteDeViaje == 1)
            {
                System.Console.WriteLine("****************************");
                System.Console.WriteLine("*****  Paquete Bronce  *****");
                System.Console.WriteLine("****************************");
                System.Console.WriteLine("El costo por persona es de " + precioDelViaje);
                // System.Console.WriteLine("El cargo extra por las " + Personas + " personas es de " + (precioDelViaje*peoplesQuantity)*0.05);
                double total = (precioDelViaje * peoplesQuantity) - ((precioDelViaje * peoplesQuantity) * 0.10);
                System.Console.WriteLine("El descuento del 10% queda en " + ((precioDelViaje * peoplesQuantity) * 0.10));
                System.Console.WriteLine("El costo total es de " + total);
            }
            else if (paqueteDeViaje == 2)
            {
                double precioextra = 5000;
                System.Console.WriteLine("****************************");
                System.Console.WriteLine("*****  Paquete Plata  *****");
                System.Console.WriteLine("****************************");
                System.Console.WriteLine("El costo por persona es de " + precioDelViaje);
                System.Console.WriteLine("El cargo extra por persona es de " + (precioextra * peoplesQuantity));
                double total = ((precioDelViaje * peoplesQuantity) + (precioextra * peoplesQuantity)) - ((precioDelViaje * peoplesQuantity) * 0.10);
                System.Console.WriteLine("El descuento del 10% queda en " + ((precioDelViaje * peoplesQuantity) * 0.10));
                System.Console.WriteLine("El costo total es de " + total);
            }
            else if (paqueteDeViaje == 3)
            {
                double precioextra = 9000;
                System.Console.WriteLine("****************************");
                System.Console.WriteLine("*****  Paquete Oro  *****");
                System.Console.WriteLine("****************************");
                System.Console.WriteLine("El costo por persona es de " + precioDelViaje);
                System.Console.WriteLine("El cargo extra por persona es de " + (precioextra * peoplesQuantity));
                double total = ((precioDelViaje * peoplesQuantity) + (precioextra * peoplesQuantity)) - ((precioDelViaje * peoplesQuantity) * 0.10);
                System.Console.WriteLine("El descuento del 10% queda en " + ((precioDelViaje * peoplesQuantity) * 0.10));
                System.Console.WriteLine("El costo total es de " + total);
            }

        }
        public void limpiarPlaneacionNormal()
        {
            //Método heredado de la clase padre
            Informacion();
        }
        ~DESTINONORMAL()
        {
            touristicSpot = 0;
            peoplesQuantity = 0;
            precioDelViaje = 0.00;
            destinoElegido = 0;
            paqueteDeViaje = 0;
            descuento = 0.10;
            Console.Write("Los valores han sido reseteados");
        }
    }
}
