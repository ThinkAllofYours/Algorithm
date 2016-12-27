using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class Solution
    {
        public int StrStr(string haystack, string needle)
        {
            //A = 65 //Z = 90 //a = 97 //z=122
            //needle은haystack의 일부
            if (needle.Length == 0) return 0;
            else if (needle.Length > haystack.Length) return -1;
            char[] hayArr = haystack.ToCharArray();
            char[] neeArr = needle.ToCharArray();
            //firstStep Find first neeArr[0] in hayArr
            //secondStep Find needle in haystack
            for (int i = 0; i < haystack.Length; i++)
            {
                if ((int)hayArr[i] - (int)neeArr[0] == 0)
                {
                    int remainHaystackLength = (haystack.Length - 1) - i;
                    if (remainHaystackLength < needle.Length - 1)
                        return -1;
                    string hayStr = haystack.Substring(i, needle.Length);
                    if (hayStr.Equals(needle))
                        return i;
                }
            }

            return -1;
        }


        public int ThirdMax(int[] nums)
        {

            IComparer revComparer = new ReverseComparer();
            Array.Sort(nums, revComparer);
            return nums[2];
        }
    }

    public class ReverseComparer : IComparer
    {
        // Call CaseInsensitiveComparer.Compare with the parameters reversed.
        public int Compare(Object x, Object y)
        {
            return (new CaseInsensitiveComparer()).Compare(y, x);
        }
    }
}
