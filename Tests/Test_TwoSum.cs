using Problems;

namespace Tests
{
    public class Test_TwoSum
    {
        [Fact]
        public void FindTwoSum_ReturnsCorrectIndices()
        {int[] nums = { 2, 7, 11, 15 };
            int target = 9;
            int[] expectedIndices = { 0, 1 };

            int[] actualIndices = Problems.TwoSum.Solution(nums, target);

            Assert.Equal(expectedIndices, actualIndices);
        }

        [Fact]
        public void FindTwoSum_ReturnsCorrectIndices_v2()
        {
            int[] nums = { 2, 7, 11, 15 };
            int target = 26;
            int[] expectedIndices = { 2, 3 };

            int[] actualIndices = Problems.TwoSum.Solution(nums, target);

            Assert.Equal(expectedIndices, actualIndices);
        }

        [Fact]
        public void FindTwoSum_ReturnsNullWhenNoSolutionFound()
        {
            int[] nums = { 2, 7, 11, 15 };
            int target = 10;

            int[] actualIndices = Problems.TwoSum.Solution(nums, target);

            Assert.Null(actualIndices);
        }
    }
}