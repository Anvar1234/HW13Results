/*
Написать программу, которая из имеющегося массива строк формируем массив строк, длина которых
меньше или равна 3 символа.
*/

string[] GetStringArray(int size, int maxStringLength)
{
    string chars = "_абвгдеёжзийклмнопрстуфхцчшщъыьэюя123456789-/+*№;%:?()";
    Random rand = new Random();
    string randomChar = String.Empty;
    int newStringLength = 0;
    int randomPosition = 0;

    string[] resultRandomArray = new string[size];

    for (int i = 0; i < size; i++)
    {
        newStringLength = rand.Next(1, maxStringLength + 1);
        for (int j = 0; j < newStringLength; j++)
        {
            randomPosition = rand.Next(0, chars.Length);
            randomChar = randomChar + chars[randomPosition];
        }
        resultRandomArray[i] = randomChar;
        randomChar = String.Empty;
    }
    return resultRandomArray;
}

string[] SelectFromArray(string[] array)
{
    int length = array.Length;
    int newLength = 0;
    
    for (int i = 0; i < length; i++)
    {
        if (array[i].Length <= 3)
        {
            newLength += 1;
        }
    }

    string[] resultArray = new string[newLength];
    int newPosition = 0; // Можно было не вводить эту переменную, а обнулить newLength, но для понимания ввел.

    for (int i = 0; i < length; i++)
    {
        if (array[i].Length <= 3)
        {
            resultArray[newPosition] = array[i];
            newPosition += 1;
        }
    }
    return resultArray;
}

Console.Write("Введите кол-во строк (слов) в массиве: ");
int arraySize = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимально возможную длину строки (слова): ");
int lengthWord = Convert.ToInt32(Console.ReadLine());

string[] newRandAr = GetStringArray(arraySize, lengthWord);
Console.WriteLine($"[{String.Join(", ", newRandAr)}]");
Console.WriteLine();
string[] resultRandArray = SelectFromArray(newRandAr);
Console.WriteLine($"[{String.Join(", ", resultRandArray)}]");