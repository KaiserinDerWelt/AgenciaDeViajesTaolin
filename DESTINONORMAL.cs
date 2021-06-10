using System;
using System.Collections.Generic;
using System.Text;

namespace AgenciaDeViajesTaolin
{
    class DESTINONORMAL: RESERVAR
    {
        //Declaración de datos miembros    
        private double tripPrice = 0.0;
        private int choosenDestination;
        private int choosenpackage;

        protected double discount = 0.10;

        public DESTINONORMAL(int touristicSpot, int peoplesQuantity, double tripPrice, int choosenDestination,
        int choosenpackage, double discount) : base(touristicSpot, peoplesQuantity)
        {
            this.tripPrice = tripPrice;
            this.choosenDestination = choosenDestination;
            this.choosenpackage = choosenpackage;
            this.discount = discount;
        }
        public DESTINONORMAL(int touristicSpot, int peoplesQuantity) : base(touristicSpot, peoplesQuantity)
        {

        }

        public void GetNormalPrice()
        {
            //Método heredado
            Informacion();
            if (touristicSpot == 2)
            {
                double bruttoTotal = 18700 * peoplesQuantity;
                Console.WriteLine("Precio del Viaje a Tatooine: " + bruttoTotal);
                Console.WriteLine("Costo sin gastos adicionales, calcula todos los costos en la opcion Planificar Viaje");
            }
            else if (touristicSpot == 2)
            {
                double bruttoTotal = 7900 * peoplesQuantity;
                Console.WriteLine("Precio del viaje a Hoth: " + bruttoTotal);
                Console.WriteLine("Costo sin gastos adicionales, calcula todos los costos en la opcion Planificar Viaje");
            }
        }
        public void GetPrice()
        {
            
            Console.WriteLine(" <--Destino normal.. pero cool-->");
            //Método heredado
            Informacion();
            if (choosenpackage == 1)
            {
                
                Console.WriteLine("Paquete Bronce");
                Console.WriteLine("El costo por persona es de " + tripPrice);
                double total = (tripPrice * peoplesQuantity) - ((tripPrice * peoplesQuantity) * 0.10);
                Console.WriteLine("Descuento del 10%" + ((tripPrice * peoplesQuantity) * 0.10));
                Console.WriteLine("Costo total:" + total);
            }
            else if (choosenpackage == 2)
            {
                double precioextra = 5000;

                Console.WriteLine("Paquete Plata");
                Console.WriteLine("Costo por persona:" + tripPrice);
                Console.WriteLine("Cargo extra: " + (precioextra * peoplesQuantity));
                double total = ((tripPrice * peoplesQuantity) + (precioextra * peoplesQuantity)) - ((tripPrice * peoplesQuantity) * 0.10);
                Console.WriteLine("Descuento del 10%" + ((tripPrice * peoplesQuantity) * 0.10));
                Console.WriteLine("Costo total" + total);
            }
            else if (choosenpackage == 3)
            {
                double precioextra = 9000;
                Console.WriteLine("Paquete Oro");
                Console.WriteLine("Costo por persona:" + tripPrice);
                Console.WriteLine("Cargo extra:" + (precioextra * peoplesQuantity));
                double total = ((tripPrice * peoplesQuantity) + (precioextra * peoplesQuantity)) - ((tripPrice * peoplesQuantity) * 0.10);
                Console.WriteLine("Descuento del 10 % " + ((tripPrice * peoplesQuantity) * 0.10));
                Console.WriteLine("Costo Total " + total);
            }

        }
        public void Cleaning()
        {
  
            Informacion();
        }
        ~DESTINONORMAL()
        {
            touristicSpot = 0;
            peoplesQuantity = 0;
            tripPrice = 0.00;
            choosenDestination = 0;
            choosenpackage = 0;
            discount = 0.10;
        }
    }
}
