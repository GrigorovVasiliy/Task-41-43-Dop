Console.WriteLine("Hello, World!");
Console.WriteLine("Введите построчно значения координат прямых: ");
double b1 = Convert.ToDouble(Console.ReadLine());
double k1 = Convert.ToDouble(Console.ReadLine());
double b2 = Convert.ToDouble(Console.ReadLine());
double k2 = Convert.ToDouble(Console.ReadLine());
double x = (b2 - b1) / (k1 - k2);
Console.Write($"Точка пересечения двух прямых: [{k1 * x + b1}; {k2 * x + b2}].");