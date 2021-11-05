using System;
using System.Text;

namespace Open_Lab_04._05
{
    public class StringTools
    {
        public string Repeat(string orig, int n)
        {
            string s = "";
            for (int i = 0; i < orig.Length; i++)
            {
                var c = orig[i];
                for (int j = 0; j < n; j++) 
                {
                    s += c;
                    
                }
            }
            return s;
        }
    }
}
