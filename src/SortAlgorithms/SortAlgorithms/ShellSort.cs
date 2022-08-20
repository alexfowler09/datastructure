using SortAlgorithms.Interfaces;

namespace SortAlgorithms.SortAlgorithms
{
    public class ShellSort : ISortAlgorithm
    {
        /// <summary>
        /// Selects an element and compare element after gap
        /// Similar to insertion sort
        /// Inserted element from the gap at its proper position
        /// Complexity best case: O(n log n)
        /// Complexity average case: O(n log n)
        /// Complexity worst case: O(n²)
        /// Space: O(1)        
        /// Stable: no    
        /// </summary>
        /// <param name="array"></param>
        public void Sort(int[] array)
        {
            for(int gap = array.Length / 2; gap > 0; gap = gap / 2)
            {
                for(int i = gap; i < array.Length; i++)
                {
                    var temp = array[i];
                    int j = i - gap;
                    while (j >= 0 && array[j] > temp)
                    {
                        array[j + gap] = array[j];
                        j -= gap;
                    }
                    array[j + gap] = temp;
                }
            }
        }
    }
}
