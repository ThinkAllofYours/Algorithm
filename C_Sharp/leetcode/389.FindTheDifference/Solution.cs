using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindTheDifference
{
    public class Solution
    {
        public char FindTheDifference(string s, string t)
        {
            char answer = '0';
            Dictionary<char, int> _dic = new Dictionary<char, int>();
            foreach (char c in t.ToCharArray())
            {
                if (_dic.ContainsKey(c))
                {
                    int value = 0;
                    _dic.TryGetValue(c, out value);
                    //_dic.Add(c, value++); 키가 있으면 키를 더하는게 아니라 값을 증가시킨다.
                    _dic[c] = ++value; // 증가한 값을 더하기 위해서 value++ 아니라 ++value를 시킨다.
                }
                else
                {
                    _dic.Add(c, 1);
                }
            }

            foreach (char c in s.ToCharArray())
            {
                if (_dic.ContainsKey(c))
                {
                    int value = 0;
                    _dic.TryGetValue(c, out value);
                    _dic[c] = --value;
                    if (value == 0)
                    {
                        _dic.Remove(c);
                    }
                }
            }

            foreach (char c in _dic.Keys)
            {
                answer = c;
            }

            return answer;
        }
    }
}
