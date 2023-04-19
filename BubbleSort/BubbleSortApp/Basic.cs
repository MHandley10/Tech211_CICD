namespace BubbleSortApp;

public class Basic
{
    public static List<int> BubbleSort(List<int> listIn)
    {
        for (int i = 0; i < listIn.Count - 1; i++)
        {
            for (int j = i + 1; j < listIn.Count; j++)
            {
                if (listIn[i] > listIn[j])
                {
                    Swap(listIn, i, j);
                }
            }
        }
        return listIn;
    }

    public static void Swap(List<int> listIn, int i, int j)
    {
        int temp = listIn[j];
        listIn[j] = listIn[i];
        listIn[i] = temp;
    }

    public static List<int> BubbleSortWhile(List<int> listIn)
    {
        bool swapped = true;
        while (swapped)
        {
            swapped = false;
            for(int i = 0; i <= listIn.Count-2;i++)
            {
                if (listIn[i] > listIn[i+1])
                {
                    Swap(listIn, i, i+1);
                    swapped = true;
                }
            }

        }
        return listIn;
    }

    public static List<int> BubbleSortWhileOpt(List<int> listIn)
    {
        int n = listIn.Count;
        bool swapped = true;
        while (swapped)
        {
            swapped = false;
            for (int i = 0; i <= n - 2; i++)
            {
                if (listIn[i] > listIn[i + 1])
                {
                    Swap(listIn, i, i + 1);
                    swapped = true;
                }
            }
            n -= 1;

        }
        return listIn;
    }

    public static List<int> BubbleSortWhileOptPlusOne(List<int> listIn)
    {
        /*        int newN = 0;
                int n = listIn.Count;
                while (n > 1)
                {
                    for (int i = 0; i <= n - 2; i++)
                    {
                        if (listIn[i] > listIn[i + 1])
                        {
                            Swap(listIn, i, i + 1);
                            newN = i - 1;
                        }
                    }
                    n = newN;
                }
                return listIn;*/

        int n = listIn.Count;
        int newN;

        while (n > 1)
        {
            newN = 0;

            for (int i = 1; i <= n - 1; i++)
            {
                if (listIn[i - 1] > listIn[i])
                {
                    Swap(listIn, i - 1, i);
                    newN = i;
                }
            }
            n = newN;
        }
        return listIn;
    }
}
