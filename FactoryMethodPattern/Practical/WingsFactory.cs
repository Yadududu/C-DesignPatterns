﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern.Practical {
    public class WingsFactory : IKFCFactory {
        public KFCFood CreateFood() {
            return new Wings();
        }
    }
}
