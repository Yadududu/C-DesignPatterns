using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StatePattern.Practical {
    public class RunningState : State {
        public override void Start(Task task) {
            // RunningState执行Start方法转为FinishedState
            task.State = new FinishedState();
        }

        public override void Cancel(Task task) {
            // RunningState执行Cancel方法转为CancelledState
            task.State = new CancelledState();
        }
    }
}
