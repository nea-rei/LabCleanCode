using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LabCleanCode.Classes;

namespace LabCleanCode.Interface
{
    public interface IStatistics
    {
        List<Player> ReadPlayerDataFromFile(string fileName);
        void AddResultToList(string name, int guesses);
        void DisplayPlayerData(List<Player> results);
        void ShowResultList();
    }
}
