using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    public class Adium
    {
        static void Main(string[] args)
        {
            FizzBuzz(100);
        }

        public static void FizzBuzz(int limit)
        {
            for (int i = 0; i < limit; i++)
            {
                String output = "";

                if (i % 3 == 0)
                {
                    output += "Fizz";
                }
                if (i % 5 == 0)
                {
                    output += "Buzz";
                }

                if (output.Trim().Length == 0)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    Console.WriteLine(output);
                }
            }
        }

        public static int GetMostCommonNumber(int[] nums)
        {
            Dictionary<int, int> numberOccurrences = new Dictionary<int, int>();
            foreach (int num in nums)
            {
                if (numberOccurrences.ContainsKey(num))
                {
                    numberOccurrences[num]++;
                }
                else
                {
                    numberOccurrences[num] = 1;
                }
            }

            int occurrences, maxOccurrencesNumber = 0;

            foreach (var e in numberOccurrences)
            {
                if (e.Value > maxOccurrencesNumber)
                {
                    occurrences = e.Value;
                    maxOccurrencesNumber = e.Key;
                }
            }

            return maxOccurrencesNumber;
        }

        public static int GetMostCommonNumber_v2(int[] nums)
        {
            var elements = new Dictionary<int, int>();
            foreach (int num in nums)
            {
                if (elements.ContainsKey(num))
                {
                    elements[num]++;
                }
                else
                {
                    elements[num] = 1;
                }
            }

            int occ = 0;
            int max = 0;

            foreach (var e in elements)
            {
                if (e.Value > max)
                {
                    occ = e.Key;
                    max = e.Value;
                }
            }

            return occ;
        }

        public static List<int> GetEveryPrimeNumber(int limit)
        {
            List<int> correctValues = new List<int>();
            for (int i = 0; i < limit; i++)
            {
                if (IsPrime(i))
                {
                    correctValues.Add(i);
                }
            }

            return correctValues;
        }

        public static bool IsPrime(int number)
        {
            if (number <= 1)
            {
                return false;
            }

            int limit = (int)Math.Sqrt(number);

            for (int i = 2; i <= limit; i++)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }

        public static bool IsPrime_v2(int num)
        {
            if (num <= 1)
            {
                return false;
            }

            int limit = (int)Math.Sqrt(num);

            for (int i = 2; i <= limit; i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public static List<int> getAllPrime(int limit)
        {
            var resultList = new List<int>();
            for (int i = 0; i < limit; i++)
            {
                if (IsPrime_v2(i))
                {
                    resultList.Add(i);
                }
            }
            return resultList;
        }

        public int SumValue_v2(int limit)
        {
            int result = 0;
            for (int i = 0; i <= limit; i++)
            {
                result += i;
            }
            return result;
        }

        public void SumValue()
        {
            Console.WriteLine("Enter something: ");
            string input = Console.ReadLine();
            int limit;
            if (int.TryParse(input, out limit))
            {
                Console.WriteLine($"You entered: {limit}");
                if (limit == int.MaxValue || limit < 1)
                {
                    Console.WriteLine("Given value is not good");
                }
                else
                {
                    int result = 0;
                    for (int i = 0; i <= limit; i++)
                    {
                        result += i;
                    }
                    Console.WriteLine("Sum: " + result);
                }
            }
            else
            {
                Console.WriteLine("Given value is not good");
            }
        }
    }
}
