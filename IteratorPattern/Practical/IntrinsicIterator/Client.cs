using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern.Practical.IntrinsicIterator {
    public class Client {
        private Iterator _iterator;
        private Aggregate _aggregate = new ConcreteAggregate();

        public void Operation() {
            // 获得迭代器
            _iterator = _aggregate.CreateIterator();

            while (!_iterator.IsDone()) {
                Console.WriteLine(_iterator.CurrentItem());
                _iterator.Next();
            }
        }

        static void Main(string[] args) {
            Client client = new Client();
            client.Operation();

            Console.ReadKey();
        }
    }
}
