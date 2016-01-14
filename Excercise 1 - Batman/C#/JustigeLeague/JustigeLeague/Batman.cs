using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JustigeLeague
{
    public class Batman
    {
        public static string IAMBATMANize(string str)
        {
            int noOfVowels = 0;
            string batman = "";
            foreach (var chr in str)
            {
                if ("aeiou".Contains(chr))
                {
                    noOfVowels++;
                }
            }
            if ((double)noOfVowels / str.Length > 0.3)
            {
                bool beginOfset = true;
                foreach (var chr in str)
                {
                    if ("aeiou".Contains(char.ToLower(chr)))
                    {
                        if (beginOfset)
                        {
                            batman += "iambatman";
                            beginOfset = false;
                        }
                    }
                    else
                    {
                        batman += chr;
                        beginOfset = true;
                    }
                }
                return batman;
            }
            return str;
        }
    }

}
