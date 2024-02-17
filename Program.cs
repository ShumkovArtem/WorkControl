void Result(string[] onestr, string[] twostr)
{
    int count = 0;
    for (int i = 0; i < onestr.Length; i++)
    {
    if(onestr[i].Length <= 3)
        {
        twostr[count] = onestr[i];
        count++;
        }
    }
}

void Printstr(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
string[] onestr = new string [6] {"hello", "-2", "world", "-)", "Denmark", "123"};
string[] twostr = new string[onestr.Length];
Console.WriteLine( "Первоначальный массив:");
Printstr(onestr);
Result(onestr, twostr);
Console.WriteLine( "Массив из строк меньше, либо равных трем:");
Printstr(twostr);