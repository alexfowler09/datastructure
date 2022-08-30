using FluentAssertions;
using Lists;
using System;
using Xunit;

namespace DataStructure.Tests.ListTests
{
    public class LinkedListGetNodeTest
    {
        [Fact]
        public void GetNode_GetFirstElementWhenListContainsOnlyOneElement_ReturnsElement()
        {
            // arrange
            var linkedList = new LinkedList<int>();
            linkedList.AddLeading(10);

            // act
            var node = linkedList.GetNode(0);

            // assert
            var expectedNode = new Node<int>(10, null);
            node.Should().BeEquivalentTo(expectedNode);
        }

        [Fact]
        public void GetNode_GetLastElementWhenListContainsMoreThanOneELement_ReturnsElement()
        {
            // arrange
            var linkedList = new LinkedList<int>();
            linkedList.AddLeading(10);
            linkedList.AddLast(20);
            linkedList.AddLast(30);

            // act
            var node = linkedList.GetNode(2);

            // assert
            var expectedNode = new Node<int>(30, null);
            node.Should().BeEquivalentTo(expectedNode);
        }

        [Fact]
        public void GetNode_GetElementButFirstOrLast_ReturnsElement()
        {
            // arrange
            var linkedList = new LinkedList<int>();
            linkedList.AddLeading(10);
            linkedList.AddLast(20);
            linkedList.AddLast(30);

            // act
            var node = linkedList.GetNode(1);

            // assert
            var expectedNode = new Node<int>(20, linkedList.GetNode(2));
            node.Should().BeEquivalentTo(expectedNode);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        public void GetNode_WhenListHasNotElements_ThrowsIndexOutOfRangeException(int position)
        {
            // arrange
            var linkedList = new LinkedList<int>();

            // act
            Action act = () => linkedList.GetNode(position);

            // assert
            act.Should().Throw<IndexOutOfRangeException>();
        }

        [Fact]
        public void GetNode_WhenListHasElementsButIndexIsOutOfRange_ThrowsIndexOutOfRangeException()
        { 
            // arrange
            var linkedList = new LinkedList<int>();
            linkedList.AddLeading(10);
            linkedList.AddLast(20);
            linkedList.AddLast(30);

            // act
            Action act = () => linkedList.GetNode(3);

            // assert
            act.Should().Throw<IndexOutOfRangeException>();
        }
    }
}
