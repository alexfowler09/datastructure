using SortAlgorithms.Interfaces;
using SortAlgorithms.SortAlgorithms;
using Xunit;

namespace DataStructure.Tests.SortAlgorithmsTests
{
    public class TheoryDataForSort
    {
        public static TheoryData<ISortAlgorithm, int[]> GetDataForSortAlgorithm =>
            new()
            {
                {
                    new SelectionSort(),
                    GetUnsortedArray()
                },
                {
                    new InsertionSort(),
                    GetUnsortedArray()
                },
                {
                    new BubbleSort(),
                    GetUnsortedArray()
                },
                {
                    new ShellSort(),
                    GetUnsortedArray()
                },
                {
                    new MergeSort(),
                    GetUnsortedArray()
                },
                {
                    new QuickSort(),
                    GetUnsortedArray()
                }
            };

        private static int[] GetUnsortedArray() =>
            new int[] { 55, 35, 18, 10, 10, 11, 9, 8 };
    }
}
