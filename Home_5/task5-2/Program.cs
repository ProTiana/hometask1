// Задать массив из случайных чисел 
//и написать программу, которая ищет сумму элементов, стоящих на нечетных позициях

int[] RR = new int[4];

int[] Fillarray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-10, 10);
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

int Findsum(int[]arr){
    int sum = 0;
    for(int i =0; i<= arr.Length; i++){
        if(i%2 != 0){
        sum = sum + arr[i];
        i++;
        }
    }
    return sum;
}
 int[]Result = Fillarray(RR);
 PrintArray(Result);

 int Summa = Findsum(Result);
 Console.WriteLine(Summa);

/* для отладки цикла:
int[]A = new int[]{2, 1,4, 2};
Console.WriteLine(A[0]);
Console.WriteLine(A[1]);
Console.WriteLine(A[2]);
Console.WriteLine(A[3]);
int sum = 0;

    for(int i =0; i<= A.Length; i++){
        if(i == 0){
        sum = sum + 1000;
        i = i+1;
        }
else{
    sum = sum + 100;

}
    }
Console.WriteLine(sum);*/

