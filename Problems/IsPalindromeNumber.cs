using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    public class IsPalindromeNumber
    {
        public static bool Solution(int num)
        {
            if(num < 0)
            {
                return false;
            }
            int reversed = 0;
            int original = num;

            while(original > 0)
            {
                reversed = reversed * 10 + (original % 10);
                original = (int)Math.Floor(original / 10.0);
            }

            return num == reversed;
        }
    }
}
