using BubbleSortApp;
namespace BasicBubbleTests;

public class SortedMergeTests
{
    private List<int> listOne;
    private List<int> listTwo;
    private List<int> merged;
    [SetUp]
    public void SetUp()
    {
        listOne = new List<int>() { 1, 3, 5, 9 };
        listTwo = new List<int>() { 2,5,8,9 };
        merged = new List<int>() { 1, 2, 3, 5, 5, 8, 9, 9 };
    }
    [Test]
    public void GivenTwoLists_WhenMerged_ReturnMergedList()
    {
        Assert.That(merged,Is.EqualTo(SortedMerge.SortMerge(listOne,listTwo))); 
    }
    [Test]
    public void GivenNullList_WhenMerged_ReturnException()
    {
        Assert.That(() => SortedMerge.SortMerge(null, listOne), Throws.TypeOf<Exception>());
    }
    [Test]
    public void GivenNullList_WhenMerged_ReturnExceptionMessage()
    {
        Assert.That(() => SortedMerge.SortMerge(null, listOne), Throws.TypeOf<Exception>().With.Message.Contains("Cannot have a null list"));
    }
}
