// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}
void FillArray(int[] tempArray)
{
    Random rand = new Random();

    for (int i = 0; i < tempArray.Length; i++)
    {
        tempArray[i] = rand.Next(100, 1000);
    }
}
int EvenNumberArray(int[] tempArray)
{
  int count = 0;
  for (int i = 0; i < tempArray.Length; i++)
  {
    if (tempArray[i] % 2 == 0)
	{ 
	 count++;
	}
  }
return count;
}
void PrintArray(int[] tempArray, int even)
{
    System.Console.WriteLine("[" + string.Join(" | ", temparray) + "]" + "->" + even);
}

//-----------------------------------------------------------------------

int size = ReadInt("Введите размер массива: ");
int[] array = new int[size];
FillArray(array);
int even = EvenNumberArray(array);
PrintArray(array, even);
