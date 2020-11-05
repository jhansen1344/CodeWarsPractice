using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CodeWars
{
    public class PyramidArray
    {

        public static int[][] Pyramid(int n)
        {
            // your code here
            if (n == 0)
                return new int[][] { };
            var returnArray = new int[][,] { };
            var testHashSet = new HashSet<int>();

           var inputString = "test";
            var inputLength = inputString.Length;
            var stringArray = inputString.ToCharArray();
            var charDictionary = new Dictionary<char, int>();
            foreach (var item in stringArray)
            {
                if(!charDictionary.ContainsKey(item))
                {
                    charDictionary.Add(item, 1);
                }
                else
                {
                    charDictionary[item] ++;
                }
            }
            var maxOdd = 0;
            foreach (var item in charDictionary)
            {
                if (item.Value % 2 == 1)
                    maxOdd++;

                if (maxOdd > 1)
                    return false;

            }
            return true;



                return returnArray;
        }
        
	{
            
            
	}
    }


}
