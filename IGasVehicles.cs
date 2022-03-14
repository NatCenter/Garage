using System;

namespace Gary_sWholesaleGarage
{

     public interface IGasVehicles
     {

         
         double FuelCapacity { get; set; }
          double CurrentTankPercentage{get;set;}

        public void RefuelTank();   
        
     }
}