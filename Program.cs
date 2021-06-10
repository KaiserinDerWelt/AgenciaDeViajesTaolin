using System;

namespace AgenciaDeViajesTaolin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido a la agencia de viajes Taolin");
            Console.WriteLine("Taolin Viajes,tu conexion con el mundo extraterrestre");
            Console.WriteLine("Viajes de 3 dias y 4 noches, a gran precio pero no modificables!");
            Console.WriteLine("Enhora buenaa, inicia tu reservacion ASAP y visita las tierras prometidas ya!");

    
            int option = 0;
            while (option == 0 || option == 1 || option == 2 || option == 3 || option == 4)
            {
                do
                {
                  
                    Console.WriteLine("Elige una accion: 1)Planear un viaje 2)Calcular precio $ 3)Limpiar datos");
                    var userSelection = Console.ReadLine();
                    option = int.Parse(userSelection);
                    // Estructura switch para desglosar el menu de opciones
                    //Caso Planear Viaje
                    switch (option)
                    {
                        case 1 when (option == 1): 
                            Console.WriteLine("Escoge tu destino vacacional:");
                            Console.WriteLine("1)Tatooine 2)Alderaan 3)Yavin 4)Hoth");
                            var selectedDestination = Console.ReadLine();
                            int destination = int.Parse(selectedDestination);
                            if (destination == 1)//Seleccion Tatooine
                            {
                                Console.WriteLine("Visita este planeta de clima arido desertico.\n Tu viaje incluye el prestamo del equipo de supervivencia");
                                Console.WriteLine("Paquetes Tatooine Experience : ");
                                Console.WriteLine("Escoge tu paquete: 1)Bronce 2)Plata 3)Oro");
                                var selectedPackage = Console.ReadLine();
                                int package = int.Parse(selectedPackage);
                                Console.WriteLine("Ingresa numero de viajeros");
                                var travelerQuantity = Console.ReadLine();
                                int confirmedTravelerQuantity = int.Parse(travelerQuantity);
                                double pricePerTraveler = 9600.00;
                          
                               DESTINOEXTREMO reservaextremo = new DESTINOEXTREMO(1, confirmedTravelerQuantity, pricePerTraveler, 1, package, 0.05);
                                reservaextremo.ObtenerPrecioExtremo();
                            }
                            else if (destination == 2) //Seleccion Aldreaan
                            {
                                Console.WriteLine("Visita este planeta de clima templado y paisaje Montañoso, te incluimos el botiquin antivirus");
                                Console.WriteLine("Paquetes Aldreaan Experience: ");
                                Console.WriteLine("Escoge tu paquete: 1)Bronce 2)Plata 3)Oro");
                                var selectedPackage = Console.ReadLine();
                                int package = int.Parse(selectedPackage);
                                Console.WriteLine("Ingresa numero de viajeros:");
                                var travelerQuantity = Console.ReadLine();
                                int person = int.Parse(travelerQuantity);
                                double pricePerTraveler = 18700.00;
                                DESTINONORMAL reservanormal = new DESTINONORMAL(2, person, pricePerTraveler, 2, package, 0.10);
                                reservanormal.GetPrice();
                            }
                            else if (destination == 3) // Seleccion Yavin
                            {
                                Console.WriteLine("Disfruta de este planeta de clima tropical y paisaje de jungla. Hasta hay leones!");
                                Console.WriteLine("Paquetes Yavin Experience");
                                Console.WriteLine("Escoge tu paquete: 1)Bronce 2)Plata 3)Oro");
                                var selectedPackage = Console.ReadLine();
                                int package = int.Parse(selectedPackage);
                                Console.WriteLine("Ingresa numero de viajeros:");
                                var travelerQuantity = Console.ReadLine();
                                int confirmedTravelerQuantity = int.Parse(travelerQuantity);
                                double pricePerTraveler = 7900.00;
                                DESTINONORMAL reservanormal = new DESTINONORMAL(3, confirmedTravelerQuantity, pricePerTraveler, 3, package, 0.10);
                                reservanormal.GetPrice();
                            }
                            else if (destination == 4) // Seleccion Hoth
                            {
                                Console.WriteLine("Disfruta este planeta de clima frio y paisaje de tundra, ve a los galacti osos polares");
                                Console.WriteLine("Paquetes Hoth Experience");
                                System.Console.WriteLine("Escoge tu paquete: 1)Bronce 2)Plata 3)Oro");
                                var selectedPackage = Console.ReadLine();
                                int package = int.Parse(selectedPackage);
                                System.Console.WriteLine("Ingresa numero de viajeros:");
                                var travelerQuantity = Console.ReadLine();
                                int confirmedTravelerQuantity = int.Parse(travelerQuantity);
                                double pricePerTraveler = 8790.00;
                               DESTINOEXTREMO reservaextremo = new DESTINOEXTREMO(4, confirmedTravelerQuantity, pricePerTraveler, 4, package, 0.05);
                                reservaextremo.ObtenerPrecioExtremo();
                            }
                            break;
                        case 2 when (option == 2): //Opcion dos del menu--> calcular precio
                            Console.WriteLine("Calcular precio");
                            Console.WriteLine("Ingresa numero de viajeros:");
                            var travelerQuantityPriceAlocation = Console.ReadLine();
                            int travelerQuantityForPrice = int.Parse(travelerQuantityPriceAlocation);
                            Console.WriteLine("Escoge tu destino-->1)Tatooine 2)Alderaan 3)Yavin IV 4)Hoth");
                            var destinationSelectionForPrice = Console.ReadLine();
                            int destinationSelectionForPriceParced = int.Parse(destinationSelectionForPrice);
                            if (destinationSelectionForPriceParced == 1)
                            {
                               DESTINOEXTREMO reservadetinosextremosimple = new DESTINOEXTREMO(1,travelerQuantityForPrice);
                                reservadetinosextremosimple.GetExtrasFreePrice();
                            }
                            if (destinationSelectionForPriceParced == 2)
                            {
                                DESTINONORMAL reservadestinonormalsimple = new DESTINONORMAL(2,travelerQuantityForPrice);
                                reservadestinonormalsimple.GetNormalPrice();
                            }
                            if (destinationSelectionForPriceParced == 3)
                            {
                                DESTINONORMAL reservadestinonormalsimple = new DESTINONORMAL(3,travelerQuantityForPrice);
                                reservadestinonormalsimple.GetNormalPrice();
                            }
                            if (destinationSelectionForPriceParced == 4)
                            {
                               DESTINOEXTREMO reservadetinosextremosimple = new DESTINOEXTREMO(4,travelerQuantityForPrice);
                                reservadetinosextremosimple.GetExtrasFreePrice();
                            }
                            break;
                        case 3 when (option == 3): // Limpiar datos
                            Console.WriteLine("Datos Limpiados");
                            Console.WriteLine("Elige una accion: 1)Planear un viaje 2)Calcular precio $ 3)Limpiar datos 4)Salir");
                            var optionsLooping = Console.ReadLine();//Loop para seleccionar otra operacion
                            option = int.Parse(optionsLooping);
                            if (option == 3)
                            {
                                Console.WriteLine("No hay nada que limpiar, reinicia la app!");
                            }
                            break;
                        case 4 when (option == 4):
                            System.Console.WriteLine("Saliendo y cerrando! Gracias por tu preferencia");
                            break;

                    }
                    if (option == 1 || option == 2)
                    {
                        Console.WriteLine("Elige una accion: 1)Planear un viaje 2)Calcular precio $ 3)Limpiar datos");
                        var secondRequest = Console.ReadLine();
                        var newRequestTwo = int.Parse(secondRequest);
                        if (newRequestTwo == 1)
                        {
                            option = newRequestTwo;
                        }
                        else if (newRequestTwo == 2)
                        {
                            option = newRequestTwo;
                        }
                        else if (newRequestTwo == 3)
                        {
                            Console.WriteLine("Datos Limpiados");
                        }
                    }
                    else if (option == 4)
                    {
                        Environment.Exit(0);
                    }
                } while (option == 1 || option == 2 || option == 3);
            }





        }
    }
}
