string[] arrayOne = new string[5] { "757", "23", "ZiDan", "Metallica", "ROW" };
string[] arrayTwo = new string[arrayOne.Length];
void SecondArray(string[] arrayOne, string[] arrayTwo)
{
    int count = 0;
    for (int i = 0; i < arrayOne.Length; i++)
    {
        if (arrayOne[i].Length <= 3)
        {
            arrayTwo[count] = arrayOne[i];
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
    Console.WriteLine();
}
SecondArray(arrayOne, arrayTwo);
PrintArray(arrayTwo);