using SortManagerApp.Model;

namespace SortManagerTests;

public class MergeSortTests
{

    [Test]
    public void GivenUnsortedListWithAllNegativeValues_RecursiveMergeSort_ReturnsSortedList()
    {
        int[] ArrayToSort = { -155, -2, -3, -4, -58, -2 };
        int[] ArraySorted = { -155, -58, -4, -3, -2, -2 };

        MergeSort s = new MergeSort();

        Assert.That(s.Sort(ArrayToSort), Is.EqualTo(ArraySorted));
    }

    [Test]
    public void GivenUnsortedListWithNegativeValues_RecursiveMergeSort_ReturnsSortedList()
    {
        int[] ArrayToSort = { -155, -2, 3, 4, -58, 2 };
        int[] ArraySorted = { -155, -58, -2, 2, 3, 4 };

        MergeSort s = new MergeSort();

        Assert.That(s.Sort(ArrayToSort), Is.EqualTo(ArraySorted));
    }

    [Test]
    public void GivenUnsortedList_RecursiveMergeSort_ReturnsSortedList()
    {
        int[] ArrayToSort = { 155, 2, 3, 4 };
        int[] ArraySorted = { 2, 3, 4, 155 };

        MergeSort s = new MergeSort();

        Assert.That(s.Sort(ArrayToSort), Is.EqualTo(ArraySorted));
    }


    [Test]
    public void GivenUnsortedList_RecursiveMergeSort_ReturnsSortedList1()
    {
        int[] ArrayToSort = { 8, 6, 2, 8, 7, 9 };
        int[] ArraySorted = { 2, 6, 7, 8, 8, 9 };

        MergeSort s = new MergeSort();

        Assert.That(s.Sort(ArrayToSort), Is.EqualTo(ArraySorted));
    }

    
    [Test]
    public void GivenUnsortedList_RecursiveMergeSort_ReturnsSortedList2()
    {
        int[] ArrayToSort = { 1 };
        int[] ArraySorted = { 1 };

        MergeSort s = new MergeSort();

        Assert.That(s.Sort(ArrayToSort), Is.EqualTo(ArraySorted));
    }

    [Test]
    public void GivenUnsortedList_RecursiveMergeSort_ReturnsSortedList3()
    {
        int[] ArrayToSort = { };
        int[] ArraySorted = { };

        MergeSort s = new MergeSort();

        Assert.That(s.Sort(ArrayToSort), Is.EqualTo(ArraySorted));
    }
}
