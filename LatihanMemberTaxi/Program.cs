using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanMemberTaxi
{
    class Program
    {
        static void Main(string[] args)
        {
            Taxi taxi = new Taxi();

            taxi.DriverName = "Jono";
            taxi.OnDuty = true;
            taxi.Numpassanger = 10;

            taxi.TaxiInfo();
            taxi.PickUpPassanger();
            taxi.DropOffPassanger();
            Console.ReadKey();
        }
    }
}
