// Задать массив из случайных трехзначных чисел 
//и написать программу, которая считает количество четных элементов массива

int[] RR = new int[8];

int[] Fillarray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
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
 int[]Result = Fillarray(RR);
 PrintArray(Result);
int CountPositiv(int[]AR){
int count = 0;
    for(int i = 0; i < AR.Length; i++){
if(AR[i]%2 == 0){
   count = count+1;}
    }
    return count;
}
int CountPos = CountPositiv(Result);
Console.WriteLine(CountPos);