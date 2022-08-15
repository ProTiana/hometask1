//  найти меньшее из двух вводимых чисел

Console.WriteLine("enter numberA");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("enter numberB");
int numberB = Convert.ToInt32(Console.ReadLine());

int min = 0;

if (numberA > numberB){
    min = numberB;
}
else{
    min = numberA;
}

Console.WriteLine(min);

