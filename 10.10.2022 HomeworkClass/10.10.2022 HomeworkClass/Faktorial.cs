using System;
using System.Collections.Generic;
using System.Text;

namespace _10._10._2022_HomeworkClass
{
    class Faktorial
    {
        public static int Fack(int n)
        {
            int multiply = 1;
            for (int i = 1; i <= n; i++)
            {
                multiply *= i;
            }
            return multiply;
        }
    }
}
