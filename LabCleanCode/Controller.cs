using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using LabCleanCode.Interface;

namespace LabCleanCode
{
    class Controller
    {
        IGame game;
        IUI ui;
        IStatistics statistics;
        public Controller(IGame game, IUI ui, IStatistics statistics)
        {
            this.game = game;
            this.ui = ui;
            this.statistics = statistics;
        }
        public void Run()
        {

            string name = GetUserName();
            string playOn, randomNumber;

            do
            {
                randomNumber = game.CreateRandomNumber();

                ui.PutString("New game:\n");

                //comment out or remove next line to play real games!
                ui.PutString("For practice, number is: " + randomNumber + "\n");

                PlayGame(randomNumber, name);

                playOn = ui.GetString().Trim();

            } while (!playOn.ToLower().StartsWith("n"));
        }

        private void PlayGame(string number, string name)
        {
            int guesses = 0;
            string bullsAndCows, guess;
            do
            {
                guesses++;
                guess = ui.GetString().Trim();
                ui.PutString(guess + "\n");
                bullsAndCows = game.CompareNumbers(number, guess);
                ui.PutString(bullsAndCows + "\n");
            } while (bullsAndCows != "BBBB,");

            statistics.AddResultToList(name, guesses);
            statistics.ShowResultList();
            ui.PutString("Correct, it took " + guesses + " guesses\nContinue?");
        }

        private string GetUserName()
       {
            Console.WriteLine("Enter your user name:\n");
            return ui.GetString().Trim();
       }

    }
}
