﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.Practical {
    /// <summary>
    /// 原味咖啡
    /// </summary>
    public class BlackCoffee : MakeCoffee {
        public override void Making() {
            Console.WriteLine("原味咖啡");
        }
    }
}
