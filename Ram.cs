using System;
namespace  Gary_sWholesaleGarage
{
    public class Ram : Vehicle, IGasVehicles // Gas powered truck
    {
      
      

            public double FuelCapacity{get; set;}
            public double CurrentTankPercentage{get;set;}
        public void RefuelTank()
        {
            // method definition omitted
            FuelCapacity=50;
            CurrentTankPercentage=100;
        }

         public override void Drive()
        {
            Console.WriteLine($"{MainColor} Ram goes RRrrrrrummbbble");
            Console.WriteLine(Turn);
        }
        public override void Stop()
        {
            Console.WriteLine("The ram goes stop after awhile");
        }
    }
}