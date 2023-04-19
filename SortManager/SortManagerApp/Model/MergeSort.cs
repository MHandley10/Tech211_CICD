namespace SortManagerApp.Model;

public class MergeSort : ISortable
{

    public int[] Sort(int[] arr)
    {
        return RecursiveMergeSort(arr).ToArray();
    }

    public List<int> RecursiveMergeSort(int[] arr)
    {
        List<int> numList = arr.ToList();
        if (numList.Count <= 1) return numList;

        var left = new List<int>();
        var right = new List<int>();

        for (int i = 0; i < numList.Count; i++)
        {
            if (i < numList.Count / 2) left.Add(numList[i]);
            else right.Add(numList[i]);
        }

        left = RecursiveMergeSort(left.ToArray());
        right = RecursiveMergeSort(right.ToArray());

        return Merge(left, right);

    }

    private List<int> Merge(List<int> left, List<int> right)
    {
        var result = new List<int>();

        while (left.Count != 0 && right.Count != 0)
        {
            if (left[0] <= right[0])
            {
                result.Add(left[0]);
                left.RemoveAt(0);
            }
            else
            {
                result.Add(right[0]);
                right.RemoveAt(0);
            }
        }

        // either left or right contains some elements and we dump the remaining elements in either
        while (left.Count != 0)
        {
            result.Add(left[0]);
            left.RemoveAt(0);
        }
        while (right.Count != 0)
        {
            result.Add(right[0]);
            right.RemoveAt(0);
        }

        return result;
    }
}
