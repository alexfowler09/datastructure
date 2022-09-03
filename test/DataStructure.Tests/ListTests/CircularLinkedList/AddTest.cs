using FluentAssertions;
using Lists;
using Xunit;

namespace DataStructure.Tests.ListTests.CircularLinkedList
{
    public class AddTest
    {
        private readonly CircularLinkedList<int> circularLinkedList;

        public AddTest()
        {
            circularLinkedList = new CircularLinkedList<int>();
        }

        [Fact]
        public void Add_WhenListIsEmpty_InsertAtFirstPosition()
        {
            // act
            circularLinkedList.Add(10);

            // assert
            circularLinkedList.Lenght.Should().Be(1);

            var expectedNode = Node<int>.CreateNodeWithAutoReference(10);
            
            var nodeAtFirstPosition = circularLinkedList.GetNode(0);
            nodeAtFirstPosition.Should().BeEquivalentTo(expectedNode, 
                opt => opt.IgnoringCyclicReferences());

            circularLinkedList.Head.Should().Be(nodeAtFirstPosition);
            circularLinkedList.Tail.Should().Be(nodeAtFirstPosition);
        }

        [Fact]
        public void Add_WhenListIsNotEmpty_InsertAtLastPosition()
        {
            // arrange
            circularLinkedList.Add(10);
            circularLinkedList.Add(20);

            // act
            circularLinkedList.Add(30);

            // assert
            circularLinkedList.Lenght.Should().Be(3);

            var expectedNode = new Node<int>(30, circularLinkedList.Head);
            var nodeAtLastPosition = circularLinkedList.GetNode(circularLinkedList.Lenght - 1);
            nodeAtLastPosition.Should().BeEquivalentTo(expectedNode);

            circularLinkedList.Tail.Should().Be(nodeAtLastPosition);
        }
    }
}
