using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.Practical.ObjectAdapter {
    public class Client {
        static void Main(string[] args) {
            Console.WriteLine("手机：");
            ITarget t = new Adapter(new Power());
            t.GetPower();

            Console.ReadKey();
        }
    }
}
