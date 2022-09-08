// Задать массив из 8 элементов и выводит их не экран

int[] HW = new int[8];

int[] Fillarray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 1000);
    }
    return array;
}
void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");

    }
}

 int[]Result = Fillarray(HW);
 PrintArray(Result);


