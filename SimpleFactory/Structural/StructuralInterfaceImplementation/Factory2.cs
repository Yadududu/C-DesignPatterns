using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory.Structural.StructuralInterfaceImplementation {
    public class Factory2 {
        /// <summary>
        /// Factory返回IProduct的静态方法
        /// </summary>
        /// <returns></returns>
        public static IProduct Create() {
            // 使用new直接创建接口的具体类
            //return new DesignPatterns.SimpleFactoryPattern.StructuralInterfaceImplementation.Product();

            // 通过映射创建接口的具体类
            return (IProduct)Assembly.Load("SimpleFactory").CreateInstance("SimpleFactory.Structural.StructuralInterfaceImplementation.Product");
        }
    }
}
