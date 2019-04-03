using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory.Practical.Example1 {
    public class Divide : Operation {
        public override double GetResult() {
            return NumberA / NumberB;
        }
    }
}
