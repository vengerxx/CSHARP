// Напишите программу, которая на вход принимает два числа и выдает,какое число больше,а какое меньше
Console.WriteLine("Введите числа: ");
int nA = Convert.ToInt32(Console.ReadLine());
int nB = Convert.ToInt32(Console.ReadLine());
if (nA > nB)
{
    Console.WriteLine($"Большее число {nA}, меньшее число {nB}");
}
else if (nA == nB)
{
    Console.WriteLine($"число {nB = nA}");
}
else if (nA < nB)
{
    Console.WriteLine($"большее число {nB}, меньшее число {nA}");
}