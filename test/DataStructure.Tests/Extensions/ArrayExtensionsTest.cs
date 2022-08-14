using FluentAssertions;
using NSubstitute;
using SortAlgorithms.Extensions;
using SortAlgorithms.Interfaces;
using System;
using Xunit;

namespace DataStructure.Tests.Extensions
{
    public class ArrayExtensionsTest
    {
        [Fact]
        public void SortByAlgorithm_WithNotNullableAlgorithm_ShouldCallAlgorithmSort()
        {
            // arrange
            var sortAlgorithm = Substitute.For<ISortAlgorithm>();
            var array = new int[] { 10, 20, 2, 3, 5 };            

            // act
            array.SortByAlgorithm(sortAlgorithm);

            // assert
            sortAlgorithm.Received(1).Sort(array);
        }

        [Fact]
        public void SortByAlgorithm_WithNullableAlgorithm_ShouldThrowArgumetNullException()
        {
            // arrange            
            var array = new int[] { 10, 20, 2, 3, 5 };

            // act
            Action act = () => array.SortByAlgorithm(null);

            // assert
            act.Should().Throw<ArgumentException>();           
        }
    }
}
