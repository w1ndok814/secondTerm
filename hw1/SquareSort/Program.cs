namespace SquareSort;

using System;

class Square_sort
{
    public static void Main()
    {
        if (!Test())
        {
            Console.WriteLine("Tests failes");
        }
    }
    private static void Swap(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }
    public static int[] BubbleSort(int[] arr)
    {
        for (int i = 1; i < arr.Length; i++)
        {
            for (int j = 0; j < arr.Length - i; j++)
            {
                if (arr[j] > arr[j + 1])
                    Swap(ref arr[j], ref arr[j + 1]);
            }
        }
        return arr;
    }
    public static bool Test()
    {
        int[] testArr1 = { 1, 2, 3, 4, 10, 5, 6 };
        int[] testArr2 = { 9, 8, 7, 6, 5, 4, 3, 2, 1 };
        int[] testArr3 = { 0, 0, 0, 0, 0, 0, 0 };
        int[] testArr4 = { -1, 1, -1, 1, 1, -1 };
        if (!IsSorted(BubbleSort(testArr1))) return false;
        if (!IsSorted(BubbleSort(testArr2))) return false;
        if (!IsSorted(BubbleSort(testArr3))) return false;
        if (!IsSorted(BubbleSort(testArr4))) return false;
        return true;
    }
    public static bool IsSorted(int[] arr)
    {
        for (int i = 0; i < arr.Length - 1; i++)
            if (arr[i] > arr[i + 1]) return false;
        return true;
    }
}