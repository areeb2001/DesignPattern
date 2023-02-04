using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public class Context
    {
        private State state;

        public Context()
        {
            state = null;
        }

        public void SetState(State s)
        {
            state = s;
            s.TodoAction();
        }

        public State GetState()
        {
            return state;
        }
    }
}
