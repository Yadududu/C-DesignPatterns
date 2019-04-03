using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern.Structural {
    public class ConcretePrototype1 : Prototype {
        /// <summary>
        /// Constructor
        /// </summary>
        public ConcretePrototype1(string id)
            : base(id) {
        }

        /// <summary>
        /// Returns a shallow copy
        /// </summary>
        /// <returns></returns>
        public override Prototype Clone() {
            return (Prototype)this.MemberwiseClone();
        }
    }
}
