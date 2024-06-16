using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using LabCleanCode.Interface;

namespace LabCleanCode.Classes
{
    public class Results : IStatistics
    {
        public void ShowResultList()
        {
            List<Player> results = ReadPlayerDataFromFile("result.txt");
            DisplayPlayerData(results);
        }
        public void AddResultToList(string name, int guesses)
        {
            StreamWriter output = new StreamWriter("result.txt", append: true);
            output.WriteLine(name + "#&#" + guesses);
            output.Close();
        }
        public List<Player> ReadPlayerDataFromFile(string fileName)
        {
            List<Player> results = new List<Player>();
            using (StreamReader input = new StreamReader(fileName))
            {
                string fileRow;
                while ((fileRow = input.ReadLine()) != null)
                {
                    string[] nameAndScore = fileRow.Split(new string[] { "#&#" }, StringSplitOptions.None);
                    string name = nameAndScore[0];
                    int guesses = Convert.ToInt32(nameAndScore[1]);
                    Player player = new Player(name, guesses);
                    int position = results.IndexOf(player);
                    if (position < 0)
                    {
                        results.Add(player);
                    }
                    else
                    {
                        results[position].Update(guesses);
                    }
                }
            }
            results.Sort((player1, player2) => player1.Average().CompareTo(player2.Average()));
            return results;
        }
        public void DisplayPlayerData(List<Player> results)
        {
            Console.WriteLine("Player     Games  Average");
            foreach (Player p in results)
            {
                Console.WriteLine(string.Format("{0,-9}{1,5:D}{2,9:F2}", p.Name, p.Games, p.Average()));
            }
        }
    }
}
