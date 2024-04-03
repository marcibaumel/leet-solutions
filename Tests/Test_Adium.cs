using Problems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutinsTests
{
    public class Test_Adium
    {
        [Fact]
        public void SumValue_v2_CorrectSolution_v1()
        {
            //Arrange
            var Adium = new Adium();
            int limit = 5;
            int expected = 15;

            //Act
            var result = Adium.SumValue_v2(limit);

            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void SumValue_v2_CorrectSolution_v2()
        {
            //Arrange
            var Adium = new Adium();
            int limit = 10;
            int expected = 55;

            //Act
            var result = Adium.SumValue_v2(limit);

            //Assert
            Assert.Equal(expected, result);

        }

        [Fact]
        public void IsPrime_CorrectSolution()
        {
            Assert.True(Adium.IsPrime_v2(5));
        }

        [Fact]
        public void IsPrime_ParameterNumberIsLessThanOne()
        {
            Assert.False(Adium.IsPrime_v2(-2));
        }

        [Fact]
        public void IsPrime_ParameterNumberIsNotPrime()
        {
            Assert.False(Adium.IsPrime_v2(16));
        }

        [Fact]
        public void IsPrime_ParameterNumberIsOne()
        {
            Assert.False(Adium.IsPrime_v2(1));
        }

        [Fact]
        public void GetEveryPrimeNumber_CorrectSolution()
        {
            var expected = new List<int>{ 2, 3, 5, 7 };
            int limit = 10;

            var result = Adium.GetEveryPrimeNumber(limit);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void GetAllPrime_CorrectSolution()
        {
            var expected = new List<int> { 2, 3, 5, 7 };
            int limit = 10;

            var result = Adium.getAllPrime(limit);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void GetMostCommonNumber_CorrectSolution()
        {
            var expexted = Adium.GetMostCommonNumber_v2([1, 1, 2, 3, 4, 4, 4, 5, 1000]);
            int result = 4;

            Assert.Equal(expexted, result);
        }
    }
}
