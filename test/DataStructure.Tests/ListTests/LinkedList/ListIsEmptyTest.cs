using FluentAssertions;
using Lists;
using Xunit;

namespace DataStructure.Tests.ListTests
{
    public class ListIsEmptyTest
    {
        private readonly LinkedList<int> linkedList;

        public ListIsEmptyTest()
        {
            linkedList = new LinkedList<int>();
        }

        [Fact]
        public void IsEmpty_WhenListIsEmpty_ReturnsTrue()
        {
            // act
            var isEmpty = linkedList.IsEmpty();

            // assert
            isEmpty.Should().BeTrue();
        }

        [Fact]
        public void IsEmpty_WhenListIsNotEmpty_ReturnsFalse()
        {
            // arrange
            linkedList.Add(10);

            // act
            var isEmpty = linkedList.IsEmpty();

            // assert
            isEmpty.Should().BeFalse();
        }
    }
}
