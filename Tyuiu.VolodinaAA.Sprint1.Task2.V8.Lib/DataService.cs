﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.VolodinaAA.Sprint1.Task2.V8.Lib
{
    public class DataService : ISprint1Task2V8
    {
        public int CalculatePerimetr(int a, int b)
        {
            return (a + b) * 2;
        }
    }
}
