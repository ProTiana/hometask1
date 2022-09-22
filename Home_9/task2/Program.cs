// Принять на вход 2 чимла и посчитать сумму всех натуральных чисел в отрезке между ними

Console.WriteLine("Введите число M");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число N");
int n = Convert.ToInt32(Console.ReadLine());

int FindSumBetween(int a, int b){
    int sum = 0;
if(a < b){
    for(int i = a; i<= b; i++){
        sum += i;
        }
    }
else{
    Console.WriteLine("Ошибка: Число начала меньше числа конца");
    }
    return sum;
}

int Result = FindSumBetween(m, n);
Console.WriteLine(Result);

