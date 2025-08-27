using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linque01
{
    internal static class IntExtension
    {
        public static int Reverse(this int a)
        {
            int reverse = 0;
            int reminder;
            while (a != 0)
            {
                reminder = a % 10;
                reverse = reverse * 10 + reminder;
                a = a / 10;
            }
            return reverse;
        }
    }
}
