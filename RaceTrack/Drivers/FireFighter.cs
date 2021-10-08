using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RaceTrack.RaceTrack.Cars;

namespace RaceTrack.RaceTrack.Drivers
{
    public class FireFighter : Driver
    {
        public FireFighter(RaceCar car) : base(car)
        {
            Name = "Fire Fighter";
            SkillLevel = 8;
        }

        public override void Drive()
        {
            Car.Accelerate(SkillLevel);
        }
    }
}
