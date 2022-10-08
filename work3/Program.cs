// написать программу вычисления произведения чисел от 1 до N
Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine());
int M = 1;  
int multiplication = 1;
while (M <= N)
{
    multiplication = multiplication * M;
    M++;
};
Console.WriteLine("Произведение чисел: " + multiplication);