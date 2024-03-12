using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG8051_Sec_7_Week_10_Lec_1.Interface
{
    internal interface ICar 
    {
        // Polymorphism
        public abstract void Honk();


        // Abstract method
        void addFuel();
    }
}
