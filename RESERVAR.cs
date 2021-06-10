using System;
using System.Collections.Generic;
using System.Text;

namespace AgenciaDeViajesTaolin
{
    class RESERVAR
    {
        //Constructor
        public RESERVAR()
        {

        }
        //Declaración de datos miembro.
        protected int touristicSpot;
        protected int peoplesQuantity;


        //Método Reservas con DOS parámetros
        public RESERVAR(int touristicSpot, int peoplesQuantity)
        {
            this.touristicSpot = touristicSpot;
            this.peoplesQuantity = peoplesQuantity;
        }
        public void Informacion()
        {
            if (touristicSpot == 1)
            {
                Console.WriteLine("Destino turístico: " + touristicSpot + ".- Tatooine.");
            }
            else if (touristicSpot == 2)
            {
                Console.WriteLine("Destino turístico: " + touristicSpot + ".- Alderaan.");
            }
            else if (touristicSpot == 3)
            {
                Console.WriteLine("Destino turístico: " + touristicSpot + ".- Yavin IV.");
            }
            else if (touristicSpot == 4)
            {
                Console.WriteLine("Destino turístico: " + touristicSpot + ".- Hoth.");
            }
            Console.WriteLine("Número de personas: " + peoplesQuantity);
        }


        //Finalizer
        ~RESERVAR()
        {
            touristicSpot = 0;
            peoplesQuantity = 0;

        }
        //Get set para peoplesQuantity
        public int Personas
        {
            get
            {
                return peoplesQuantity;
            }
            set
            {
                if (value <= 0)
                {
                    peoplesQuantity = 0;
                }
                else
                {
                    peoplesQuantity = value;
                }
            }
        }
        //Get set para touristic spot
        public int Destino
        {
            get
            {
                return touristicSpot;
            }
            set
            {
                touristicSpot = value;
            }
        }
       
    }
}
