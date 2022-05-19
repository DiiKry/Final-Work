string[] array = new string[5] {"hello", "86", "buy", "GitHub", "563"};
string[] NewArray = new string[array.Length];
void SecondArray(string[] array, string[] NewArray)
{
    int count = 0;
    for (int index = 0; index < array.Length; index++)
    {
    if(array[index].Length <= 3)
        {
        NewArray[count] = array[index];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int index = 0; index < array.Length; index++)
    {
        Console.Write($"{array[index]} ");
    }
    Console.WriteLine();
}
SecondArray(array, NewArray);
PrintArray(NewArray);