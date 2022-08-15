Console.WriteLine("Enter a number");
int number0 = int.Parse(Console.ReadLine());

for (int i=1; i<= number0; i++)
{
    Console.Write(Math.Pow(i,3)+", ");
}