﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.Structural.ObjectAdapter {
    public class Target : ITarget {
        public virtual void Request() {
            Console.WriteLine("Called Target Request()");
        }
    }
}
