using StatePattern;

internal class Program
{
    private static void Main(string[] args)
    {
        Context context = new Context();

        State state = new startstate();
        context.SetState(state);
        state = new StopState();
        context.SetState(state);

    }
}