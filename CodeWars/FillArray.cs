using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars
{
    public class FillArray
    {
        public static int[] Arr(int N)
        {

            var returnArray = new int[N];
            for (int i = 0; i < N; i++)
            {

                returnArray[i] = i;
            }
            return returnArray;
        }
    }
}
