﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace town
{
    class Program
    {
        static void Main(string[] args)
        {
            var house = new TownsBuilding("house");
            Console.WriteLine(house.ToString());
        }
    }
}
