using System;
using System.Collections.Generic;
using System.Text;

namespace AgenciaDeViajesTaolin
{
    class DESTINOEXTREMO: RESERVAR
    {
      //Declaración de datos miembros
    private double tripPrice=0.0;
    private int choosenDestination;
    private int choosenpackage;
    private double extraFee = 0.05;
    public DESTINOEXTREMO(int touristicSpot, int peoplesQuantity, double tripPrice, int choosenDestination, 
    int choosenpackage, double extraFee):base(touristicSpot, peoplesQuantity)
        {
            this.tripPrice=tripPrice;
            this.choosenDestination=choosenDestination;
            this.choosenpackage=choosenpackage;
            this.extraFee=extraFee;
    }
    public DESTINOEXTREMO(int touristicSpot, int peoplesQuantity):base(touristicSpot,peoplesQuantity)
    {

    }
    public void GetExtrasFreePrice()
    {
        //Método heredado
        Informacion();
        if(touristicSpot==1){
            double subtotal = 9600 * peoplesQuantity;
            Console.WriteLine("El precio del viaje a Tatooine es de: " + subtotal);
            Console.WriteLine("El cálculo no incluye cargos extra ni descuentos. Para más detalles planifica un viaje en la opción 1 del menú.");
        }else if(touristicSpot==4){
            double subtotal = 8790 * peoplesQuantity;
            Console.WriteLine("El precio del viaje a Hoth es de: " + subtotal);
            Console.WriteLine("El cálculo no incluye cargos extra ni descuentos. Para más detalles planifica un viaje en la opción 1 del menú.");
        }
    }
    public void ObtenerPrecioExtremo()
    {
        Console.WriteLine("<--Destino extremo, solo para valientes-->");
        //Método heredado 
        Informacion();
        if(choosenpackage==1){
            Console.WriteLine("Paquete Bronce");
                Console.WriteLine("Costo por persona: " + tripPrice);
                Console.WriteLine("Cargo extra por: " + Personas + " personas es de " + (tripPrice*peoplesQuantity)*0.05);
            double total = (tripPrice*peoplesQuantity)+((tripPrice * peoplesQuantity)*0.05);
            Console.WriteLine("El costo total es de "+total);
        }else if(choosenpackage==2){
            double precioextra = 5000;
            Console.WriteLine("Paquete Plata");
            Console.WriteLine("Costo por persona:" + tripPrice);
            Console.WriteLine("Precio Extra por persona:" + (precioextra*peoplesQuantity));
            Console.WriteLine("Cargo extra por:" + Personas + " personas es de " + (tripPrice*peoplesQuantity)*0.05);
            double total = (tripPrice*peoplesQuantity)+((tripPrice * peoplesQuantity)*0.05)+(precioextra*peoplesQuantity);
            Console.WriteLine("El costo total es de "+total);
        }else if(choosenpackage==3){
            double precioextra = 9000;
            Console.WriteLine("Paquete Oro ");
            Console.WriteLine("Costo por persona: " + tripPrice);
            Console.WriteLine("Precio Extra por persona:" + (precioextra*peoplesQuantity));
            Console.WriteLine("Cargo extra por: " + Personas + " personas es de " + (tripPrice*peoplesQuantity)*0.05);
            double total = (tripPrice*peoplesQuantity)+((tripPrice * peoplesQuantity)*0.05)+(precioextra*peoplesQuantity);
            Console.WriteLine("Costo total: "+total);
        }

    }
    public void limpiarPlaneacionExtremo()
    {
 
        Informacion();
    }
    ~DESTINOEXTREMO() {
       touristicSpot=0; 
        peoplesQuantity=0;
        tripPrice=0.00;
        choosenDestination=0;
        choosenpackage=0;
        extraFee=0.05;
    } 
    }
}
