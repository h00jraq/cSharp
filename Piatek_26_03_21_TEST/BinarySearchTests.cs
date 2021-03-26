using Piatek_26_03_21;
using System;
using Xunit;

namespace Piatek_26_03_21_TEST
{
    public class BinarySearchTests
    {
        [Fact] //read about [Theory]
        public void Given_ArrayOfSortedElements_When_SearchMethodCalled_Then_IndexOfElementFound()
        {
            //Arrange - test preparation
            int[] myArray = { 1, 3, 5, 7, 11, 21, 24, 100 };
            var binarySearch = new BinarySearch();
            var value = 5;
            var expectedIndex = 2;
            //Act - calling tested method
            var index = binarySearch.Search(myArray, value);
            //Assert - checking test result
            Assert.Equal(expectedIndex, index);
        }
    }
}
