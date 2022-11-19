Console.Write("Введите день недели ");
int numberA = Math.Abs(Convert.ToInt32(Console.ReadLine()));

if(numberA<6 && numberA>0)
{
    Console.WriteLine("Это будний день");
}
else if(numberA>5 && numberA<8)
{
    Console.WriteLine("Это выходной день");
}
else {
    Console.WriteLine("Это не день недели");
}
