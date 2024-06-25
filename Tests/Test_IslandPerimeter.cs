using Problems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsTests
{
    public class Test_IslandPerimeter
    {
        [Fact]
        public void IslandPerimeter_CorrectSolution_v0()
        {
            Assert.Equal(4, IslandPerimeter.Solution([[1]]));
        }
    }
}
