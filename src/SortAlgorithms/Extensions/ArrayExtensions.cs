using SortAlgorithms.Interfaces;

namespace SortAlgorithms.Extensions
{
    public static class ArrayExtensions
    {
        public static void SortByAlgorithm(this int[] array, ISortAlgorithm? sortAlgorithm)
        {   
            if (sortAlgorithm == null)
                throw new ArgumentNullException(nameof(sortAlgorithm));

            if (sortAlgorithm != null)
                sortAlgorithm.Sort(array);            
        }
    }
}
