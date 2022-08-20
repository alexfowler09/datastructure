using SortAlgorithms.Interfaces;

namespace SortAlgorithms.SortAlgorithms
{
    public class BubbleSort : ISortAlgorithm
    {
        /// <summary>
        /// Compare the consecutive elements
        /// if the element is greater than the right element, swap then
        /// continue till the end of the collection and perform several passes to sort the elements
        /// Complexity best case: O(n)
        /// Complexity average case: O(n²)
        /// Complexity worst case: O(n²)
        /// Space: O(1)        
        /// Stable: yes  
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
