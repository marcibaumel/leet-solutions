using Problems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsTests
{
    public class Test_RomanToInteger
    {
        [Fact]
        public void RomanToInteger_CorrectSolution_v0()
        {
            Assert.Equal(1, RomanToInteger.Solution("I"));
        }

        [Fact]
        public void RomanToInteger_CorrectSolution_v1()
        {
            Assert.Equal(3, RomanToInteger.Solution("III"));
        }

        [Fact]
        public void RomanToInteger_CorrectSolution_v2()
        {
            Assert.Equal(6, RomanToInteger.Solution("VI"));
        }

        [Fact]
        public void RomanToInteger_CorrectSolution_v3()
        {
            Assert.Equal(4, RomanToInteger.Solution("IV"));
        }

        [Fact]
        public void RomanToInteger_CorrectSolution_v4()
        {
            Assert.Equal(58, RomanToInteger.Solution("LVIII"));
        }

        [Fact]
        public void RomanToInteger_CorrectSolution_v5()
        {
            Assert.Equal(1994, RomanToInteger.Solution("MCMXCIV"));
        }

    }
}
