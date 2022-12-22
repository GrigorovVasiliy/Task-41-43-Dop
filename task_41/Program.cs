Console.Write("Введите числа через пробел: ");
double[] size = Console.ReadLine().
Split(" ").Select(x => double.Parse(x)).ToArray();
double count = 0;
for (int i = 0; i < size.Length; i++)
{ if (size[i] > 0) count = count + 1; }
Console.WriteLine($"Количество чисел больше 0: {count}.");