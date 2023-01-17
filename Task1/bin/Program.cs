// Напишите программу, которая выводит случайное число из отрезка [10, 99]

int num = new Random().Next(10, 100);
Console.WriteLine(num);

int firstNum = num / 10;
int secondNum = num % 10;

if(firstNum < secondNum)
{
  Console.WriteLine(secondNum);
}
else
{
  Console.WriteLine(firstNum);
}