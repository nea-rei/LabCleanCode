using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabCleanCode.Interface
{
    public interface IGame
    {
        string CreateRandomNumber();

        string CompareNumbers(string number, string guess);
    }
}
