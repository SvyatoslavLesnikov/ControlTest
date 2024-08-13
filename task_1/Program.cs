// Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
void PrintNaturalNumbersInRange(int M, int N)
{
    if (M <= N)
    {
        Console.WriteLine(M);
        PrintNaturalNumbersInRange(M + 1, N);
    }
}
PrintNaturalNumbersInRange(1,6);