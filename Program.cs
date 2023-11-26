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
        Console.Write($"{StrArray[i]}, ");
    }
    Console.Write($"\b\b ");
}

Console.WriteLine($"Input string array size: ");
int N = Convert.ToInt32(Console.ReadLine());
PrintArray(CreateStrArray(N));