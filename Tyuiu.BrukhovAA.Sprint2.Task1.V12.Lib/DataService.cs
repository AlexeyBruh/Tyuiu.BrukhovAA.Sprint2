using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.BrukhovAA.Sprint2.Task1.V12.Lib
{
    public class DataService : ISprint2Task1V12
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];
            res[0] = (a == b + 36) | (c == d + 331);
            res[1] = (a != b) & (c != d );
            res[2] = (a < b) || (c < d + 1000 );
            res[3] = (a > b) && (c > d + 1000);
            res[4] = ! (a <= b);
            res[5] = (a >= b) ^ (c >= d);
            return res;
        }
    }
}
