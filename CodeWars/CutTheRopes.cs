using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeWars
{
    public class CutTheRopes
    {
        public class Kata
        {
            public int[] CutTheRopes(int[] a)
            {
                //coding and coding..
                var returnArray = new int[a.Distinct().Count()];
                int remainingRopes = a.Length;
                int currentIndex = 0;
                var minLength = a.Min();
                var nextMin = a[0];
                do
                {
                    returnArray[currentIndex] = remainingRopes;
                    for (var i = 0; i < a.Length; i++)
                    {
                        if (a[i] == 0)
                        {
                            continue;
                        }
                        else
                        {
                            a[i] -= minLength;
                            if (!a.Contains(nextMin) && a[i] != 0)
                            {
                                nextMin = a[i];
                            }
                            if (a[i] < nextMin && a[i] > 0 && a[i] != minLength)
                            {
                                nextMin = a[i];
                            }

                            if (a[i] == 0)
                            {
                                remainingRopes--;
                            }

                        }

                    }


                    Console.WriteLine(returnArray[currentIndex]);
                    //Console.WriteLine(nextMin);
                    minLength = nextMin;

                    currentIndex++;


                } while (remainingRopes > 0);


                return returnArray;

            }
        }
    }
}
