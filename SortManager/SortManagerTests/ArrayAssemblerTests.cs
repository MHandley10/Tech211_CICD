using SortManagerApp.Model;

namespace SortManagerTests;

public class ArrayAssemblerTests
{
    [TestCase(1)]
    [TestCase(10)]
    [TestCase(20)]
    public void GivenInteger_GenerateRandomArray_ReturnsArrayOfCorrectLength(int size)
    {
        int[] answer = ArrayAssembler.GenerateRandomArray(size);
        Assert.That(answer.Length, Is.EqualTo(size));
    }

    [TestCase(-3)]
    [TestCase(0)]
    [TestCase(21)]
    [TestCase(26)]
    public void GivenInvalidInteger_GenerateRandomArray_ThrowsArgumentOutOfRangeException(int size)
    {
        Assert.That(() => ArrayAssembler.GenerateRandomArray(size), 
            Throws.TypeOf<ArgumentOutOfRangeException>().With.Message.Contain("Size must be between 1-20"));
    }

    [TestCase(1)]
    [TestCase(7)]
    [TestCase(20)]
    public void GivenArray_ContainsValidNumbersWithinRange(int size)
    {
        int[] answer = ArrayAssembler.GenerateRandomArray(size);

        Assert.That(answer, Is.All.InRange(-1000, 1000));
    }

}
