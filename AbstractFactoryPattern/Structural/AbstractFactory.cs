﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Structural {
    public abstract class AbstractFactory {
        public abstract AbstractProductA CreateProductA();

        public abstract AbstractProductB CreateProductB();
    }

}
