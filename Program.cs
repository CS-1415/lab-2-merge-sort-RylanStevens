using System.Diagnostics;

public class Program
{
    static void Main(string[] args)
{
    Debug.Assert(Enumerable.SequenceEqual(CombinedSortedArrays(new int[]{1, 3, 5}, new int []{-5, 3, 6, 7}), new int[]{-5, 1, 3, 3, 5, 6, 7}));
    Console.WriteLine("pass");
}
static int[] CombinedSortedArrays(int[] a, int[] b)
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
}