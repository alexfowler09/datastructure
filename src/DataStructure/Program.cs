// See https://aka.ms/new-console-template for more information

using SortAlgorithms;
using SortAlgorithms.Enums;
using SortAlgorithms.Extensions;

int[] array = new int[] { 5, 5, 3, 2, 10, 25, 8, 7 };

array.SortByAlgorithm(SortAlgorithmType.BUBBLE_SORT);

for (int i = 0; i < array.Length; i++)
    Console.Write($"{array[i]} ");

Console.ReadKey();
