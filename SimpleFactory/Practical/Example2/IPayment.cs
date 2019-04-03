using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory.Practical.Example2 {
    public interface IPayment {
        bool Payfor(decimal money);
    }
}
