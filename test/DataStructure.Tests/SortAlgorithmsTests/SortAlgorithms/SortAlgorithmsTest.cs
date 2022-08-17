using FluentAssertions;
using SortAlgorithms.Interfaces;
using System.Linq;
using Xunit;

namespace DataStructure.Tests.SortAlgorithmsTests.SortAlgorithms
{
    public class SortAlgorithmsTest
    {
        [Theory]
        [MemberData(nameof(TheoryDataForSort.GetDataForSortAlgorithm), MemberType = typeof(TheoryDataForSort))]
        public void Sort_GivenUnsortedArray_ShouldSortArray(ISortAlgorithm sortAlgorithm, int[] unsortedArray)
        {
            // arrange            
            var unsortedArrayOriginal = unsortedArray.ToArray();

            // act
            sortAlgorithm.Sort(unsortedArray);

            // assert
            unsortedArray.Should()
                .BeEquivalentTo(unsortedArrayOriginal.OrderBy(v => v));
        }
    }
}
