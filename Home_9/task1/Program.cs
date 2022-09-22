// Принять на вход 2 чимла и вывести все натуральные числа в отрезке между заданными.

Console.WriteLine("Введите число начала");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число конца");
int n = Convert.ToInt32(Console.ReadLine());

void PrintNumbers(int min, int max)
{
   
if(min < max){
    for (int i = min; i <= max; i++)
    Console.Write($"{i} ; ");
}
else{
    Console.WriteLine("Ошибка: Число начала меньше числа конца");
}
    }
    
PrintNumbers(m, n);
