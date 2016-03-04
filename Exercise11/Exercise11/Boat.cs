using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise10
{
    class Boat : Vehicle
    {
        public bool SailISSet { get; set; }

        public Boat() : base("boat")
        {
        }
        public string SailState()
        {
            return (SailISSet) ? "The sail is set, FULL SPEED AHEAD!" : "the sail is not set yet";
               
        }

        public override string DecsribeVehicle()
        {
            return base.DecsribeVehicle() + $",{SailState()}";
        }

        public void SetSail()
        {
            SailISSet = true;
           
        }

        public void TakeDownSail()
        {
            SailISSet = false;
           
        }
    }
}
