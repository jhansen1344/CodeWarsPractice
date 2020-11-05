using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars
{
    public class CheckForDuplicates
    {

        public static bool CheckForMultiple(int[] inputArray)
        {
            var inputHashSet = new HashSet<int>();
            foreach (var item in inputArray)
            {
                if(inputHashSet.Contains(item))
                {
                    return true;
                }
                inputHashSet.Add(item);
            }

            return false;
        }
    }
}
