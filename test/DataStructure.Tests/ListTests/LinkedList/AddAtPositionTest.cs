using FluentAssertions;
using Lists;
using System;
using Xunit;

namespace DataStructure.Tests.ListTests
{
    public class AddAtPositionTest
    {
        private readonly LinkedList<int> linkedList;

        public AddAtPositionTest()
        {
            linkedList = new LinkedList<int>();
        }

        [Fact]
        public void Add_AtFirstPositionWhenListContainsOneElement_InsertElementAtFirstPosition()
        {
            // arrange            
            linkedList.Add(10);

            // act
            linkedList.Add(20, 0);

            // assert
            linkedList.Lenght.Should().Be(2);

            var expectedNode = new Node<int>(20, linkedList.GetNode(1));
            var firstNode = linkedList.GetNode(0);
            firstNode.Should().BeEquivalentTo(expectedNode);            
            
            linkedList.Head.Should().Be(firstNode);

            var expectedTailNode = new Node<int>(10, null);
            linkedList.Tail.Should().BeEquivalentTo(expectedTailNode);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        public void Add_WhenListIsEmpty_ThrowsIndexOutOfRangeException(int position)
        {
            // act
            Action act = () => linkedList.Add(10, position);

            // assert
            act.Should().Throw<IndexOutOfRangeException>();
        }

        [Fact]
        public void Add_InvalidPositionWhenListIsNotEmpty_ThrowsIndexOutOfRangeException()
        {
            // arrange
            linkedList.Add(10);
            linkedList.Add(20);

            // act
            Action act = () => linkedList.Add(30, 2);

            // assert
            act.Should().Throw<IndexOutOfRangeException>();
        }

        [Fact]
        public void Add_AtLastPosition_InsertElementAndChangeLastPosition()
        {
            // arrange
            linkedList.Add(10);
            linkedList.Add(20);

            // act
            linkedList.Add(30, 1);

            // arrange
            linkedList.Lenght.Should().Be(3);

            var expectedNode = new Node<int>(30, linkedList.GetNode(2));
            var nodeBeforeLastPosition = linkedList.GetNode(1);
            nodeBeforeLastPosition.Should().BeEquivalentTo(expectedNode);

            var expectedTailnode = new Node<int>(20, null);
            linkedList.Tail.Should().BeEquivalentTo(expectedTailnode);
        }
    }
}
