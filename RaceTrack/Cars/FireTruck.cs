using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceTrack.RaceTrack.Cars
{
    public class FireTruck : RaceCar
    { 
        public FireTruck()
        {
            Name = "Fire Truck";
            TopSpeed = 55;
        }

        public override void StartEngine()
        {
            Console.WriteLine($"The {Name} fires right up");
        }

        public override void Brake()
        {
            Console.WriteLine($"The {Name} takes a while to stop");
            base.Brake();
        }
    }
}
