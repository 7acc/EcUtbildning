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
