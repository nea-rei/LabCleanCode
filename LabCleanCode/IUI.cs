﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabCleanCode
{
    interface IUI
    {
        void PutString(string s);
        string GetString();
        void Exit();
        void Clear();
    }
}
