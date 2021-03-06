﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise10
{
   abstract class Vehicle
    {
        public string Type { get; set; }

        public Vehicle(string type)
        {
            this.Type = type;
        }

        public virtual string DecsribeVehicle()
        {
            return $"This vehicle is a {Type}";
        }
    }
}
