using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BuilderPattern.Structural;
using BuilderPattern.Practical;

namespace BuilderPattern {
    class Program {
        static void Main(string[] args) {
            //// Create director and builders
            //Director director = new Director();

            //Builder b1 = new ConcreteBuilder1();
            //Builder b2 = new ConcreteBuilder2();

            //// Construct two products
            //director.Construct(b1);
            //Product p1 = b1.GetResult();
            //p1.Show();

            //director.Construct(b2);
            //Product p2 = b2.GetResult();
            //p2.Show();

            //Console.ReadKey();


            VehicleBuilder builder;
            // Create shop with vehicle builders
            Shop shop = new Shop();

            // Construct and display vehicles
            builder = new ScooterBuilder();
            shop.Construct(builder);
            builder.Vehicle.Show();

            builder = new CarBuilder();
            shop.Construct(builder);
            builder.Vehicle.Show();

            builder = new MotorCycleBuilder();
            shop.Construct(builder);
            builder.Vehicle.Show();

            Console.ReadKey();
        }
    }
}
