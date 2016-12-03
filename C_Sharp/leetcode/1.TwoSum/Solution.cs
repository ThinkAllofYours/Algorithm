using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();
            int[] giveNums = { 230, 863, 916, 585, 981, 404, 316, 785, 88, 12, 70, 435, 384, 778, 887, 755, 740, 337, 86, 92, 325, 422, 815, 650, 920, 125, 277, 336, 221, 847, 168, 23, 677, 61, 400, 136, 874, 363, 394, 199, 863, 997, 794, 587, 124, 321, 212, 957, 764, 173, 314, 422, 927, 783, 930, 282, 306, 506, 44, 926, 691, 568, 68, 730, 933, 737, 531, 180, 414, 751, 28, 546, 60, 371, 493, 370, 527, 387, 43, 541, 13, 457, 328, 227, 652, 365, 430, 803, 59, 858, 538, 427, 583, 368, 375, 173, 809, 896, 370, 789 };

            int[] intArr = _solution.TwoSum(giveNums, 542);
            foreach(int num in intArr)
            {
                Console.WriteLine(num);
            }
            Console.ReadLine();
        }
    }

    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> _dic = new Dictionary<int, int>();
            int idxFindNum = 0;
            for(int i = 0; i<nums.Length; i++)
            {
                int intFindNum = target - nums[i];
                if (_dic.ContainsKey(intFindNum))
                    if(_dic.TryGetValue(intFindNum, out idxFindNum))
                        return new int[] { idxFindNum, i };
                
                if(!_dic.ContainsKey(nums[i]))
                    _dic.Add(nums[i], i);  
            }
            throw new System.ArgumentException("cannot resolve the solution", "original");
        }
    }

}
