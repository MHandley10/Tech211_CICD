using SortManagerApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortManagerApp.View;

public class Viewer
{

    public Viewer() { }

public static int ArrayChooser()
    {

        int arraySize = 0;

        bool notInt = true;

        Console.WriteLine("Hello! Welcome to the sorting algorithm deluxe!");

        Console.Write("\nPlease enter the size of array you would like to sort (between 1 and 20 inclusive):\n\n");

        notInt = Int32.TryParse(Console.ReadLine(), out arraySize);

        if (!notInt)
        {

            throw new ArgumentException("Please enter an integer between 1 and 20 inclusive");

        }
        else if (arraySize > 20 || arraySize < 0)
        {

            throw new ArgumentOutOfRangeException("Please enter an integer between 1 and 20 inclusive");

        }
        Console.Clear();
        
        return arraySize;
    }

    public static int SortChooser()
    {

        int algorithmChoice = 0;

        Console.WriteLine("Your array is now ready!\n\nPlease choose the sorting algorithm you want by inputting the correlated number from the following:\n\n");
        Console.Write("1 - Bubble sort\n2 - Merge sort\n3 - DotNet sort\n\n");

        bool notInt = Int32.TryParse(Console.ReadLine(), out algorithmChoice);


        if (!notInt)
        {

            throw new ArgumentException("Please enter an integer between 1 and 3 inclusive");

        }
        else if (algorithmChoice < 1 || algorithmChoice > 3)
        {

            throw new ArgumentOutOfRangeException("Please enter an integer between 1 and 3 inclusive");

        }

        return algorithmChoice;

    }

    public static void SortReturn()
    {
        Console.WriteLine($"You chose the {Controller.Controller.SortChosen}");
        Console.WriteLine($"Your sorted array is {Controller.Controller.GetArrayString()}, it took {Controller.Controller.Time}ms");
    }

}
