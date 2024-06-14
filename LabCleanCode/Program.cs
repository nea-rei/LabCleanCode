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
            Controller controller = new Controller(game);
            controller.Run();
        }
    }
}