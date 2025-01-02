// See https://aka.ms/new-console-template for more information
using Algorithms;


int[] array = { 8, 65, 9, 7, 3, 5, 54 };

Console.WriteLine(String.Join(", ", array));
AlgorithmsClass.mergeSort(array, 0, array.Length - 1);
Console.WriteLine(String.Join(", ", array));



Console.WriteLine(AlgorithmsClass.binarySearch(array, 5));