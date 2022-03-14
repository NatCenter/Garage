using System;
using System.Collections.Generic;

namespace Gary_sWholesaleGarage
{
    class Program
    {
        static void Main (string[] args)
        {
            Zero fxs = new Zero();
            Zero fx = new Zero();
            Tesla modelS = new Tesla();

            List<IElectricVehicles> electricVehicles = new List<IElectricVehicles>() {
                fx, fxs, modelS
            };

            modelS.Name="Model S";
            modelS.CurrentChargePercentage=37;
        fxs.CurrentChargePercentage=20;

        fx.CurrentChargePercentage=45;

            Console.WriteLine("Electric Vehicles");
            foreach(IElectricVehicles ev in electricVehicles)
            {
                Console.WriteLine($"{ev.CurrentChargePercentage}");
            }

            foreach(IElectricVehicles ev in electricVehicles)
            {
                // This should charge the vehicle to 100%
                ev.ChargeBattery();
            }

            foreach(IElectricVehicles ev in electricVehicles)
            {
                Console.WriteLine($"{ev.CurrentChargePercentage}");
            }

            /***********************************************/

            Ram ram = new Ram ();
            Cessna cessna150 = new Cessna ();
            ram.CurrentTankPercentage=50;
            cessna150.CurrentTankPercentage=90;

            List<IGasVehicles> gasVehicles = new List<IGasVehicles>() {
                ram, cessna150
            };

            Console.WriteLine("Gas Vehicles");
            foreach(IGasVehicles gv in gasVehicles)
            {
                Console.WriteLine($"{gv.CurrentTankPercentage}");
            }
        Console.WriteLine("Gassed up ");
            foreach(IGasVehicles gv in gasVehicles)
            {
                // This should completely refuel the gas tank
                
                gv.RefuelTank();
            }

            foreach(IGasVehicles gv in gasVehicles)
            {
                Console.WriteLine($"{gv.CurrentTankPercentage}");
            }
        }
    }
}