using System;

namespace ProxyDesignPattern
{
    public interface INest
    {
        void Access(string name);
    }
    public class RealNest : INest
    {
        public void Access(string name)
        {
            Console.WriteLine($"{name} has access to the nest");
        }
    }
    public class SecureNestProxy : INest
    {
        private readonly INest nest;

        public SecureNestProxy(INest nest)
        {
            this.nest = nest;
        }

        public void Access(string name)
        {
            if (name == "TRex" || name == "Gigantosaurus")
            {
                Console.WriteLine($"{name} is not allowed to access the nest.");
            }
            else
            {
                this.nest.Access(name);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var secureNestProxy = new SecureNestProxy(new RealNest());

            secureNestProxy.Access("Stegosaurus");
            secureNestProxy.Access("TRex");

        }
    }
}
