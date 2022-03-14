using System;

namespace Gary_sWholesaleGarage
{
    public interface IElectricVehicles
    {
        double BatteryKWh{get;set;}
        double CurrentChargePercentage{get;set;}
 
        void ChargeBattery();
        
    }
}