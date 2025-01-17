
using System;


public class QuickSort
{
    // Int
    public static void Sort(int[] array)
    {
        Sort(array, 0, array.Length - 1);
    }

    public static void Sort(int[] array, int left, int right)
    {
        if (left < right)
        {
            int pivot = Partition(array, left, right);

            Sort(array, left, pivot - 1);
            Sort(array, pivot + 1, right);
        }
    }

    private static int Partition(int[] arr, int left, int right)
    {
        int pivot = arr[right];
        int i = left - 1;

        for (int j = left; j < right; j++)
        {
            if (arr[j] <= pivot)
            {
                i++;
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }

        int temp1 = arr[i + 1];
        arr[i + 1] = arr[right];
        arr[right] = temp1;

        return i + 1;
    }

    // Generic
    public static void Sort<T>(T[] array, Func<T, T, int> comparison)
    {
        Sort(array, 0, array.Length - 1, comparison);
    }

    public static void Sort<T>(T[] array, int left, int right, Func<T, T, int> comparison)
    {
        if (left < right)
        {
            int pivot = Partition(array, left, right, comparison);

            Sort(array, left, pivot - 1, comparison);
            Sort(array, pivot + 1, right, comparison);
        }
    }

    private static int Partition<T>(T[] array, int left, int right, Func<T, T, int> comparison)
    {
        T pivot = array[right];
        int i = left - 1;

        for (int j = left; j < right; j++)
        {
            //if (array[j] <= pivot)
            if(comparison(array[j], pivot) < 1)
            {
                i++;
                T temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
        }

        T temp1 = array[i + 1];
        array[i + 1] = array[right];
        array[right] = temp1;

        return i + 1;
    }
}
