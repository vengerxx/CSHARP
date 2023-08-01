// Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
Console.WriteLine ("Введите числа: ");
int numberA = Convert.ToInt32(Console.ReadLine());
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberA * numberA == numberB)
{
    Console.WriteLine ("Правда");
}
else
{
    Console.WriteLine ("Ложь");
}