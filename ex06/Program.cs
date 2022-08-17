﻿//1.Найти позицию минимального элемента в отсортированной части массива
//2.произвести обмен этого значения со значением первой неотсортированной позицией
// 3.Повторять пока есть неотсортированный элементы
int [] array = {1, 3, 4, 8, 3, 57,};

void PrintArray(int[] array)
{
    int count = array.Length;
   for(int i=0; i < count; i++)
   {
    Console.Write($"{array[i]} ");
   }
   Console.WriteLine();
}


void SelectionSort(int[]array)
{
    for (int i = 0; i <array.Length-1 ; i++)
    {
      int minPosition  = i;
      for (int j = i+1; j < array.Length; j++) 
      {
         if( array[j] < array[minPosition]) minPosition =j;
      }
      int temporary = array[i];
      array[i] = array[minPosition];
      array[minPosition] = temporary;
    }
}
PrintArray(array);
SelectionSort(array);
PrintArray(array);