using FluentAssertions;
using Lists;
using Xunit;

namespace DataStructure.Tests.ListTests
{
    public class LinkedListAddElementTest
    {
        [Fact]
        public void AddElement_AtFirstPositionWhenListContainsOneElement_InsertElementAtFirstPosition()
        {
            // arrange
            var linkedList = new LinkedList<int>();
            linkedList.AddLeading(10);

            // act
            linkedList.AddElement(20, 0);

            // assert
            var expectedNode = new Node<int>(10, linkedList.GetNode(1));
            var firstNode = linkedList.GetNode(0);

            firstNode.Should().BeEquivalentTo(expectedNode);
            linkedList.Lenght.Should().Be(2);
        }
    }
}
