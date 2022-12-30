
Console.Write("Какое количество слов будет в массиве: ");
int size = Convert.ToInt32(Console.ReadLine());
string[] arrayStrings = new string[size];
int len = 4;
int count = 0;


void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

for (int i = 0; i < size; i++)
{
 Console.WriteLine($"Введите {i+1}-е слово: ");
 string element = Convert.ToString(Console.ReadLine());
 if (element.Length < len)
    {
 arrayStrings[count] = element;
 count++;
    }
}
Console.WriteLine();
PrintArray(arrayStrings);
