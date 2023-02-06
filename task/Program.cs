﻿// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// Примеры: 
// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []

Console.WriteLine("Введите количество элементов массива:");
int n = int.Parse(Console.ReadLine()!);
string[] array = new string[n];

for(int i = 0; i < array.Length; i++)
{
    Console.Write($"array[{i}] = ");
    array[i] = Console.ReadLine();
}

Console.WriteLine("Исходный массив:");
for (int i = 0; i < n; i++)
{
    Console.Write(array[i] + " ");
}