using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Practical {
    public class Coke : KFCDrink {
        public override void Display() {
            Console.WriteLine("可乐 + 1");
        }
    }
}
