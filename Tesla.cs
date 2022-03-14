using System;
namespace Gary_sWholesaleGarage
{
    public class Tesla : Vehicle,IElectricVehicles
    {   
       public  double  BatteryKWh{get;set;}
       public double CurrentChargePercentage{get;set;}
       public string Name{get;set;}
       
        public void ChargeBattery()
        {
            // method definition omitted
            Console.WriteLine("charge your battery");
            BatteryKWh=90;
            CurrentChargePercentage=100;
            
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Tesla goes MMMMHHHHHMMM!!!");
            Console.WriteLine(Turn);
        }

        public override void Stop()
        {
            Console.WriteLine("The tesla goes stop");
        }
    }
}