using System.Dynamic;
using System.Reflection.Metadata.Ecma335;

string[] CreateStrArray(int size)
{
    string[] StringArray = new string[size];
    for (int i = 0; i < size; i++)
    {
        StringArray[i] = Console.ReadLine();
    }
    return StringArray;
}

void PrintArray(string[] StrArray)
{
    Console.Write($"String array: ");
    for (int i = 0; i < StrArray.Length; i++)
    {
        Console.Write($"{StrArray[i]} ");
    }
}

Console.WriteLine($"Input string array size: ");
int N = Convert.ToInt32(Console.ReadLine());
string[] NewArray = CreateStrArray(N);
Console.WriteLine();
PrintArray(NewArray);
Console.WriteLine();

string[] SecondStrArray(string[] array)
{
    string[] array2 = new string[array.Length];
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            array2[count] = array[i];
            count++;
        }
    }
    return array2;
}

string[] finalArray = SecondStrArray(NewArray);
Console.WriteLine("The new array which elements consist of 3 symbols: ");
PrintArray(finalArray);