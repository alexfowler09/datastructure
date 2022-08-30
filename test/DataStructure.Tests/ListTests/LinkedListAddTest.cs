using FluentAssertions;
using Lists;
using Xunit;

namespace DataStructure.Tests.ListTests
{
    public class LinkedListAddTest
    {
        private readonly LinkedList<int> linkedList;

        public LinkedListAddTest()
        {
            linkedList = new LinkedList<int>();
        }

        [Fact]
        public void Add_WhenListIsEmpty_InsertAtFirstPosition()
        {
            // act
            linkedList.Add(10);

            // assert
            linkedList.Lenght.Should().Be(1);

            var expectedNode = new Node<int>(10, null);
            var nodeAtFirstPosition = linkedList.GetNode(0);
            nodeAtFirstPosition.Should().BeEquivalentTo(expectedNode);

            linkedList.Head.Should().Be(nodeAtFirstPosition);
            linkedList.Tail.Should().Be(nodeAtFirstPosition);
        }

        [Fact]
        public void Add_WhenListIsNotEmpty_InsertAtLastPosition()
        {
            // arrange
            linkedList.Add(10);
            linkedList.Add(20);

            // act
            linkedList.Add(30);

            // assert
            linkedList.Lenght.Should().Be(3);

            var expectedNode = new Node<int>(30, null);
            var nodeAtLastPosition = linkedList.GetNode(linkedList.Lenght - 1);
            nodeAtLastPosition.Should().BeEquivalentTo(expectedNode);

            linkedList.Tail.Should().Be(nodeAtLastPosition);
        }
    }
}
