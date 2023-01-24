public static class Sorting
{
    public static void SortSelection(int[] array, int size)
    {
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
    }
}