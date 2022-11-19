int number = new Random().Next(100,1000);
Console.WriteLine(number);
int number1 = number/100;
int number3 = (number/10)-(number1*10);

Console.WriteLine($"{number3}");
