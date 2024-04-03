using Problems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutinsTests
{
    public class Test_IsPalindromeNumber
    {
        [Fact]
        public void IsPalindromeNumber_CorrectSolution_v1()
        {
            Assert.True(IsPalindromeNumber.Solution(101));
        }

        [Fact]
        public void IsPalindromeNumber_CorrectSolution_v2()
        {
            Assert.True(IsPalindromeNumber.Solution(11011));
        }

        [Fact]
        public void IsPalindromeNumber_CorrectSolution_v3()
        {
            Assert.False(IsPalindromeNumber.Solution(1011));
        }

        [Fact]
        public void IsPalindromeNumber_CorrectSolution_v4()
        {
            Assert.False(IsPalindromeNumber.Solution(111011));
        }
    }
}
