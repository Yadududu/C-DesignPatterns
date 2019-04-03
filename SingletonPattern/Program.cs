using SingletonPattern.Structural;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SingletonPattern {
    class Program {
        //static void Main(string[] args) {
        //    // 创建一个实例s1
        //    Singleton s1 = Singleton.Instance();
        //    // 创建一个实例s2
        //    Singleton s2 = Singleton.Instance();

        //    if (s1 == s2) {
        //        Console.WriteLine("对象为相同实例");
        //    }

        //    Console.ReadKey();
        //}

        static void Main(string[] args) {
            Thread t1 = new Thread(new ThreadStart(Display));
            t1.Start();

            Thread t2 = new Thread(new ThreadStart(Display));
            t2.Start();

            Console.ReadKey();
        }

        public static void Display() {
            Singleton s = Singleton.Instance();
            Console.WriteLine("Singleton：" + s.GetHashCode());
        }
    }
}
