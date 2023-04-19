using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortManagerApp.Model;

public class DotNetSort :  ISortable
{
    public int[] Sort(int[] array)
    {
        Array.Sort(array);

        return array;
    }
}
