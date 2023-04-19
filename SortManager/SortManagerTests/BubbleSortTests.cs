using SortManagerApp.Model;
using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace SortManagerTests;

public class Tests
{
    
    BubbleSort bubble1 = new BubbleSort();

    [TestCase(new int[] { 2, 1, 5, 3, 8, 6 }, new int[] { 1, 2, 3, 5, 6, 8 })]
    [TestCase(new int[] { 1, 2, 3, 5, 6, 8 }, new int[] { 1, 2, 3, 5, 6, 8 })]
    public void GivenUnsortedArray_BubbleSort_ReturnsSortedArray(int[] array, int[] expectedArray)
    {
        
        Assert.That(bubble1.Sort(array), Is.EqualTo(expectedArray));
    }

    [Ignore("Test not relevant yet")]
    [TestCase(new int[] { 2, 1, -1001, 3, 8, 6 })]
    [TestCase(new int[] { 2, 1, 1001, 3, 8, 6 })]
    [TestCase(new int[] { 2, 1, 1034, 3, 8, 6 })]
    [TestCase(new int[] { 2, 1, -1051, 3, 8, 6 })]
    public void GivenNumberOutsideBounds_Sort_ThrowsArgumentException(int[] array)
    {
        Assert.That(() => bubble1.Sort(array), Throws.TypeOf<ArgumentException>());
    }
    
    [TestCase(new int[]{}, new int[] { })]
    public void GivenEmptyArray_Sort_ReturnsEmptyArray(int[] array, int[] expResult)
    {
        Assert.That(bubble1.Sort(array), Is.EqualTo(expResult));
    }
    
    [TestCase(null)]
    public void GivenNullArray_Sort_ThrowsArgumentException(int[] array)
    {
        Assert.That(() => bubble1.Sort(array), Throws.TypeOf<ArgumentException>());
    }

    [TestCase(new int[] { 2, -1, 5, 3, -8, 6 }, new int[] {-8, -1, 2, 3, 5, 6})]
    [TestCase(new int[] { -1, 2, -3, 5, 6, 8 }, new int[] {-3, -1, 2, 5, 6, 8 })]
    public void GivenNegativeNumbers_BubbleSort_ReturnsSortedArray(int[] array, int[] expectedArray)
    {

        Assert.That(bubble1.Sort(array), Is.EqualTo(expectedArray));
    }

    [TestCase(new int[] { 2, 6, 1, 5, 3, 8, 6 }, new int[] {  1, 2, 3, 5, 6, 6, 8 })]
    [TestCase(new int[] { 3, 1, 2, 3, 5, 6, 8 }, new int[] { 1, 2, 3, 3, 5, 6, 8 })]
    public void GivenDuplicateNumbers_BubbleSort_ReturnsSortedArray(int[] array, int[] expectedArray)
    {

        Assert.That(bubble1.Sort(array), Is.EqualTo(expectedArray));
    }
}