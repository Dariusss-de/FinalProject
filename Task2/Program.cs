// Показать натуральные числа от N до 1, N задано

void NaturalТumber(int N)
{
   
   if (N < 0) Console.Write($"{N} не натуральное число");
    if(N !=0)
{
      
       Console.Write(N) ;
        NaturalТumber(N-1);
}          
}

Console.WriteLine("Введите число N: ");
int Number = int.Parse(Console.ReadLine());
NaturalТumber(Number);
