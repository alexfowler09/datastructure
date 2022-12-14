using FluentAssertions;
using SortAlgorithms;
using SortAlgorithms.Enums;
using SortAlgorithms.SortAlgorithms;
using System;
using Xunit;

namespace DataStructure.Tests.SortAlgorithmsTests.Builders
{
    public class SortAlgorithmBuilderTest
    {
        public static TheoryData<SortAlgorithmType, Type> DataForCreateSortAlgorithTest =>
            new()
            {
                { SortAlgorithmType.INSERTION_SORT, typeof(InsertionSort) },
                { SortAlgorithmType.BUBBLE_SORT, typeof(BubbleSort) },
                { SortAlgorithmType.SELECTION_SORT, typeof (SelectionSort) },
                { SortAlgorithmType.SHELL_SORT, typeof (ShellSort) },
                { SortAlgorithmType.QUICK_SORT, typeof (QuickSort) },
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
