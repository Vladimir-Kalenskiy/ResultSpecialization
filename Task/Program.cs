// Задача. Написать программу, которая из имеющегося массива строк формирует массив строк, длина которых меньше либо равно 3 символа.
//         Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется
//         пользоваться коллекциями, лучше обойтись исключительно массивами.

void ShowArray(string[] array)
{
    Console.WriteLine("Array: ");
    
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

string[] ModificationArray(string[] array, int maxLength = 3)
{
    string[] newArray = new string[array.Length];

    for(int i = 0; i < array.Length; i++)
        if(array[i].Length<=maxLength)
            newArray[i] = array[i];

    return newArray;
}


string[] myArray = {"hello", "good", "234", "qwe", "bkb", "night", "day", "b", "a"};

string[] createdArray = ModificationArray(myArray);

ShowArray(createdArray);
