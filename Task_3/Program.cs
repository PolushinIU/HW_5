// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

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
    int min = arr[0];
    int max = arr[0];
    int dif = 0;
    for (int i = 0; i < arr.Length; i++)
        if (arr[i] > max)
            max = arr[i];
        else
    if (arr[i] < min)
            min = arr[i];
    dif = max - min;
    return dif;
}


int[] myArray = FillArray(5, 0, 10);
printArray(myArray);
var dif = Search(myArray);
System.Console.WriteLine($"разница между макс. и мин. элементов массива: {dif}");