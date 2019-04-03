using SimpleFactory.Practical.Example1;
using SimpleFactory.Practical.Example2;
using SimpleFactory.Structural.AbstractRealize;
using SimpleFactory.Structural.StructuralInterfaceImplementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory {
    //class Program {
    //    static void Main(string[] args) {
    //        Product product = Factory.CreateProduct();
    //        Console.WriteLine("Created {0}", product.GetType().Name);

    //        Console.ReadKey();
    //    }
    //}


    //class Program {
    //    static void Main(string[] args) {
    //        IProduct product = Factory2.Create();
    //        Console.WriteLine(product.ToString());
    //        //product.Display();

    //        Console.ReadKey();
    //    }
    //}


    //class Program {
    //    static void Main(string[] args) {
    //        Operation operateion = OperationFactory.CreateOperate("+");
    //        operateion.NumberA = 10;
    //        operateion.NumberB = 5;

    //        Console.WriteLine(operateion.GetResult());

    //        Console.ReadKey();
    //    }
    //}


    class Program {
        static void Main(string[] args) {
            OrderService orderService = new OrderService();
            Console.WriteLine(orderService.CreateOrder("ABC"));

            Console.ReadKey();
        }
    }
}
