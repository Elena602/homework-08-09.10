//найти кубы чисел от 1 до N
Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine());
int M = 1;

while (M <= N)
{
   Console.WriteLine("Кубы чисел: " + M * M * M);
   M++;
};
