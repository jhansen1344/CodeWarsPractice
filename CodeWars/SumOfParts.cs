using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars
{
    public class SumOfParts
    {
        public static int[] PartsSums(int[] ls)
        {
            var lsLength = ls.Length;
            var returnArray = new int[lsLength + 1];
            var initialSum = 0;
            if (lsLength == 0)
                return new int[] { 0 };
            returnArray[lsLength] = 0;
            for (var i = lsLength - 2; i >= 0; i--)
            {
                initialSum += ls[i + 1];
                returnArray[i + 1] = initialSum;
            }

            returnArray[0] = initialSum + ls[0];

            return returnArray;
        }
    }
}
