// Сортировка выбором от min к max

void SortSelection(int[] collection)
{
    int size = collection.Length;
    for (int i = 0; i < size - 1; i++)
    {
        int pos = i;
        for (int j = i + 1; j < size; j++)
        {
            if (collection[j] < collection[pos]) pos = j;
        }
        int temp = collection[i]; // временная переменная
        collection[i] = collection[pos]; // текущее значение, которое мы заменяем на меньшее
        collection[pos] = temp; // значение, которое ставим на место предыдущего минимального
    }
}

int[] array = { 7, 6, 3, 4, 5, 1, 2, 3 };
System.Console.WriteLine($"[{String.Join(", ",array)}]"); // Выводим массив на экран

SortSelection(array);
System.Console.WriteLine($"[{String.Join(", ",array)}]");
