using PROG8051_Sec_7_Week_10_Lec_1;
using PROG8051_Sec_7_Week_10_Lec_1.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorials
{
    class Program
    {
    
        static void Main(string[] args)
        {
         
            ICar lexus1 = new Lexus();
            lexus1.Honk();

            ICar bmw1 = new BMW();
            bmw1.Honk();

        }
    }
}