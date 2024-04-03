using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutinsTests
{
    public class Test_SearchInsertPosition
    {
        [Fact]
        public void SearchInsertPosition_ReturnCorrectIndex()
        {
            int[] nums = [1, 3, 5, 6];
            int target = 5;
            int output = 2;

            int solution = SearchInsertPosition.Solution(nums, target);

            Assert.Equal(output, solution);
        }

        [Fact]
        public void SearchInsertPosition_ReturnCorrectIndex_v2()
        {
            int[] nums = [1, 3, 5, 6];
            int target = 7;
            int output = 4;

            int solution = SearchInsertPosition.Solution(nums, target);

            Assert.Equal(output, solution);
        }
    }
}
