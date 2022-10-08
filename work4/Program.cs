// показать кубы чисел, заканчивающихся на четную цифру
Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine());
int M = 1;

while (M <= N)
{
    if (M % 2 == 0)
    {
    Console.WriteLine("Кубы чисел, заканчивающихся на четную цифру: " + M * M * M);
    }
    M++;
};
