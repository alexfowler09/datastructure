using SortAlgorithms.Interfaces;

namespace SortAlgorithms.SortAlgorithms
{
    public class InsertionSort : ISortAlgorithm
    {
        /// <summary>
        /// Select one element at a time from the left of the array
        /// Insert the element at proper position
        /// After insertion every element to its left will be sorted
        /// Complexity best case: O(n)
        /// Complexity average case: O(n²)
        /// Complexity worst case: O(n²)
        /// Space: O(1)        
        /// Stable: yes        
        /// </summary>
        /// <param name="array">Array to be sorted</param>
        public void Sort(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                int temp = array[i];
                int position = i;

                while (position > 0 && array[position - 1] > temp)
                {
                    array[position] = array[position - 1];
                    position--;
                }

                array[position] = temp;
            }
        }
    }
}