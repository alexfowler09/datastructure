using SortAlgorithms.Interfaces;

namespace SortAlgorithms.SortAlgorithms
{
    public class BubbleSort : ISortAlgorithm
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
            int temp;

            for (int i = array.Length - 1; i >= 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }
    }
}
