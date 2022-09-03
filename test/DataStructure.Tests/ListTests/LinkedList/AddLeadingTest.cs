using FluentAssertions;
using Lists;
using Xunit;

namespace DataStructure.Tests.ListTests
{
    public class AddLeadingTest
    {
        private readonly LinkedList<int> linkedList;

        public AddLeadingTest()
        {
            linkedList = new LinkedList<int>();
        }

        [Fact]
        public void AddLeading_WhenListIsEmpty_InsertAtFirstPosition()
        {
            // act
            linkedList.AddLeading(10);

            // assert
            linkedList.Lenght.Should().Be(1);

            var expectedNode = new Node<int>(10, null);
            var nodeAtFirstPosition = linkedList.GetNode(0);
            nodeAtFirstPosition.Should().BeEquivalentTo(expectedNode);

            linkedList.Head.Should().Be(nodeAtFirstPosition);
        }

        [Fact]
        public void Add_WhenListIsNotEmpty_InsertAtFirstPosition()
        {
            // arrange
            linkedList.Add(10);
            linkedList.Add(20);

            // act
            linkedList.AddLeading(30);

            // assert
            linkedList.Lenght.Should().Be(3);

            var expectedNode = new Node<int>(30, linkedList.GetNode(1));
            var nodeAtFirstPosition = linkedList.GetNode(0);
            nodeAtFirstPosition.Should().BeEquivalentTo(expectedNode);

            linkedList.Head.Should().Be(nodeAtFirstPosition);
        }
    }
}
