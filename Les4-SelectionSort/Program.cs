// Сортировка выбором от min к max

using static Sorting;
// Благодаря ряду манипуляций, теперь наш файл ташит данные из файла Sorting
// Такой подход используется для оформления проектов

using static Infrastructure;

// int[] array = CreateArray(10);
// Print(array);
// SortSelection(array);
// Print(array);
// Старый способ, с использованием - this можем писать код иначе

10.CreateArray()
  .Print()
  .SortSelection()
  .Print();

// Можно так же писать его в одну строку 10.CreateArray().Print().SortSelection().Print();