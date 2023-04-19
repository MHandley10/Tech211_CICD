

namespace SortManagerApp.Model;

public class BubbleSort : ISortable
{
    public int[] Sort(int[] myArray)
    {
        if (myArray == null) throw new ArgumentException();

        bool isSorted = true;

        for (int i = 0; i < myArray.Length; i++)
        {
            for (int j = 1; j < myArray.Length - i; j++)
            {
                if (myArray[j] < myArray[j - 1])
                {
                    Swap(myArray, j, j - 1);
                    isSorted = false;
                }
            }
            if (isSorted)
                return myArray;
        }
        return myArray;

    }
    public static void Swap(int[] myArray, int index1, int index2)
    {
        int tempVar = myArray[index1];
        myArray[index1] = myArray[index2];
        myArray[index2] = tempVar;
    }

}
