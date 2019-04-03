﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory.Structural.AbstractRealize {
    public class Factory {
        /// <summary>
        /// 静态方法创建Product实例
        /// </summary>
        public static Product CreateProduct() {
            return new ConcreteProduct();
        }
    }
}
