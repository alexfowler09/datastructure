using SortAlgorithms.Enums;
using SortAlgorithms.Interfaces;
using SortAlgorithms.SortAlgorithms;

namespace SortAlgorithms
{
    public class SortAlgorithmBuilder
    {
        public static ISortAlgorithm CreateSortAlgorithm(SortAlgorithmType sortAlgorithmType)
        {
            return sortAlgorithmType switch
            {
                SortAlgorithmType.BUBBLE_SORT => new BubbleSort(),
                SortAlgorithmType.INSERTION_SORT => new InsertionSort(),
                _ => new BubbleSort(),
            };
        }
    }
}
