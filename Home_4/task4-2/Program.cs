// ввести число и посчитать сумму его цифр

Console.WriteLine("Введите число");
string A = Convert.ToString(Console.ReadLine());

int FindSum(string a){
    int result = 0;
for(int i= 0; i< a.Length; i++){ 
    string s1 = char.ToString(a[i]); // конвертируем символ строки пользователя в отдельную строку
int tmp = Int32.Parse(s1); // конвертируем новую строку a[i] в число int
    result = result + tmp;
}
    return result;
}
int sum = FindSum(A);
Console.WriteLine(sum);




/*for(int i= 0; i< A.Length; i++){
int s = Convert.ToInt32(A[i]);
Console.WriteLine(s);}*/

