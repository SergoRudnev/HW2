// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
int CreateNamber()
{
    int number = new Random().Next(1,8);
    return number;
}
int a = CreateNamber();
if(a>5)
{
    Console.WriteLine(a);
    Console.WriteLine("Выходной");
}
else
{
    Console.WriteLine(a);
    Console.WriteLine("Будний день");
}