using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise10
{
    class car : Vehicle
    {
        public bool EngineIsRunnig { get; set; }


        public car() : base("car")
        {
           
        }
        public override string DecsribeVehicle()
        {
            return base.DecsribeVehicle() + $", {EngingeState()}";
        }

        public string EngingeState()
        {
            return (EngineIsRunnig) ? "the Engine is running, WROOOM WROOOM! " : "the engine is not running";
        }

        public void StartEngine()
        {
            EngineIsRunnig = true;
            
        }
        public void StopEngine()
        {
            EngineIsRunnig = false;
           
        }
    }
}
