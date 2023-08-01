// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
//15:18
//456 -> 6
//782 -> 2
//918 -> 8
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number>99 && number<1000)
{
    Console.WriteLine(number%10);
}
else
{
    Console.Write("Число не трехзначное");
}

