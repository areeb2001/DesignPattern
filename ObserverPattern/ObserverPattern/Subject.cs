using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class Subject
    {
        private List<observer> observers= new List<observer>();
        private int state;

        public int getState()
        {
            return state;
        }

        public void SetState(int state)
        {
            this.state = state;
            notifyAllObserver();
        }
        public void AddObserver(observer observer)
        {
            observers.Add(observer);
        }

        public void notifyAllObserver()
        {
            foreach (observer observer in observers)
            {
                observer.Update();
            }
        }
    }
}
