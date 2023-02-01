/* Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3 */
int[] EnteringArray()
{
    Console.WriteLine("Введите размер массива: ");
    int n = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[n];
    Console.WriteLine("Заполните массив.");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"array[{i}] = ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine("Массив заполнен.");
    return array;
}

int CountingNumberOfLargeZeros(int[] a)
{
    int count = 0;
    for (int i = 0; i < a.Length; i++)
    {
        if (a[i] > 0) count++;
    }
    return count;

}

int[] array = EnteringArray();
Console.WriteLine("************************************************************");
Console.WriteLine("Во веденном массиве количество чисел больших нуля, следующее");
Console.WriteLine(String.Join(", ", array)
                    + $" -> {CountingNumberOfLargeZeros(array)}");