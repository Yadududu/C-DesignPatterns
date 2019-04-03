﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StatePattern.Practical {
    public class PendingState : State {
        public override void Start(Task task) {
            task.State = new RunningState();
        }

        public override void Cancel(Task task) {
            throw new NotImplementedException();
        }
    }
}
