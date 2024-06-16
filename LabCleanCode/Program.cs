using System;
using System.IO;
using System.Collections.Generic;

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