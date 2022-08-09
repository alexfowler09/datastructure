using SortAlgorithms.Enums;
using SortAlgorithms.Interfaces;
using SortAlgorithms.SortAlgorithms;

namespace SortAlgorithms.Extensions
{
    public static class ArrayExtensions
    {
        public static void SortByAlgorithm(this int[] array, SortAlgorithmType sortAlgorithmType)
        {
            var sortAlgorithms = new Dictionary<SortAlgorithmType, ISortAlgorithm>()
            {
                { SortAlgorithmType.BUBBLE_SORT, new BubbleSort() },
                { SortAlgorithmType.INSERTION_SORT, new InsertionSort() }
            };

            ISortAlgorithm? sortAlgorithm = sortAlgorithms[sortAlgorithmType];
            
            if (sortAlgorithm != null)
                sortAlgorithm.Sort(array);
        }
    }
}
