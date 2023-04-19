using BubbleSortApp;

namespace BasicBubbleTests;

public class BasicBubbleTests
{


    [Test]
    public void GivenUnsortedList_BasicBubbleSort_ReturnsSortedList()
    {
        List<int> ListToSort = new List<int>() { 155, 2, 3, 4 };
        List<int> ListSorted = new List<int>() { 2, 3, 4, 155 };

        Assert.That(Basic.BubbleSort(ListToSort), Is.EqualTo(ListSorted));
    }


    [Test]
    public void GivenUnsortedList_BasicBubbleSort_ReturnsSortedList1()
    {
        List<int> ListToSort = new List<int>() { 8, 6, 2, 8, 7, 9 };
        List<int> ListSorted = new List<int>() { 2, 6, 7, 8, 8, 9 };

        Assert.That(Basic.BubbleSort(ListToSort), Is.EqualTo(ListSorted));
    }


    [Test]
    public void GivenUnsortedList_BasicBubbleSort_ReturnsSortedList2()
    {
        List<int> ListToSort = new List<int>() { 1};
        List<int> ListSorted = new List<int>() { 1};

        Assert.That(Basic.BubbleSort(ListToSort), Is.EqualTo(ListSorted));
    }

    [Test]
    public void GivenUnsortedList_BasicBubbleSort_ReturnsSortedList3()
    {
        List<int> ListToSort = new List<int>() {};
        List<int> ListSorted = new List<int>() {};

        Assert.That(Basic.BubbleSort(ListToSort), Is.EqualTo(ListSorted));
    }




    [Test]
    public void GivenUnsortedList_BasicBubbleSortOpt_ReturnsSortedList()
    {
        List<int> ListToSort = new List<int>() { 155, 2, 3, 4 };
        List<int> ListSorted = new List<int>() { 2, 3, 4, 155 };

        Assert.That(Basic.BubbleSortWhileOpt(ListToSort), Is.EqualTo(ListSorted));
    }


    [Test]
    public void GivenUnsortedList_BasicBubbleSortOpt_ReturnsSortedList1()
    {
        List<int> ListToSort = new List<int>() { 8, 6, 2, 8, 7, 9 };
        List<int> ListSorted = new List<int>() { 2, 6, 7, 8, 8, 9 };

        Assert.That(Basic.BubbleSortWhileOpt(ListToSort), Is.EqualTo(ListSorted));
    }


    [Test]
    public void GivenUnsortedList_BasicBubbleSortOpt_ReturnsSortedList2()
    {
        List<int> ListToSort = new List<int>() { 1 };
        List<int> ListSorted = new List<int>() { 1 };

        Assert.That(Basic.BubbleSortWhileOpt(ListToSort), Is.EqualTo(ListSorted));
    }

    [Test]
    public void GivenUnsortedList_BasicBubbleSortOpt_ReturnsSortedList3()
    {
        List<int> ListToSort = new List<int>() { };
        List<int> ListSorted = new List<int>() { };

        Assert.That(Basic.BubbleSortWhileOpt(ListToSort), Is.EqualTo(ListSorted));
    }


    [Test]
    public void GivenUnsortedList_BasicBubbleSortOptPlusOne_ReturnsSortedList()
    {
        List<int> ListToSort = new List<int>() { 155, 2, 3, 4 };
        List<int> ListSorted = new List<int>() { 2, 3, 4, 155 };

        Assert.That(Basic.BubbleSortWhileOptPlusOne(ListToSort), Is.EqualTo(ListSorted));
    }

    [Test]
    public void GivenUnsortedList_BasicBubbleSortOptPlusOne_ReturnsSortedList1()
    {
        List<int> ListToSort = new List<int>() { 8, 6, 2, 8, 7, 9 };
        List<int> ListSorted = new List<int>() { 2, 6, 7, 8, 8, 9 };

        Assert.That(Basic.BubbleSortWhileOptPlusOne(ListToSort), Is.EqualTo(ListSorted));
    }

    [Test]
    public void GivenUnsortedList_BasicBubbleSortOptPlusOne_ReturnsSortedList2()
    {
        List<int> ListToSort = new List<int>() { 1 };
        List<int> ListSorted = new List<int>() { 1 };

        Assert.That(Basic.BubbleSortWhileOptPlusOne(ListToSort), Is.EqualTo(ListSorted));
    }

    [Test]
    public void GivenUnsortedList_BasicBubbleSortOptPlusOne_ReturnsSortedList3()
    {
        List<int> ListToSort = new List<int>() { };
        List<int> ListSorted = new List<int>() { };

        Assert.That(Basic.BubbleSortWhileOptPlusOne(ListToSort), Is.EqualTo(ListSorted));
    }
}