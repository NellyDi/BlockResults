// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// Примеры: 
// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []

Console.WriteLine("Введите количество элементов массива:");
int n = int.Parse(Console.ReadLine()!);
string[] array1 = new string[n];
string[] array2 = new string[array1.Length];
for(int i = 0; i < array1.Length; i++)
{
    Console.Write($"array[{i}] = ");
    array1[i] = Console.ReadLine();
}

    
void PrintArray(string[] arr)
{
    for (int i = 0; i < n; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

void ResultArray(string[] arr1, string[] arr2)
{
    int count = 0;
    for (int i = 0; i < arr1.Length; i++)
    {
        if (arr1[i].Length <=3)
        {
            arr2[count] = arr1[i];
            count++;
        }
    }
}

ResultArray(array1, array2);
Console.WriteLine("Исходный массив: ");
PrintArray(array1);
Console.WriteLine();
Console.WriteLine("Изменённый массив: ");
PrintArray(array2);
