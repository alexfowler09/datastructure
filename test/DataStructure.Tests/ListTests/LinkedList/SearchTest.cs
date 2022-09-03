using FluentAssertions;
using Lists;
using Xunit;

namespace DataStructure.Tests.ListTests
{
    public class SearchTest
    {
        private readonly LinkedList<int> linkedList;

        public SearchTest()
        {
            linkedList = new LinkedList<int>();
        }

        [Fact]
        public void Search_WhenElementIsFound_ReturnsElementIndex()
        {
            // arrange
            linkedList.Add(5);
            linkedList.Add(15);
            linkedList.Add(10);
            linkedList.Add(17);

            // act
            var index = linkedList.Search(10);

            // assert
            index.Should().Be(2);
        }

        [Fact]
        public void Search_WhenElementIsNotFound_ReturnsInvalidIndex()
        {
            // arrange
            linkedList.Add(5);
            linkedList.Add(15);
            linkedList.Add(10);
            linkedList.Add(17);

            // act
            var index = linkedList.Search(25);

            // assert
            index.Should().Be(-1);
        }
    }
}
