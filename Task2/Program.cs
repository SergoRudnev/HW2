// Напишите программу, которая выводит третью цифру заданного числа или сообщает что третьей цифры нет
int CreateNamber()
{
    int number = new Random().Next(0,150);
    return number;
}
int a = CreateNamber();
int ThirdNumber = a % 10;
if(a>99)
{
Console.WriteLine(a);   
Console.WriteLine(ThirdNumber);
}
else
{
    Console.WriteLine(a);
    Console.WriteLine("Нет третьего числа");
}
