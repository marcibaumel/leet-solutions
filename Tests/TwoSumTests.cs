using Problems;

namespace Tests
{
    public class TwoSumTests
    {
        [Fact]
        public void FindTwoSum_ReturnsCorrectIndices()
        {
            // Arrange
            int[] nums = { 2, 7, 11, 15 };
            int target = 9;
            int[] expectedIndices = { 0, 1 };

            // Act
            int[] actualIndices = TwoSum.Solution(nums, target);

            // Assert
            Assert.Equal(expectedIndices, actualIndices);
        }

        [Fact]
        public void FindTwoSum_ReturnsNullWhenNoSolutionFound()
        {
            // Arrange
            int[] nums = { 2, 7, 11, 15 };
            int target = 10;

            // Act
            int[] actualIndices = TwoSum.Solution(nums, target);

            // Assert
            Assert.Null(actualIndices);
        }
    }
}