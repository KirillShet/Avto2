using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Class2: Class1
    {
        public override void info()
        {
            base.info();
            massa = 15000;
        }
        public override void out_info()
        {
            base.out_info();
        }
    }
}
