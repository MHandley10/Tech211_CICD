using SortManagerApp.Model;
using SortManagerApp.View;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortManagerApp.Controller;

public class Controller
{

    public static long Time { get; set; }

    public static string SortChosen { get; set; }

    public static int[] RandomArray { get; set; }

    public static int[] SortedArray { get; set; }


    public static void Run()
    {
        RandomArray = GenerateRandomArray(Viewer.ArrayChooser());
        int sortNumber = Viewer.SortChooser();
        CallSortAlgorithm(sortNumber);
        Viewer.SortReturn();

    }

    public static void CallSortAlgorithm(int sortNumber)
    {
        // display chosen sort, store sorted array, return algrithm chosen name and time and result
        switch (sortNumber)
        {
            case 1:
                SortChosen = "1 - Bubble sort";
                //bubblesort
                DoSort(new BubbleSort());
                break;
            case 2:
                //mergesort
                SortChosen = "2 - Merge sort";
                DoSort(new MergeSort());
                break;
            case 3:
                //DotNetSort
                SortChosen = "3 - DotNet sort";
                DoSort(new DotNetSort());
                break;
            default: // BubbleSort)
                SortChosen = "1 - Bubble sort";
                DoSort(new BubbleSort());
                break;
        }
    }

    private static void DoSort(ISortable sortType)
    {
        Stopwatch s = new Stopwatch();
        s.Start();
        SortedArray = sortType.Sort(RandomArray);
        s.Stop();
        Time = s.ElapsedMilliseconds;
    }

    public static int[] GenerateRandomArray(int size)
    {
        Random rand = new Random();
        int[] randArr = new int[size];

        for (int i = 0; i < randArr.Length; i++)
        {
            randArr[i] = rand.Next(-1000, 1000);
        }

        return randArr;
    }

    public static string GetArrayString()
    {
        StringBuilder array = new StringBuilder();
        foreach (var item in SortedArray)
        {
            array.Append(item + " ");
        }
        return array.ToString();
    }

}
