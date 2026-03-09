using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtentionMethod
{
    internal static class stringExt
    {
        public static void count1(this string s, string s1)
        {
            int count = 1;
            for(int i = 0; i < s.Length; i++)
            {
                if (s1[i] == ' ')
                {
                    count++;
                }
                
            }

            if (s1 == "")
            {
                Console.WriteLine("the count of world is 0");
            }
            else
            {
                Console.WriteLine("The count of world is " + count);
            }
        }
    }
}
