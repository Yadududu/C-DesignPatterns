using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StatePattern.Practical {
    public class FinishedState : State {
        public override void Start(Task task) {
            throw new NotImplementedException();
        }

        public override void Cancel(Task task) {
            throw new NotImplementedException();
        }
    }
}
