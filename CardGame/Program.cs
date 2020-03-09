using System;
using System.Diagnostics;

namespace CardGame
{
    public class Program
    {
        public static void Main(string[] args)
        {
            new Program();
        }

        public Program()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            int wins = 0;
            int losses = 0;

            for (int i = 0; i < 10000; i++)
            {
                bool winner = PlayGame(new Board(), new Deck());

                if (winner) wins++;
                if (!winner) losses++;
            }

            stopwatch.Stop();

            Console.WriteLine("Total time: " + (stopwatch.ElapsedMilliseconds) + " milliseconds");
            Console.WriteLine("Total wins: " + wins);
            Console.WriteLine("Total losses: " + losses);
            Console.WriteLine("Win probability: " + ((float)wins / 10000 * 100) + "%");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        private bool PlayGame(Board board, Deck deck)
        {
            board.ClearBoard();
            deck.Shuffle();

            int fails = 0;
            while (fails < 5)
            {
                if (board.IsBoardFull()) break;

                Card card = deck.DrawCard();
                if (!board.CanAddCard(card))
                {
                    fails++;
                }
                else
                {
                    board.AddCard(card);
                }
            }

            return board.IsBoardFull();
        }
    }
}
