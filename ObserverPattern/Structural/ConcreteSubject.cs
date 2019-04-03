using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Structural {
    public class ConcreteSubject : Subject {
        private string _subjectState;

        /// <summary>
        /// Gets or sets subject state
        /// </summary>
        public string SubjectState {
            get { return _subjectState; }
            set { _subjectState = value; }
        }
    }
}
