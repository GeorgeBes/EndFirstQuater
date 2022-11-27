// Написать программу, которая из имеющегося массива строк формирует массив из строк, длинна которых
// меньше либо равна 3 символа.

string[] arrayFirst = new string[7] { "hello", "23", "wor", ":-)", "1223", "1567", "com" };
string[] arraySecond = new string[arrayFirst.Length];
void MethodNewArray(string[] arr1, string[] arr2)
{
    int count = 0;
    for (int i = 0; i < arr1.Length; i++)
    {
        if (arr1[i].Length <= 3)
        {
            arr2[count] = arr1[i];
            count++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

MethodNewArray(arrayFirst, arraySecond);
PrintArray(arraySecond);