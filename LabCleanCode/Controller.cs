using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabCleanCode
{
    class Controller
    {
        MooGame mooGame;
        IUI ui;
        public Controller(MooGame mooGame, IUI ui)
        {
            this.mooGame = mooGame;
            this.ui = ui;
        }
        public void Run()
        {

            Console.WriteLine("Enter your user name:\n");
            string name = ui.GetString().Trim();
            string input;

            do
            {
                string randomNumber = mooGame.CreateRandomNumber();

                Console.WriteLine("New game:\n");
                //comment out or remove next line to play real games!
                Console.WriteLine("For practice, number is: " + randomNumber + "\n");


                int nGuess = 1;
                string guess = ui.GetString().Trim();
                string bbcc = mooGame.CompareNumbers(randomNumber, guess);
                Console.WriteLine(bbcc + "\n");
                while (bbcc != "BBBB,")
                {
                    nGuess++;
                    guess = ui.GetString();
                    Console.WriteLine(guess + "\n");
                    bbcc = mooGame.CompareNumbers(randomNumber, guess);
                    Console.WriteLine(bbcc + "\n");
                }

                StreamWriter output = new StreamWriter("result.txt", append: true);
                output.WriteLine(name + "#&#" + nGuess);
                output.Close();
                Results.showResultList();
                Console.WriteLine("Correct, it took " + nGuess + " guesses\nContinue?");
                input = ui.GetString().Trim();

            } while (!input.ToLower().StartsWith("n"));
        }

        void Display()
        {

        }
    }
}
