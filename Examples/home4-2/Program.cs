// принимает на вход число  n и возвращает все четные числа от 1 до n
Console.WriteLine("add number");
int n = Convert.ToInt32(Console.ReadLine());
int a = 1;
while (a<n){
    if ((a % 2) == 0){
    Console.Write(a);
    }
 a++;
}

