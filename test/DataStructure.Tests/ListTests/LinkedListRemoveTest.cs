﻿using FluentAssertions;
using Lists;
using System;
using Xunit;

namespace DataStructure.Tests.ListTests
{
    public class LinkedListRemoveTest
    {
        private readonly LinkedList<int> linkedList;

        public LinkedListRemoveTest()
        {
            linkedList = new LinkedList<int>();
        }

        [Fact]
        public void Remove_WhenListIsEmpty_ThrowsIndexOutOfRangeException()
        {
            // act
            Action act = () => linkedList.Remove(0);

            // assert
            act.Should().Throw<IndexOutOfRangeException>();
        }

        [Fact]
        public void Remove_InvalidPosition_ThrowsIndexOutOfRangeException()
        {
            // arrange
            linkedList.Add(10);
            linkedList.Add(20);

            // act
            Action act = () => linkedList.Remove(2);

            // assert
            act.Should().Throw<IndexOutOfRangeException>();
        }

        [Fact]
        public void Remove_WhenListContainsOnlyOneElement_RemoveElement()
        {
            // arrange
            linkedList.Add(10);

            // act
            linkedList.Remove(0);

            // assert
            linkedList.Lenght.Should().Be(0);            
            linkedList.Head.Should().BeNull();
            linkedList.Tail.Should().BeNull();
        }

        [Fact]
        public void Remove_WhenListContainsOneElementAtLeftAndNoOneAtRight_RemoveElement()
        {
            // arrange
            linkedList.Add(10);
            linkedList.Add(20);

            // act
            linkedList.Remove(1);

            // assert
            linkedList.Lenght.Should().Be(1);

            var expectedHeadAndTailNode = new Node<int>(10, null);
            linkedList.Head.Should().BeEquivalentTo(expectedHeadAndTailNode);
            linkedList.Tail.Should().BeEquivalentTo(expectedHeadAndTailNode);
        }

        [Fact]
        public void Remove_WhenListContainsOneElementAtLeftAndOneElementAtRight_RemoveElement()
        {
            // arrange
            linkedList.Add(10);
            linkedList.Add(20);
            linkedList.Add(30);

            // act
            linkedList.Remove(1);

            // assert
            linkedList.Lenght.Should().Be(2);

            var expectedHeadNode = new Node<int>(10, linkedList.GetNode(1));
            linkedList.Head.Should().BeEquivalentTo(expectedHeadNode);

            var expectedTailNode = new Node<int>(30, null);
            linkedList.Tail.Should().BeEquivalentTo(expectedTailNode);
        }

        [Fact]
        public void Remove_WhenListContainsMoreThanOneElementAtLeftAndRight_RemoveElement()
        {
            // arrange
            linkedList.Add(10);
            linkedList.Add(20);
            linkedList.Add(30);
            linkedList.Add(40);
            linkedList.Add(50);

            // act
            linkedList.Remove(2);

            // assert
            linkedList.Lenght.Should().Be(4);

            var expectedHeadNode = new Node<int>(10, linkedList.GetNode(1));
            linkedList.Head.Should().BeEquivalentTo(expectedHeadNode);

            var expectedTailNode = new Node<int>(50, null);
            linkedList.Tail.Should().BeEquivalentTo(expectedTailNode);
        }

        [Fact]
        public void Remove_FirstPositionWhenListContaisOneElementAtRight_RemoveElement()
        {
            // arrange
            linkedList.Add(10);
            linkedList.Add(20);

            // act
            linkedList.Remove(0);

            // assert
            linkedList.Lenght.Should().Be(1);

            var expectedHeadNode = new Node<int>(20, null);
            linkedList.Head.Should().BeEquivalentTo(expectedHeadNode);

            var expectedTailNode = new Node<int>(20, null);
            linkedList.Tail.Should().BeEquivalentTo(expectedTailNode);
        }

        [Fact]
        public void Remove_FirstPositionWhenListContaisMoreThanOneElementAtRight_RemoveElement()
        {
            // arrange
            linkedList.Add(10);
            linkedList.Add(20);
            linkedList.Add(30);

            // act
            linkedList.Remove(0);

            // assert
            linkedList.Lenght.Should().Be(2);

            var expectedHeadNode = new Node<int>(20, linkedList.GetNode(1));
            linkedList.Head.Should().BeEquivalentTo(expectedHeadNode);

            var expectedTailNode = new Node<int>(30, null);
            linkedList.Tail.Should().BeEquivalentTo(expectedTailNode);
        }

        [Fact]
        public void Remove_IntermediatePositionWhenListContaisMoreThanOneElementAtRight_RemoveElement()
        {
            // arrange
            linkedList.Add(10);
            linkedList.Add(20);
            linkedList.Add(30);
            linkedList.Add(40);

            // act
            linkedList.Remove(1);

            // assert
            linkedList.Lenght.Should().Be(3);

            var expectedHeadNode = new Node<int>(10, linkedList.GetNode(1));
            linkedList.Head.Should().BeEquivalentTo(expectedHeadNode);

            var expectedIntermediateNode = new Node<int>(30, linkedList.GetNode(2));
            linkedList.GetNode(1).Should().BeEquivalentTo(expectedIntermediateNode);

            var expectedTailNode = new Node<int>(40, null);
            linkedList.Tail.Should().BeEquivalentTo(expectedTailNode);
        }
    }
}
