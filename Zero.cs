using System;
namespace Gary_sWholesaleGarage
{
    public class Zero  : Vehicle,IElectricVehicles
    {
        public double BatteryKWh { get; set;}
       // public string MainColor { get; set; }
        //public int MaximumOccupancy { get; set; }
   public double CurrentChargePercentage{get;set;}
     
        public void ChargeBattery()
        {
            // method definition omitted
         CurrentChargePercentage=100;
            
            
            
        }
    }
}