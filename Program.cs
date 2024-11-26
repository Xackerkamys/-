// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []


// Создание массива из пользовательского ввода
string[] CreateArrayStr(int size)
{
    string[] strings = new string[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Введите строку {i}: ");
        strings[i] = Console.ReadLine();
    }

    return strings;
}

//Вывод строкового массива
void PrintArrayStr(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write("\"" + array[i] + "\"");
        if (i < array.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.Write("]");
}

//Проверка массива на количество символов в элементе
string[] CheckArrayStr(string[] array)
{
    string[] resultArray = new string[array.Length];
    int index = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            resultArray[index] = array[i];
            index++;
        }
    }
    Array.Resize(ref resultArray, index);//Удаляем пустые элементы из памяти результирующего массива
    return resultArray;
}

Console.Write("Введите размер строкового массива :");
int arraySize;
bool isValidInput = int.TryParse(Console.ReadLine(), out arraySize);//Обработка ошибки ввода

if (!isValidInput || arraySize <= 0)
{
    Console.WriteLine("Некорректный ввод. Размер массива должен быть положительным числом.");
    return;
}

string[] array = CreateArrayStr(arraySize);

Console.WriteLine("Сформирован массив строк:");
PrintArrayStr(array);
Console.WriteLine("");

string[] resultArray = CheckArrayStr(array);

Console.WriteLine("Массив из строк, длина которых меньше, либо равна 3 символам :");
PrintArrayStr(resultArray);
