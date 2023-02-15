// Показать натуральные числа от 1 до N, N задано

void NaturalТumber(int N)
{
   
   if (N < 0) Console.Write($"{N} не натуральное число");
    if(N !=0)
{
      NaturalТumber(N-1);
       Console.Write(N) ;
}          
}

Console.WriteLine("Введите число N: ");
int Number = int.Parse(Console.ReadLine());
NaturalТumber(Number);
