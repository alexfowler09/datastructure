using SortAlgorithms.Interfaces;

namespace SortAlgorithms.SortAlgorithms
{
    public class SelectionSort : ISortAlgorithm
    {
        /// <summary>
        /// Select the minimium element of the array and place in appropiate position
        /// Complexity: O(n2)
        /// Swapping: O(n)
        /// Unstable Algorithm
        /// </summary>
        /// <param name="array"></param>
        public void Sort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                var position = i;
                
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[position])
                        position = j;
                }

                var temp = array[i];
                array[i] = array[position];
                array[position] = temp;
            }
        }
    }
}
