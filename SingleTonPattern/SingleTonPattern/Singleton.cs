using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleTonPattern
{
    public class Singleton
    {
        public static int count;
        private Singleton()
        {
            count++;
        }

        private static Singleton uniqueinstance = null;


        public static Singleton UniqueInstance { set { uniqueinstance = value; } }


        public static Singleton getsingleton()
        {
            if (uniqueinstance == null)
            {
                if (count < 5)
                {
                    uniqueinstance = new Singleton();
                    return uniqueinstance;
                }
                else
                {
                    Console.WriteLine("Soory You cannot make More Object");
                }

            }
                return uniqueinstance;
            }
      
    }
}
