Console.WriteLine("Введите первое число ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2)

{
    System.Console.WriteLine(number1);
}
else if (number1 < number2)
{
    System.Console.WriteLine(number2);
}
if (number2 < number1)
{
    System.Console.WriteLine(number2);
}
else if (number2 > number1)
{
    System.Console.WriteLine(number1);
}