public static class Sorting
{
    /// <summary>
    /// Сортировка методом выбора
    /// </summary>
    /// <param name="array">Исходный массив</param>
    /// <returns>Отсортированный массив</returns>
    public static int[] SortSelection(this int[] array)
    {
        int size = array.Length;
        for (int i = 0; i < size - 1; i++)
        {
            int min = array[i], index = i;
            for (int j = i + 1; j < size; j++)
                if (array[j] < min)
                {
                    min = array[j];
                    index = j;
                }
            array[index] = array[i];
            array[i] = min;
        }
        return array;
    }
}