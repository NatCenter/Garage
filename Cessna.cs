using System;
namespace Gary_sWholesaleGarage
{
    public class Cessna : Vehicle,IGasVehicles // Propellor light aircraft
    {
      

            public double FuelCapacity{get; set;}
            public double CurrentTankPercentage{get;set;}
        public void RefuelTank()
        {
            // method definition omitted
            FuelCapacity=100;
            
            CurrentTankPercentage=100;
            
        }

        public override void Drive()
        {
            
            Console.WriteLine($"The {MainColor} Cessna zooms by you with a HHHHHHHHHHYYYYYYEEEEOOOOO! ");
            Console.WriteLine(Turn);
        }

        public override void Stop()
        {
            Console.WriteLine("The Cessna lands with a thunk");
        }
    }
}