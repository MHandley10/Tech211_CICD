using System.Text;

namespace BubbleSortApp;

public class Program
{
    static void Main(string[] args)
    {

        List<int> listToSort = new List<int>() { 155, 2, 3, 4 };
        List<int> listT = new List<int>() { 1, 27, 8 };
        Console.WriteLine(PrintList(Basic.BubbleSortWhileOptPlusOne(listToSort)));

        List<int> listToMerge = new List<int>() { 1, 3, 5, 9 };
        List<int> listToMerge1 = new List<int>() { 2, 5, 8, 9 };

        Console.WriteLine(PrintList(SortedMerge.SortMerge(listToMerge, listToMerge1)));

    }



    public static string PrintList(List<int> list)
    {
        StringBuilder sb = new StringBuilder();
        foreach (int num in list) { sb.Append($"{num},"); }
        return sb.Remove(sb.Length-1,1).ToString();
    }

}

