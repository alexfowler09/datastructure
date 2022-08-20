using SortAlgorithms.Interfaces;

namespace SortAlgorithms.SortAlgorithms
{
    public class MergeSort : ISortAlgorithm
    {
        /// <summary>
        /// Compare the consecutive elements
        /// Divide the collection of elements into smaller subsets
        /// Recursively sort the subsets
        /// Combine or merge the result into a solution
        /// Divide and conquer approach
        /// Complexity best case: O(n log n)
        /// Complexity average case: O(n log n)
        /// Complexity worst case: O(n log n)
        /// Space: O(n)        
        /// Stable: yes  
        /// </summary>
        /// <param name="array">Array to be sorted</param>
        public void Sort(int[] array)
        {
            InternalSort(array, array.GetLowerBound(0), array.GetUpperBound(0));
        }

        private void InternalSort(int[] array, int left, int right)
        {
            if (left < right)
            {
                int middle = (left + right) / 2;
                InternalSort(array, left, middle);
                InternalSort(array, middle + 1, right);                
                Merge(array, left, right, middle);
            }
        }

        private void Merge(int[] array, int left, int right, int middle)
        {
            int i = left;
            int j = middle + 1;
            int k = left;

            int[] sortedArray = new int[array.Length];

            while (i <= middle && j <= right)
            {
                if (array[i] < array[j])
                {
                    sortedArray[k] = array[i];
                    i++;
                }
                else
                {
                    sortedArray[k] = array[j];
                    j++;
                }
                k++;
            }

            while (i <= middle)
            {
                sortedArray[k] = array[i];
                i++;
                k++;
            }

            while (j <= right)
            {
                sortedArray[k] = array[j];
                j++;
                k++;
            }            

            for (int x = left; x < right + 1; x++)
                array[x] = sortedArray[x];
        }
    }
}
