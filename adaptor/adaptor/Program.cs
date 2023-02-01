using System;

namespace adaptor
{
    public class SquarePeg : ISquarepeg
    {
        public void Insert(string msg)
        {
            Console.WriteLine("SquarePeg Insert method:  " + msg);
        }
    }
    public interface IRoundPeg
    {
        void InsertIntoHole(string msg);
    }
    public interface ISquarepeg
    {
        void Insert(string msg);
    }
    public class RoundPeg : IRoundPeg
    {
        public void InsertIntoHole(string msg)
        {
            Console.WriteLine("Roundpeg insertIntohole method " + msg);
        }
    }
    public class PegAdapter : ISquarepeg, IRoundPeg
    {
        private RoundPeg roundPeg;
        private SquarePeg squarePeg;
        public PegAdapter(RoundPeg round)
        {
            roundPeg = round;
        }
        public PegAdapter(SquarePeg square)
        {
            squarePeg = square;
        }
        public void Insert(string msg)
        {
            roundPeg.InsertIntoHole(msg);
        }
        public void InsertIntoHole(string msg)
        {
            squarePeg.Insert(msg);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            RoundPeg roundPeg = new RoundPeg();
            SquarePeg squarePeg = new SquarePeg();

            squarePeg.Insert("Insert Into SquarePeg");

            ISquarepeg roundToSquare = new PegAdapter(roundPeg);
            roundToSquare.Insert("Inserting round peg ");

            roundPeg.InsertIntoHole("Inserting round peg ");

            IRoundPeg squareToRound = new PegAdapter(squarePeg);
            squareToRound.InsertIntoHole("Inserting square peg ");
        }
    }
}
