using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabCleanCode
{
    public class Results
    {
        //public static void showTopList()
        //{
        //    StreamReader input = new StreamReader("result.txt");
        //    List<PlayerData> results = new List<PlayerData>();
        //    string line;
        //    while ((line = input.ReadLine()) != null)
        //    {
        //        string[] nameAndScore = line.Split(new string[] { "#&#" }, StringSplitOptions.None);
        //        string name = nameAndScore[0];
        //        int guesses = Convert.ToInt32(nameAndScore[1]);
        //        PlayerData pd = new PlayerData(name, guesses);
        //        int pos = results.IndexOf(pd);
        //        if (pos < 0)
        //        {
        //            results.Add(pd);
        //        }
        //        else
        //        {
        //            results[pos].Update(guesses);
        //        }


        //    }
        //    results.Sort((p1, p2) => p1.Average().CompareTo(p2.Average()));
        //    Console.WriteLine("Player   games average");
        //    foreach (PlayerData p in results)
        //    {
        //        Console.WriteLine(string.Format("{0,-9}{1,5:D}{2,9:F2}", p.Name, p.NGames, p.Average()));
        //    }
        //    input.Close();
        //}

        public static void showTopList()
        {
            List<Player> results = ReadPlayerDataFromFile("result.txt");
            DisplayPlayerData(results);
        }

        private static List<Player> ReadPlayerDataFromFile(string fileName)
        {
            List<Player> results = new List<Player>();
            using (StreamReader input = new StreamReader(fileName))
            {
                string line;
                while ((line = input.ReadLine()) != null)
                {
                    string[] nameAndScore = line.Split(new string[] { "#&#" }, StringSplitOptions.None);
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
            results.Sort((p1, p2) => p1.Average().CompareTo(p2.Average()));
            return results;
        }

        private static void DisplayPlayerData(List<Player> results)
        {
            Console.WriteLine("Player   games average");
            foreach (Player p in results)
            {
                Console.WriteLine(string.Format("{0,-9}{1,5:D}{2,9:F2}", p.Name, p.NGames, p.Average()));
            }
        }

    }
}
