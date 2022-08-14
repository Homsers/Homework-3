Console.WriteLine("Enter a number");
int number0 = int.Parse(Console.ReadLine());


  int number1 = number0 % 100;
  int number2 = number0 / 1000;
  int number3 = number1 % 10;
  int number4 = number2 % 10;
  int number5 = number1 / 10;
  int number6 = number2 / 10;



void numberS (int number0) 
{

  if (number3 == number6 & number4 == number5)
  {
    Console.WriteLine("PALINDROME"); Console.WriteLine($"Написал для удобства {number0} {number1} {number2} {number3} {number4} {number5} {number6}");
  } 
  else if (number0 < 10000 || number0 > 99999)
  {
    Console.WriteLine("Error");
  }
  else Console.WriteLine("not a Palindrome");
}
numberS(number0);


