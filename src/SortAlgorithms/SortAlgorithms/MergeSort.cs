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
        /// Complexity: O(n logn)
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

        private void Merge(int[] originalArray, int left, int right, int middle)
        {
            int i = left;
            int j = middle + 1;
            int k = left;

            int[] sortedArray = new int[originalArray.Length];

            while (i <= middle && j <= right)
            {
                if (originalArray[i] < originalArray[j])
                {
                    sortedArray[k] = originalArray[i];
                    i++;
                }
                else
                {
                    sortedArray[k] = originalArray[j];
                    j++;
                }
                k++;
            }

            while (i <= middle)
            {
                sortedArray[k] = originalArray[i];
                i++;
                k++;
            }

            while (j <= right)
            {
                sortedArray[k] = originalArray[j];
                j++;
                k++;
            }            

            for (int x = left; x < right + 1; x++)
                originalArray[x] = sortedArray[x];
        }
    }
}
