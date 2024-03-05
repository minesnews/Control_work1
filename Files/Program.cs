﻿// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

string[] GetNewArray(string[] array)
{
    string[] words;
    int Length = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            Length++;
        }
    }
    int index = 0;
    words = new string[Length];

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            words[index] = array[i];
            index++;
        }
    }
    return words;
}
void PrintArray(string[] array)
{
    foreach (var e in array)
    {
        System.Console.Write($"{e} ");
    }
}
string[] words = { "52", "test", "two", "GeekBrains", "UI", "sdse" };
words = GetNewArray(words);
PrintArray(words);
