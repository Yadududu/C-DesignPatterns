using StatePattern.Practical;
using StatePattern.Structural;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StatePattern {
    //class Program {
    //    static void Main(string[] args) {
    //        // Setup context in a state
    //        Context c = new Context(new ConcreteStateA());

    //        // Issue requests, which toggles state
    //        c.Request();
    //        c.Request();
    //        c.Request();
    //        c.Request();

    //        Console.ReadKey();
    //    }
    //}

    class Program {
        static void Main(string[] args) {
            Task task = new Task();
            task.State = new PendingState();
            //Task task = new Task(new PendingState());
            task.Start();
            //task.Start();
            task.Cancel();

            Console.ReadKey();
        }
    }
}
