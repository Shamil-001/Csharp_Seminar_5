// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}
void FillArray(double[] tempArray, int leftRange, int rightRange)
{
    Random rand = new Random();

    for (int i = 0; i < tempArray.Length; i++)
    {
        tempArray[i] = Math.Round(rand.Next(leftRange, rightRange + 1) + rand.NextDouble(), 2);
    }
}
double MaxNumberArray(double[] tempArray)
{
    double max = 0;
    for (int i = 0; i < tempArray.Length; i++)
    {

        if (max < tempArray[i])
        {
            max = tempArray[i];
        }

    }
    return max;
}
double MinNumberArray(double[] tempArray)
{
    double min = tempArray[0];
    for (int i = 0; i < tempArray.Length; i++)
    {
    
        if (min > tempArray[i])
        {
            min = tempArray[i];
        }
    }
        return min;
}
void PrintArray(double[] tempArray)
{
    System.Console.WriteLine("[" + string.Join(" | ", tempArray) + "]");
}
void PrintMaxAndMin(double min, double max)
{
    System.Console.WriteLine("Минимальное значение равно : " + min);
    System.Console.WriteLine("Максимальное значение равно : " + max);
}

// ------------------------------------------------------------------------------------

int size = ReadInt("Введите размер массива: ");
int leftRange = ReadInt("Введите минимальное значение массива: ");
int rightRange = ReadInt("Введите максимальное значение масива: ");
double[] array = new double[size];
FillArray(array, leftRange, rightRange);
PrintArray(array);
double max = MaxNumberArray(array);
double min = MinNumberArray(array);
PrintMaxAndMin(min, max);

