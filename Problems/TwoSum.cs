namespace Problems
{
    public class TwoSum
    {
        public static int[]? Solution(int[] nums, int target)
        {
            Dictionary<int, int> numIndices = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                if (numIndices.ContainsKey(complement))
                {
                    return [numIndices[complement], i];
                }
                if (!numIndices.ContainsKey(nums[i]))
                {
                    numIndices.Add(nums[i], i);
                }
            }
            return null;
        }
    }
}
