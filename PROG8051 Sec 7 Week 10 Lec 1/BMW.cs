﻿using PROG8051_Sec_7_Week_10_Lec_1.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG8051_Sec_7_Week_10_Lec_1
{
    internal class BMW : ICar
    {
        public string model = "X5";
        // Polymorphism
        public void Honk()
        {
            Console.WriteLine("Honk X5");
        }
        public void addFuel()
        {
            Console.WriteLine("adds fuel");
        }
    }
}
