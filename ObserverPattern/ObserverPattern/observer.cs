using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ObserverPattern
{
    public abstract class observer
    {
        protected Subject subject;

        public abstract void Update();
    }

    public class BinaryObserver:observer
    {
        public BinaryObserver(Subject subject)
        {
            this.subject = subject;
            this.subject.AddObserver(this);

        }

        public  override void Update()
        {
            Console.WriteLine("Binary string "+Convert.ToByte(subject.getState()));
        }
    }

    public class OctalObserver:observer
    {
        public OctalObserver(Subject subject)
        {
            this.subject = subject;
            this.subject.AddObserver(this);

        }

        public override void Update()
        {
            Console.WriteLine("octal string "+Convert.ToDouble(subject.getState()));
        }
    }

    public class Hexobserver:observer
    {
        public Hexobserver(Subject subject)
        {
            this.subject = subject;
            this.subject.AddObserver(this);

        }

        public override void Update()
        {
            Console.WriteLine("Hex string "+Convert.ToDouble(subject.getState()));
        }
    }
}
