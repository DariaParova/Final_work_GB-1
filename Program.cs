// 

string[] arrayone = new string[4] {"hello", "2", "world", ":-)"};
string[] arraytwo = new string[arrayone.Length];
void SecondArrayWithIF(string[] arrayone, string[] arraytwo)
{
    int count = 0;
    for (int i = 0; i < arrayone.Length; i++)
    {
    if(arrayone[i].Length <= 3)
        {
        arraytwo[count] = arrayone[i];
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
SecondArrayWithIF(arrayone, arraytwo);
PrintArray(arraytwo);
