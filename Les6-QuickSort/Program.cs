/* Пример:


 0  1   2  3  4  5  6
{1, 0, -6, 2, 5, 3, 2} = array
pivot = array[6] (опорный/начальный элемент)

{1, 0, -6, 2, |2|, 5, 3}
Выбираем опорные элементы в подмассивах:
Левый:
    {1, 0, -6, 2}
    pivot = 2
    {1, 0, -6, |2|}
    pivot = -6
    { -6, 1, 0}
    pivot = 0
    {0, 1}
Правый:
    {5, 3}
    pivot = 3 
    {3, 5}
*/

int[] array = { 0, -5, 2, 3, 5, 9, -1, 7 };
int[] res = QuickSort(array, 0, array.Length - 1);

System.Console.Write($"Отсортированный массив это: {string.Join(", ", res)}");

int[] QuickSort(int[] inputArray, int minIndex, int maxIndex)
{
    if (minIndex >= maxIndex) return inputArray;
    int pivot = GetPivotIndex(inputArray, minIndex, maxIndex);
    QuickSort(inputArray, minIndex, pivot - 1);
    QuickSort(inputArray, pivot + 1, maxIndex);
    return inputArray;
}

int GetPivotIndex(int[] inputArray, int minIndex, int maxIndex)
{
    int pivotIndex = minIndex - 1;
    for (int i = minIndex; i <= maxIndex; i++)
    {
        if (inputArray[i] < inputArray[maxIndex])
        {
            pivotIndex++;
            Swap(ref inputArray[pivotIndex], ref inputArray[i]);
        }
    }
    pivotIndex++;
    Swap(ref inputArray[pivotIndex], ref inputArray[maxIndex]);
    return pivotIndex;
}

void Swap(ref int leftValue, ref int rightValue)
{
    int temp = leftValue;
    leftValue = rightValue;
    rightValue = temp;
}