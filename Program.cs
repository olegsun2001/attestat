#region Ввод данных
string[] initialArray = new string[] { "Привет", "мир", "!", "12345", "abc", "Разное","ку" };
#endregion

#region Подсчет количества строк, удовлетворяющих условию
int count = 0;
for (int i = 0; i < initialArray.Length; i++)
{
    if (initialArray[i].Length <= 3)
    {
        count++;
    }
}
#endregion

#region Формирование нового массива
string[] resultArray = new string[count];
int index = 0;
for (int i = 0; i < initialArray.Length; i++)
{
    if (initialArray[i].Length <= 3)
    {
        resultArray[index++] = initialArray[i];
    }
}
#endregion

#region Вывод результата
Console.WriteLine("Исходный массив:");
foreach (string str in initialArray)
{
    Console.WriteLine(str);
}

Console.WriteLine("\nНовый массив:");
foreach (string str in resultArray)
{
    Console.WriteLine(str);
}
#endregion