using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.SysoevDA.Sprint6.TaskReview.V18.Lib
{
    public class DataService
    {
        public int GetMatrix(int[,] array, int n1, int n2, int c, int k, int l)
        {
            int rows = array.GetUpperBound(0) + 1;
            int columns = array.Length / rows;
            int sum = 0;
            if (k % 2 == 0)
                k++;

            for (int i = k; i < l; i++)
            {
                if (i % 2 != 0)
                    sum += array[c, i];
            }
            return sum;
        }
    }
}
