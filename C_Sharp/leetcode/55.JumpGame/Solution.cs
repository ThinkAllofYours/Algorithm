using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jumpNum
{
    public class Solution
    {
        public bool CanJump(int[] nums)
        {
            bool isCanJump = false;
            int maximum = 0;
            for (int i = 0; i <= nums.Length - 1; i++)
            {
                int farthest = i + nums[i];

                if (farthest > maximum)
                    maximum = farthest;

                if (maximum >= nums.Length - 1)
                    return isCanJump = true;

                if (maximum <= i)
                    return isCanJump;
            }
            return isCanJump;
        }
    }
}
