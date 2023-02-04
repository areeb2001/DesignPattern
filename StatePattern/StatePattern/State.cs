using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public abstract class State
    {
        public abstract void TodoAction();
    }

    public class startstate:State
    {
        public override void TodoAction()
        {
            Console.WriteLine("Player is in Start State");
        }

        public string tostring()
        {
            return "Start State";
        }
    }

    public class StopState : State
    {
        public override void TodoAction()
        {
            Console.WriteLine("Player is in stop State");
        }

        public string tostring()
        {
            return "Stop State";
        }
    }
}
