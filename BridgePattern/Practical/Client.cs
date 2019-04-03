using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.Practical {
    class Client {
        static void Main(string[] args) {
            MakeCoffeeSingleton whiteCoffeeSingleton = new MakeCoffeeSingleton(new WhiteCoffee());

            // 中杯牛奶咖啡
            MediumCupCoffee mediumWhiteCoffee = new MediumCupCoffee();
            mediumWhiteCoffee.Make();

            // 大杯牛奶咖啡
            LargeCupCoffee largeCupWhiteCoffee = new LargeCupCoffee();
            largeCupWhiteCoffee.Make();

            MakeCoffeeSingleton blackCoffeeSingleton = new MakeCoffeeSingleton(new BlackCoffee());
            // 中杯原味咖啡
            MediumCupCoffee mediumBlackCoffee = new MediumCupCoffee();
            mediumBlackCoffee.Make();

            // 大杯牛奶咖啡
            LargeCupCoffee largeCupBlackCoffee = new LargeCupCoffee();
            largeCupBlackCoffee.Make();

            Console.ReadKey();
        }
    }
}
