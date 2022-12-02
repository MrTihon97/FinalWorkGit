string[] array = Input();
string[] result = LessOreQually(array, 3);
Console.WriteLine($"[{string.Join(", ", array)}] -> [{string.Join(", ", result)}]");

string[] LessOreQually(string[]
enter, int n)
{
    string[] result = new string[CountLessOreQually(enter, n)];

    for (int i = 0, j = 0; i < enter.Length; i++)
    {
        if (enter[i].Length <= n)
        {
            result[j] = enter[i];
            j++;
        }
    }

    return result;
}

int CountLessOreQually(string[] enter, int n)
{
    int count = 0;

    for (int i = 0; i < enter.Length; i++)
    {
        if (enter[i].Length <= n)
        {
            count++;
        }
    }

    return count;
}

string[] Input()
{
    Console.WriteLine("Введите значения через пробел: ");
    string[] input = Console.ReadLine().Split();
    return input;
}