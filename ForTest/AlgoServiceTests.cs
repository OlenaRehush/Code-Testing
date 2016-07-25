using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Logic;
using System.Collections;

namespace ForTest
{
    [TestFixture]
    class AlgoServiceTests
    {
        [Test]
        public void DoubleSum_When_given_a_data_Then_retuns_Double_Sum_of_elements()
        {
            //Arrange
            var algoService = new AlgoService();
            var collection = new List<int>{1,2,3};

            //Act
            var result = algoService.DoubleSum(collection);

            //Assert
            Assert.That(result, Is.EqualTo(12));
        }

        [Test]
        public void MinValue_When_given_a_data_Then_return_minimum_value_of_elements()
        {
            //Arrange
            var algoService = new AlgoService();
            var collection = new List<int> { 1, 2, 3 };

            //Act
            var result = algoService.MinValue(collection);

            //Assert
            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        [TestCase(1,-4,2,3)]
        public void Function_When_parameter_b_is_negative_Then_throws_exception(int a, double b, int c, double d)
        {   
            //Arrange
            var algoService = new AlgoService();

            //Act, Assert
            Assert.Throws<ArgumentException>(()=>algoService.Function(a,b,c,d));
        }

        [Test]
        public void GetAvarage_When_given_a_data_Then_retuns_avarage_of_elements()
        {
            //Arrange
            var algoService = new AlgoService();
            var collection = new List<int> { 1, 2, 3 };

            //Act
            var result = algoService.GetAverage(collection);

            //Assert
            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        public void Sqr_When_given_an_element_Then_retuns_square_element()
        {
            //Arrange
            var algoService = new AlgoService();

            //Act
            var result = algoService.Sqr(2);

            //Assert
            Assert.That(result, Is.EqualTo(4));
        }
    }
}
