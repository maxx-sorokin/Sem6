string[] array = new string[3] { "Vitalya", "Vasya", "Ivan" };

string[] reversedArray = ReverseArray(array);
PrintArray(array);
Console.WriteLine();
PrintArray(reversedArray);

string[] ReverseArray(string[] array)
{
    string[] reversed = new string[array.Length];

    for (int i = 0; i < array.Length; i++)
    {
        reversed[i] = array[array.Length - 1 - i];
    }
    return reversed;
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}