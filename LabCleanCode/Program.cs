using System;
using System.IO;
using System.Collections.Generic;
using LabCleanCode.Interface;
using LabCleanCode.Classes;

namespace LabCleanCode
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            IGame game = new MooGame();
            IUI ui = new ConsoleIO();
            IStatistics statistics = new Results();
            Controller controller = new Controller(game, ui, statistics);
            controller.Run();
        }
    }
}