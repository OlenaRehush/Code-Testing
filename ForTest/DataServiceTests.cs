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
    class DataServiceTests
    {
        [Test]
        [TestCase(-2)]
        [TestCase(-5)]
        public void Ctr_When_given_negative_argumen_Then_throws_exception(int capacity)
        {
            //Act
            Assert.Throws<ArgumentOutOfRangeException>(() => new DataService(capacity));
        }

        [Test]
        public void AddItem_When_given_an_element_Then_the_element_added()
        {
            //Arrange
            var dataService = new DataService(4);
            var list = new List<int> { 1, 2, 3, 4, 5 };

            //Act
            dataService.AddItem(1);
            dataService.AddItem(2);
            dataService.AddItem(3);
            dataService.AddItem(4);
            dataService.AddItem(5);

            //Assert
            Assert.That(dataService.GetAllData(), Is.EqualTo(list));
        }

        [Test]
        public void ItemCount_When_given_data_Then_returns_count_of_elements()
        {
            //Arrange
            var dataService = new DataService(4);

            //Act
            dataService.AddItem(1);
            dataService.AddItem(2);
            dataService.AddItem(3);
            dataService.AddItem(4);

            //Assert
            Assert.That(dataService.ItemsCount(), Is.EqualTo(4));
        }

        [Test]
        [TestCase(6)]
        [TestCase(-4)]
        public void GetElementAt_When_given_element_greater_then_count_of_list_or_negative_Then_throws_exception(int index)
        {
            //Arrange
            var dataService = new DataService(4);

            //Act
            dataService.AddItem(1);
            dataService.AddItem(2);
            dataService.AddItem(3);
            dataService.AddItem(4);
            dataService.AddItem(5);

            //Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => dataService.GetElementAt(index));
        }

        public void GetElementAt_When_given_index_Then_returns_correct_element_of_data()
        {
            //Arrange
            var dataService = new DataService(4);

            //Act
            dataService.AddItem(1);
            dataService.AddItem(2);
            dataService.AddItem(3);
            dataService.AddItem(4);
            dataService.AddItem(5);

            //Assert
            Assert.That(dataService.GetElementAt(2), Is.EqualTo(3));
        }

        [Test]
        [TestCase(6)]
        [TestCase(-4)]
        public void RemoveAt_When_given_element_greater_then_count_of_list_or_negative_Then_throws_exception(int index)
        {
            //Arrange
            var dataService = new DataService(4);

            //Act
            dataService.AddItem(1);
            dataService.AddItem(2);
            dataService.AddItem(3);
            dataService.AddItem(4);
            dataService.AddItem(5);

            //Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => dataService.RemoveAt(index));
        }

        [Test]
        public void RemoveAt_When_given_index_Then_removes_correct_element_of_data()
        {
            //Arrange
            var dataService = new DataService(4);
            var list = new List<int> { 1, 2, 4, 5 };

            //Act
            dataService.AddItem(1);
            dataService.AddItem(2);
            dataService.AddItem(3);
            dataService.AddItem(4);
            dataService.AddItem(5);

            dataService.RemoveAt(2);

            //Assert
            Assert.That(dataService.GetAllData(), Is.EqualTo(list));
        }

        [Test]
        public void ClearAll_When_Invoke_Then_all_elements_are_removed()
        {
            //Arrange
            var dataService = new DataService(4);
            var list = new List<int> { };

            //Act
            dataService.AddItem(1);
            dataService.AddItem(2);
            dataService.AddItem(3);
            dataService.AddItem(4);
            dataService.AddItem(5);
            dataService.ClearAll();

            //Assert
            Assert.That(dataService.GetAllData(), Is.EqualTo(list));
        }

        public void GetMax_When_given_a_list_of_elements_Then_returns_maximal_element()
        {
            //Arrange
            var dataService = new DataService(4);

            //Act
            dataService.AddItem(1);
            dataService.AddItem(2);
            dataService.AddItem(3);
            dataService.AddItem(4);
            dataService.AddItem(5);

            //Assert
            Assert.That(dataService.GetMax(), Is.EqualTo(5));
        }
    }
}
