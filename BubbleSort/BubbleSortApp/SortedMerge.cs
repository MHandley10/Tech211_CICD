using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSortApp;

public class SortedMerge
{
    public static List<int> SortMerge(List<int> list1, List<int> list2)
    {
        if (list1 is null || list2 is null) throw new Exception("Cannot have a null list");

        List<int> mergedList = new List<int>();

        int count1 = 0;

        int count2 = 0;

        while (count1 < list1.Count && count2 < list2.Count)
        {
            if (list1[count1] < list2[count2])
            {
                mergedList.Add(list1[count1]);
                count1++;
            }
            else if (list1[count1] > list2[count2])
            {
                mergedList.Add(list2[count2]);
                count2++;
            }
            else
            {
                mergedList.Add(list1[count1]);
                mergedList.Add(list2[count2]);
                count1++;
                count2++;
            }
        }


        return mergedList;
    }
}
