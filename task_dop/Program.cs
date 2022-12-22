Console.WriteLine("Введите построчно координаты вершин треугольника x1 и y1: ");
double x1 = Convert.ToDouble(Console.ReadLine());
double y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите построчно координаты вершин треугольника x2 и y2: ");
double x2 = Convert.ToDouble(Console.ReadLine());
double y2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите построчно координаты вершин треугольника x3 и y3: ");

double x3 = Convert.ToDouble(Console.ReadLine());
double y3 = Convert.ToDouble(Console.ReadLine());
double side1 = (Math.Round(Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2)), 2));
double side2 = (Math.Round(Math.Sqrt(Math.Pow(x1 - x3, 2) + Math.Pow(y1 - y3, 2)), 2));

Console.WriteLine($"Площадь треугольника: {(side1 * side2) / 2}.");