using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StatePattern.Practical {
    public abstract class State {
        public abstract void Start(Task task);

        public abstract void Cancel(Task task);
    }
}
