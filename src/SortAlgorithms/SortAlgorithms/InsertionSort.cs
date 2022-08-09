using SortAlgorithms.Interfaces;

namespace SortAlgorithms.SortAlgorithms
{
    public class InsertionSort : ISortAlgorithm
    {
        /// <summary>
        /// 
        /// Complexity: O(n2)
        /// Swapping: O(n2)
        /// Stable Algorithm
        /// 
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