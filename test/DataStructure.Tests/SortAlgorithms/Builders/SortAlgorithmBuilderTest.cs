using FluentAssertions;
using SortAlgorithms;
using SortAlgorithms.Enums;
using SortAlgorithms.SortAlgorithms;
using System;
using Xunit;

namespace DataStructure.Tests.SortAlgorithms.Builders
{
    public class SortAlgorithmBuilderTest
    {
        public static TheoryData<SortAlgorithmType, Type> DataForCreateSortAlgorithTest =>
            new()
            {
                { SortAlgorithmType.INSERTION_SORT, typeof(InsertionSort) },
                { SortAlgorithmType.BUBBLE_SORT, typeof(BubbleSort) },
                { (SortAlgorithmType)(-1), typeof(BubbleSort) },
            };

        [Theory]        
        [MemberData(nameof(DataForCreateSortAlgorithTest))]
        public void CreateSortAlgorithm_WhenInsertionSortIsRequest_ReturnsNewInsertionSort(
            SortAlgorithmType sortAlgorithmType, Type expectedReturnedType)
        {
            // act
            var sortAlgorithm = SortAlgorithmBuilder.CreateSortAlgorithm(sortAlgorithmType);

            // assert
            sortAlgorithm.Should().BeOfType(expectedReturnedType);
        }
    }
}
