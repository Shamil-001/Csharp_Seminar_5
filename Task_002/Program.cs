// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}
void FillArray(int[] tempArray, int leftRange, int rightRange)
{
    Random rand = new Random();

    for (int i = 0; i < tempArray.Length; i++)
    {
        tempArray[i] = rand.Next(leftRange, rightRange + 1);
    }
}
int SumNegativeNumberArray(int[] tempArray)
{
    int count = 0;
    for (int i = 0; i < tempArray.Length; i++)
    {
        if (i % 2 != 0)
        {
            count += tempArray[i];
        }
    }
    return count;
}
void PrintArray(int[] tempArray)
{
    System.Console.WriteLine("[" + string.Join(" | ", tempArray) + "]");
}
void PrintSum(int sum)
{
    System.Console.WriteLine("Сумма элементов на нечетных позициях равна: " + sum);
}

//-----------------------------------------------------------------------

int size = ReadInt("Введите размер массива: ");
int min = ReadInt("Введите минимальное значение элемента массива: ");
int max = ReadInt("Введите максимальное значение элемента массива: ");
int[] array = new int[size];
FillArray(array, min, max);
int sum = SumNegativeNumberArray(array);
PrintArray(array);
PrintSum(sum);