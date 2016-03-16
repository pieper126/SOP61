using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestASP
{
    public class Calculator
    {
        public int Plus(int first, int second)
        {
            return first + second;
        }

        public int Min(int first, int second)
        {
            return first - second;
        }

        public int Keer(int first, int second)
        {
            return first * second;
        }
    }
}