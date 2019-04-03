using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory.Structural.StructuralInterfaceImplementation {
    public class Product : IProduct {
        public void Display() {
            Console.WriteLine("DesignPatterns.SimpleFactoryPattern.Structural.Product");
        }
    }
}
