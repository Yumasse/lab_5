﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    public class MathOperations
    {
        public int Add(int a, int b)
        {
            return a + b;

        }

        public double Add(double a, double b) 
        {
            return a + b;

        }

        public T add<T>(T a, T b)
        {
            dynamic x = a;
            dynamic y = b;
            return x + y;
        }







    }
}
