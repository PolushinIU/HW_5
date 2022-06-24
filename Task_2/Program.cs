// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

int[] FillArray(int large, int min, int max)
{
    int[] array = new int[large];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}
void printArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write($"{arr[i]}  ");
    }
    System.Console.WriteLine();
}

int Search(int[] arr)
{
    int summ = 0;
    for (int i = 0; i < arr.Length; i += 2)
    {
        summ += arr[i];
    }
    return summ;
}

int[] myArray = FillArray(6, 0, 10);
printArray(myArray);
int summ = Search(myArray);
System.Console.WriteLine($"сумма нечетных чисел в массиве: {summ}");
