using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Logic;

namespace ForTest
{
    [TestFixture]
    class MasterServiceTests
    {
        [Test]
        public void GetDoubleSum_When_given_a_data_Then_retuns_Double_Sum_of_elements()
        {
            //Arrange
            var data = new DataService(3);
            var algo = new AlgoService();

            //Act
            data.AddItem(1);
            data.AddItem(2);
            data.AddItem(3);
            var master = new MasterService(algo, data);

            //Assert
            Assert.That(master.GetDoubleSum(), Is.EqualTo(12));
        }

        [Test]
        public void GetDoubleSum_When_data_is_empty_Then_throws_exception()
        {
            //Arrange
            var data = new DataService(0);
            var algo = new AlgoService();
            var master = new MasterService(algo, data);

            //Act, Assert
            Assert.Throws<InvalidOperationException>(() => master.GetDoubleSum());
        }

        [Test]
        public void MinValue_When_given_data_Then_returns_minimal_element()
        {
            //Arrange
            var data = new DataService(3);
            var algo = new AlgoService();

            //Act
            data.AddItem(1);
            data.AddItem(2);
            data.AddItem(3);
            var master = new MasterService(algo, data);

            //Assert
            Assert.That(master.MinValue(), Is.EqualTo(1));
        }

        [Test]
        public void MinValue_When_data_is_empty_Then_throws_exception()
        {
            //Arrange
            var data = new DataService(0);
            var algo = new AlgoService();
            var master = new MasterService(algo, data);

            //Act, Assert
            Assert.Throws<InvalidOperationException>(() => master.MinValue());
        }

        [Test]
        public void GetAverage_When_given_data_Then_returns_average()
        {
            //Arrange
            var data = new DataService(3);
            var algo = new AlgoService();

            //Act
            data.AddItem(1);
            data.AddItem(2);
            data.AddItem(3);
            var master = new MasterService(algo, data);

            //Assert
            Assert.That(master.GetAverage(), Is.EqualTo(2));
        }

        [Test]
        public void GetAverage_When_data_is_empty_Then_throws_exception()
        {
            //Arrange
            var data = new DataService(0);
            var algo = new AlgoService();
            var master = new MasterService(algo, data);

            //Act, Assert
            Assert.Throws<InvalidOperationException>(() => master.GetAverage());
        }

        [Test]
        public void GetMaxSquare_When_given_data_Then_returns_average()
        {
            //Arrange
            var data = new DataService(3);
            var algo = new AlgoService();

            //Act
            data.AddItem(1);
            data.AddItem(2);
            data.AddItem(3);
            var master = new MasterService(algo, data);

            //Assert
            Assert.That(master.GetMaxSquare(), Is.EqualTo(9));
        }

        [Test]
        public void GetMaxSquare_When_data_is_empty_Then_throws_exception()
        {
            //Arrange
            var data = new DataService(0);
            var algo = new AlgoService();
            var master = new MasterService(algo, data);

            //Act, Assert
            Assert.Throws<InvalidOperationException>(() => master.GetMaxSquare());
        }
    }
}
