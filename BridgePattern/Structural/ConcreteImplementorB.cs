﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.Structural {
    public class ConcreteImplementorB : Implementor {
        public override void Operation() {
            Console.WriteLine("ConcreteImplementorB Operation");
        }
    }
}
