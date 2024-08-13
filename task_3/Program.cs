// Задайте произвольный массив. Выведете
// его элементы, начиная с конца.
int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
void PrintArrayReversed(int[] array, int n)
{
    if (n > 0)
    {
        Console.WriteLine(n + " ");
        PrintArrayReversed(array, n - 1);
    }
}
PrintArrayReversed(array, array.Length - 1);