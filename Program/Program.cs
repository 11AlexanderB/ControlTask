// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. 

Console.Write("Введите максимальную длину строк, которые нужну выбрать: ");
int maxLength = Convert.ToInt32(Console.ReadLine());  // Переменая для избежания магических чисел 
string[] array = { "Hello", "11", "1993", "you", "Moldova", "Noroc" };
string[] array2 = new string[array.Length];  // Вспомогательный массив для хранения выбраных строк

string[] SelectRowsBySize(string[] array)
{
    int count = 0;  //Определяет место(индекс) строки в вспомогательном массиве

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= maxLength)
        {
            array2[count] = array[i];
            count++;
        }
    }
    return array2;
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

try
{
    Console.WriteLine();
    SelectRowsBySize(array);
    Console.WriteLine($"Массив из строк максимальная длина которых {maxLength}: ");
    PrintArray(array2);
}
catch
{
    Console.WriteLine("Ошибка");
}
