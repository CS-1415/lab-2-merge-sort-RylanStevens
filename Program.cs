using System.Diagnostics;

public class Program
{
    static void Main(string[] args)
{
    System.Diagnostics.Debug.Assert(Enumerable.SequenceEqual(CombineSortedArrays(new int[]{1, 3, 5}, new int []{-5, 3, 6, 7}), new int[]{-5, 1, 3, 3, 5, 6, 7}));
    System.Diagnostics.Debug.Assert(Enumerable.SequenceEqual(CombineSortedArrays(new int[]{-5, 2, 5, 8, 10}, new int[]{1, 2, 5}), new int[]{-5, 1, 2, 2, 5, 5, 8, 10}));
    System.Diagnostics.Debug.Assert(Enumerable.SequenceEqual(SortViaMergesort(new int[]{6, 1, -5, 3, 5, 3, 7}), new int[]{-5, 1, 3, 3, 5, 6, 7}));
    System.Diagnostics.Debug.Assert(Enumerable.SequenceEqual(SortViaMergesort(new int[]{1, 10, -5, 2, 5, 2, 5, 8}), new int[]{-5, 1, 2, 2, 5, 5, 8, 10}));
    Console.WriteLine("pass");
}
static int[] CombineSortedArrays(int[] a, int[] b)
{
    int[] combined = new int[a.Length + b.Length];
    int aIndex = 0, bIndex = 0, combinedIndex = 0;
    while (aIndex < a.Length && bIndex < b.Length)
    {
        if (a[aIndex] < b[bIndex])
        {
            combined[combinedIndex++] = a[aIndex++];
        }
        else
        {
            combined[combinedIndex++] = b[bIndex++];
        }
    }
    while (aIndex < a.Length)
    {
        combined[combinedIndex++] = a[aIndex++];
    }
    while (bIndex < b.Length)
    {
        combined[combinedIndex++] = b[bIndex++];
    }
    return combined;
}

public static int[] SortViaMergesort(int[] values)
{
    if (values.Length < 2)
    {
        return (int[])values.Clone();
    }
    int middle = values.Length / 2;
    int[] firstHalf = values[0..middle];
    int[] secondHalf = values[middle..values.Length];
    return CombineSortedArrays(SortViaMergesort(firstHalf), SortViaMergesort(secondHalf));

}
}