using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabCleanCode
{
    public class ConsoleIO : IUI
    {
        public void Clear()
        {
            //nothing
        }

        public void Exit()
        {
            Environment.Exit(0);
        }

        public string GetString()
        {
            return Console.ReadLine();
        }

        public void PutString(string s)
        {
            Console.WriteLine(s);
        }
    }
}
