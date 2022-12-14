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
                SortAlgorithmType.SELECTION_SORT => new SelectionSort(),
                SortAlgorithmType.SHELL_SORT => new ShellSort(),
                SortAlgorithmType.MERGE_SORT => new MergeSort(),
                SortAlgorithmType.QUICK_SORT => new QuickSort(),
                _ => new BubbleSort(),
            };
        }
    }
}
