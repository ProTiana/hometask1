// See


int[] RR = new int[6];

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

int GetDif(int[] arr)
{
    int dif = 0;
    int max = arr[0];
    int min = arr[0];

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max)
        {
            max = arr[i];
        }
        else
        {
            if (arr[i] < min)
            {
                min = arr[i];
            }
        }

    }
    dif = max + min;
    return dif;
}
int[] Result = Fillarray(RR);
PrintArray(Result);
Console.WriteLine("  ");
int Summa = GetDif(Result);
Console.WriteLine(Summa);

//отладка:
/*int [] hw = new int []{2,5,7,9};

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");

    }
}
PrintArray(hw);
Console.WriteLine("  ");
int max = hw[0];
int min = hw[0];

 for (int i = 0; i < hw.Length; i++){
 if (hw[i] > max)
        {
            max = hw[i];
        }
        else
        {
            if (hw[i] < min)
            {
                min = hw[i];
            }
        }
 }
        //int dif = 0;*/

