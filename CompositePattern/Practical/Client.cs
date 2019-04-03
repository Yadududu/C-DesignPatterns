using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern.Practical {
    public class Client {
        static void Main(string[] args) {
            Graphics graphics = new Graphics("全部图形");

            Circle circle = new Circle("圆形", 5);
            graphics.Add(circle);

            Rectangle rectangle = new Rectangle("矩形", 4, 5);
            graphics.Add(rectangle);

            Triangle triangle = new Triangle("三角形", 3, 4, 5);
            graphics.Add(triangle);

            graphics.Display();

            Console.ReadKey();
        }
    }
}
