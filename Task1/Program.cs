// Напишите программу, которая принимает на вход трехзначное число и на выходе показывает вторую цифру этого числа
int CreateNamber()
{
    int number = new Random().Next(100,1000);
    return number;
}
int a = CreateNamber();
int SecondNumber = a % 100 / 10;
Console.WriteLine(a);
Console.WriteLine(SecondNumber);