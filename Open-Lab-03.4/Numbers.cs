using System;
using System.Collections.Generic;
using System.Text;

namespace EvenOrOdd
{
    class Numbers
    {
        public static string EvenOrOdd(int number)
        {
            string a = "even";
            string b = "odd";
            if (number % 2 == 0)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
    }
}
