using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Problems
{
    public class RomanToInteger
    {
        public static int Solution(string s)
        {
            Dictionary<char, int> map = new Dictionary<char, int>();

            map.Add('I', 1);
            map.Add('V', 5);
            map.Add('X', 10);
            map.Add('L', 50);
            map.Add('C', 100);
            map.Add('D', 500);
            map.Add('M', 1000);

            char[] chars = s.ToCharArray();

            int sum = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (map.ContainsKey(chars[i]))
                {
                    if (i + 1 < s.Length && map[s[i]] < map[s[i + 1]])
                    {
                        sum -= map[s[i]];
                    }
                    else
                    {
                        sum += map[s[i]];
                    }

                }
            }
            return sum;
        }
    }
}
