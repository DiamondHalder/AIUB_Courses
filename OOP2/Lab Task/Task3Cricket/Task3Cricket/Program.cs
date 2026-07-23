using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3Cricket
{
    internal class Program
    {
        interface ICricket
        {
            void Name();
            int JerseyNumber();
        }

        interface IBatsman : ICricket
        {
            int Score();
        }

        interface ISpinner : IBatsman
        {
            int Wicket();
        }

        interface IFastBowler
        {
            int Wicket();
        }

        class Player : ISpinner, IFastBowler
        {
            private string playerName;
            private int jerseyNumber;
            private int runsScored;
            private int wicketsTaken;

            public Player(string name, int jersey, int runs, int wickets)
            {
                playerName = name;
                jerseyNumber = jersey;
                runsScored = runs;
                wicketsTaken = wickets;
            }

            public void Name()
            {
                Console.WriteLine($"Player Name: {playerName}");
            }

            public int JerseyNumber()
            {
                return jerseyNumber;
            }

            public int Score()
            {
                return runsScored;
            }

            int ISpinner.Wicket()
            {
                return wicketsTaken; // As a Spinner
            }

            int IFastBowler.Wicket()
            {
                return wicketsTaken; // As a Fast Bowler
            }
        }

        
            static void Main(string[] args)
            {
                Player player = new Player("Tamim Iqbal", 10, 2500, 120);

                player.Name();
                Console.WriteLine("Jersey Number: " + player.JerseyNumber());
                Console.WriteLine("Score: " + player.Score());

                //  explicit casting 
                ISpinner spinner = player;
                Console.WriteLine("Wickets (as Spinner): " + spinner.Wicket());

                IFastBowler fastBowler = player;
                Console.WriteLine("Wickets (as Fast Bowler): " + fastBowler.Wicket());
            }
        
    }
}
