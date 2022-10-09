//посчитать сумму цифр в числе
Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine());
int sum = 0;
N = Math.Abs(N);
while (N > 0)
{
   sum = sum + N % 10;
   N = N / 10;
};
Console.WriteLine("Сумма цифр в числе: " + sum);