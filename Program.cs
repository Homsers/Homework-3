Console.WriteLine("Enter a number");
int x1 = int.Parse(Console.ReadLine());
int y1 = int.Parse(Console.ReadLine());
int z1 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter a second number");
int x2 = int.Parse(Console.ReadLine());
int y2 = int.Parse(Console.ReadLine());
int z2 = int.Parse(Console.ReadLine());


double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2-y1, 2)+ Math.Pow(z2-z1, 2));
Console.WriteLine($"Distance between 2 points is {distance}");