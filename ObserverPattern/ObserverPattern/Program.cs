using ObserverPattern;

internal class Program
{
    private static void Main(string[] args)
    {
        Subject subject= new Subject();
        new BinaryObserver(subject);
        new OctalObserver(subject);
        new Hexobserver(subject);
        Console.WriteLine("Second State change 15");
        subject.SetState(15);
        Console.WriteLine("Third State change 10");

        subject.SetState(10);

    }
}