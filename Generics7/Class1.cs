using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics7
{
    public class MinimumFinder<T> where T : IComparable<T>
    {
        public T FindMinimum(T variable1, T variable2, T variable3)
        {
            T min = variable1;
            if (variable2.CompareTo(min) < 0)
            {
                min = variable2;
            }
            if (variable3.CompareTo(min) < 0)
            {
                min = variable3;
            }
            return min;
        }
    }
}
