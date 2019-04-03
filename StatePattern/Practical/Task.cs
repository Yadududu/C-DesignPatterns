using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StatePattern.Practical {
    public class Task {
        private State _state;

        public Task(State state) {
            this.State = state;
        }

        public Task() {
            // TODO: Complete member initialization
        }

        public State State {
            get {
                return _state;
            }
            set {
                _state = value;
                Console.WriteLine("State: " + _state.GetType().Name);
            }
        }

        public void Start() {
            _state.Start(this);
        }

        public void Cancel() {
            _state.Cancel(this);
        }
    }
}
