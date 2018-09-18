using System;
using BilletLibrary;
namespace StoreBaeltBilletLibrary
{
    public class StorebaeltBil : Bil
    {
        public override double Rabat { get; set; }


        public double WeekendRabat()
        {
            if (Date.DayOfWeek == DayOfWeek.Saturday || Date.DayOfWeek == DayOfWeek.Sunday)
            {
                return 0.80*Pris(); 
            }
            else
            {
                return Pris();
            }
           
        }

        

        public double WeekendBrobizz()
        {
            if (Date.DayOfWeek == DayOfWeek.Saturday || Date.DayOfWeek == DayOfWeek.Sunday)
            {
                return 0.95 * WeekendRabat();
            }
            else
            {
                return Brobizz();
            }
            
        }
    }
}
