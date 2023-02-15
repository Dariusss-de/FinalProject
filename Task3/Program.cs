// Показать натуральные числа от M до N, N и M заданы

void NaturalТumber(int N,int M)
{
   
   if (N < 0 && M<0) Console.Write($"{N} и {M} не натуральные числа");
    else if(M<=N)
{
        
        NaturalТumber(N - 1, M);
       Console.Write(N);
}         
}

Console.Write("Введите число M: ");
int Number2 = int.Parse(Console.ReadLine());
Console.Write("Введите число N: ");
int Number = int.Parse(Console.ReadLine());
NaturalТumber(Number,Number2);


/*
// Второй вариант
void NaturalТumber(int N,int M)
{
   
   if (N < 0 && M<0) Console.Write($"{N} и {M} не натуральные числа");
    else if(M<=N)
{
        
        NaturalТumber(N - 1, M);
       Console.Write(N+"\t");
}         
}

int Number2 = new Random().Next(1,50);
Console.WriteLine("Первое чисоло: "+Number2);
int Number = new Random().Next(50,100);
Console.WriteLine("Второе чисоло: "+Number);
NaturalТumber(Number,Number2);

*/