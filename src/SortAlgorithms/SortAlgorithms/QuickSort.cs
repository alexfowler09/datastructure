using SortAlgorithms.Interfaces;

namespace SortAlgorithms.SortAlgorithms
{
    public class QuickSort : ISortAlgorithm
    {
        /// <summary>
        /// Divide the collectino of elements into subsets or partitions
        /// Partition based on pivot
        /// Recursively sort the partitions using quick sort        
        /// Divide and conquer approach
        /// Complexity best case: O(n log n)
        /// Complexity average case: O(n log n)
        /// Complexity worst case: O(n²)
        /// Space: O(n)        
        /// Stable: no  
        /// </summary>
        /// <param name="array">Array to be sorted</param>
        public void Sort(int[] array)
        {
            InternalSort(array, array.GetLowerBound(0), array.GetUpperBound(0));
        }

        private void InternalSort(int[] array, int low, int high)
        {
            if (low < high)
            {
                var pivotIndex = Partition(array, low, high);
                InternalSort(array, low, pivotIndex - 1);
                InternalSort(array, pivotIndex + 1, high);
            }
        }

        private int Partition(int[] array, int low, int high)
        {
            var pivot = array[low];
            int i = low + 1;
            int j = high;

            do
            {
                while (i <= j && array[i] <= pivot)
                    i++;
                while (i <= j && array[j] > pivot)
                    j--;
                
                if (i < j)
                    Swap(array, i, j);
            } while (i < j);

            Swap(array, low, j);

            return j;
        }

        private void Swap(int[] array, int i, int j)
        {
            (array[j], array[i]) = (array[i], array[j]);
        }
    }
}
