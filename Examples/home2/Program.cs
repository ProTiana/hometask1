//  найти максимальное из 3х чисел

Console.WriteLine("enter numberA");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("enter numberB");
int numberB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("enter numberС");
int numberС = Convert.ToInt32(Console.ReadLine());

int max = 0;

if (numberA > numberB){
    max = numberA;
}
else{
    if (numberB>numberС){
        max = numberB;}
    else{
        max = numberС;}}
  
Console.Write("max = ");
 Console.WriteLine(max);

