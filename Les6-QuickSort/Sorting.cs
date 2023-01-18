// Алгоритм быстрой сортировки или алгоритм сортировки Хуара - самый часто используемый алгоритм (1 из 3)
// Сложность данного алгоритма = 1/2*(n+n^2)
/*
Существует 3 способа задать опорный элемент:
1. Выбор из нескольких первый элементов массива
2. Рандом
3. Выбор числа равного к серединному значению, например значения в массиве задаются от 1 до n, тогда опорный эл = n/2
*/

public static class Sorting
{
    public static int[] SortQuick(int[] collection, int left, int right)
    {
        int i = left;
        int j = right;

        int pivot = collection[Random.Shared.Next(left, right)];
        while (i <= j)
        {
            while (collection[i] < pivot) i++;
            while (collection[j] > pivot) j--;

            if (i <= j)
            {
                int temp = collection[i];
                collection[i] = collection[j];
                collection[j] = collection[i];
                i++;
                j--;
            }
            if (i < right) SortQuick(collection, i, right);
            if (j > left) SortQuick(collection, left, j);
        }
        return collection;
    }
}