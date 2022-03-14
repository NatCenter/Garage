
using System;

namespace Gary_sWholesaleGarage
{
    public class Vehicle
    {
        
       
        public string MainColor { get; set; }
        public int MaximumOccupancy { get; set; }
        
        public string Turn {get;set;}

        public virtual void Drive()
        {
            Console.WriteLine("Vrooom!");
        }
       public virtual void Stop(){

            Console.WriteLine("Stops");
        }
    }
}