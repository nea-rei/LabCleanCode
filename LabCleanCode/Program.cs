using System;
using System.IO;
using System.Collections.Generic;

namespace LabCleanCode
{
    class MainClass
    {

        public static void Main(string[] args)
        {
            MooGame game = new MooGame();
            IUI ui = new ConsoleIO();
            Controller controller = new Controller(game, ui);
            controller.Run();
        }
    }
}