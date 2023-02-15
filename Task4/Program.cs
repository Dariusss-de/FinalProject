// Найти сумму элементов от M до N, N и M заданы

int NaturalТumber(int N,int M)
{
  
   if (N ==0 || M==0) return 0; //Console.Write($"{N} и {M} не натуральные числа");

    if (M == 0) return (N * (N + 1)) / 2;            // Если M равно нулю
    else if (N == 0) return (M * (M + 1)) / 2;       // Если N равно нулю
    else if (M == N) return M;                       // Если M=N
    else if (M < N) return N + NaturalТumber(M, N - 1); // Если M<N
    else return N + NaturalТumber(M, N + 1);            // Если M>N  
  

}

Console.Write("Введите число M: ");
int Number2 = int.Parse(Console.ReadLine());
Console.Write("Введите число N: ");
int Number = int.Parse(Console.ReadLine());
Console.WriteLine(NaturalТumber(Number,Number2));
