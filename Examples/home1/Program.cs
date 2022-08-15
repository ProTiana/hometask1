//  найти меньшее из двух вводимых чисел

Console.WriteLine("enter numberA");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("enter numberB");
int numberB = Convert.ToInt32(Console.ReadLine());
int max = 0;
int min = 0;

if (numberA > numberB){
    max = numberA;
    min = numberB;
}
else{
    min = numberA;
    max = numberB;
}
Console.Write("max = ");
Console.WriteLine(max);
Console.Write("min = ");
Console.WriteLine(min);

