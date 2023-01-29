using SingleTonPattern;

internal class Program
{
    private static void Main(string[] args)
    {
       
            Singleton s0 = Singleton.getsingleton();
            Console.WriteLine("Hash Code of obj 1 "+s0.GetHashCode());
            Singleton.UniqueInstance = null;

            Singleton s1 = Singleton.getsingleton();
            Console.WriteLine("Hash Code of obj 2 " + s1.GetHashCode());
            Singleton.UniqueInstance = null;

            Singleton s2 = Singleton.getsingleton();
            Console.WriteLine("Hash Code of obj 3 " + s2.GetHashCode());
            Singleton.UniqueInstance = null;

            Singleton s3 = Singleton.getsingleton();
            Console.WriteLine("Hash Code of obj  4 " + s3.GetHashCode());
            Singleton.UniqueInstance = null;
            Singleton s4 = Singleton.getsingleton();
            Console.WriteLine("Hash Code of obj  5  " + s4.GetHashCode());
            Singleton.UniqueInstance = null;
            Singleton s5 = Singleton.getsingleton();
        Console.ReadKey();


    }
}