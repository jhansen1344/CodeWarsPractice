using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars
{
    public class StringDoubles
    {
        public static string Doubles(string str)
        {
            char[] stringSplit = str.ToCharArray();
            string returnString = "";
            for (int i = 0; i < stringSplit.Length - 1; i++)
            {
                if (stringSplit[i] != stringSplit[i + 1])
                {
                    returnString += stringSplit[i];
                }
                else
                {
                    i++;
                }

            }
            if (stringSplit[stringSplit.Length - 1] != stringSplit[stringSplit.Length - 2])
            {
                returnString += stringSplit[stringSplit.Length - 1];
            }
            return returnString;
        }
    }
}
