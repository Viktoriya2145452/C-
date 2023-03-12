void RoadTon(int N, int M)
{
  if(N == M - 1)
  {
    return;
  }
  RoadTon(N - 1,M);
  Console.Write($"{N} ");
}

Console.Write("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());

RoadTon(numberB, numberA);