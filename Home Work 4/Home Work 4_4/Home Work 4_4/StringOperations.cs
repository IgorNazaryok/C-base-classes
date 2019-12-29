using System;
using System.Collections.Generic;
using System.Text;

namespace Home_Work_4_4
{
   static  class StringOperations
    {
        public static string SubString(this string value, int a)
        {
            string temp = "";
            int i = 0;
            while (i + a < value.Length)
            {
                temp += value[i + a];
                i++;
            }
            return temp;
        }
        public static string SubString(this string value, int a, int b)
        {
            string temp = "";
            int i = 0;
            while (i + a < a+b)
            {
                temp += value[i + a];
                i++;
            }
            return temp;
        }
        public static int IndexOF(this string value, string a)
        {
        for (int i = 0; i<(value.Length - a.Length); i++)
             {
                int j = 0;
                if (value[i] == a[j])
                {
                  while (j<a.Length && i<(value.Length - a.Length) && value[i] == a[j])
                   {
                     i++; j++;
                   }
                }
                if (j == a.Length)
                 {                   
                   return (i - j);
                }
             }
            return -1;
        }


        public static string RepLace(this string value, string a, string b)
        {
            int position = value.IndexOF(a);//10
            return value.SubString(0, position) + b + value.SubString(position + a.Length);
        }


    }
}
