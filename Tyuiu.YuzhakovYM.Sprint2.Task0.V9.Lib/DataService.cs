using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.YuzhakovYM.Sprint2.Task0.V9.Lib
{
    public class DataService : ISprint2Task0V9
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] res = { y + 679 == x, x != y, y < x, x > y, y <= x, y >= x };
            return res;

        }
    }
}
