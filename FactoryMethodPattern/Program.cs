using FactoryMethodPattern.Practical;
using FactoryMethodPattern.Structural;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern {
    //class Program {
    //    static void Main(string[] args) {
    //        Factory[] factories = new Factory[2];
    //        factories[0] = new ConcreteFactoryA();
    //        factories[1] = new ConcreteFactoryB();

    //        foreach (Factory factory in factories) {
    //            Product product = factory.CreateProduct();
    //            Console.WriteLine("Created {0}", product.GetType().Name);
    //        }

    //        Console.ReadKey();
    //    }
    //}

    class Program {
        static void Main(string[] args) {
            // 定义一个鸡腿工厂
            IKFCFactory factory = new ChickenFactory();
            // 生产鸡腿
            KFCFood food1 = factory.CreateFood();
            food1.Display();
            // 生产鸡腿
            KFCFood food2 = factory.CreateFood();
            food2.Display();
            // 生产鸡腿
            KFCFood food3 = factory.CreateFood();
            food3.Display();

            Console.ReadKey();
        }
    }
}
