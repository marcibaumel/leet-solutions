using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problems;

public class SearchInsertPosition
{
    public static int Solution(int[] array, int target)
    {
        int low = 0;
        int high = array.Length - 1;

        while (low <= high)
        {
            int binarySearchMiddle = (int)Math.Floor((low + high) / 2.0);

            if (array[binarySearchMiddle] == target)
            {
                return binarySearchMiddle;
            }
            else if (array[binarySearchMiddle] < target)
            {
                low = binarySearchMiddle + 1;
            }
            else
            {
                high = binarySearchMiddle - 1;
            }
        }
        return low;
    }
}

