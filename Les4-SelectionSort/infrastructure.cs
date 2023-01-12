public static class Infrastructure
{

    public static int[] CreateArray(int size, int min = 0, int max = 10)
    // Метод отвечающий за создание массива
    {
        return Enumerable.Range(1, size)
                         .Select(item => Random.Shared.Next(min, max))
                         .ToArray();
    }

    public static void Print(int[] array)
    // Метод отвечающий за печать массива
    {
        System.Console.WriteLine($"[{String.Join(", ", array)}]"); // Выводим массив на экран
    }

}