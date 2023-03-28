using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanTaxi
{
    public class Taxi
    {
        // properties
        public string DriverName { get; set; }
        public bool OnDuty { get; set; }
        public float NumPassenger { get; set; }

        // method
        public void TaxiInfo()
        {
            Console.WriteLine("Driver Name : {0}", DriverName);
            //Console.WriteLine("On Duty : {0}", OnDuty);
            if (OnDuty)
            {
                Console.WriteLine("On Duty : Yes" );
            } else{
                Console.WriteLine("On Duty : No");
            }
            Console.WriteLine("Number of Passenger : {0}", NumPassenger);

        }

        public void PickUpPassenger()
        { 
            Console.WriteLine("{0} sedang menjemput penumpang", DriverName);
        }
        public void DropOffPassenger()
        {
            Console.WriteLine("{0} selesai menjemput penumpang", DriverName);
        }
    }
}
