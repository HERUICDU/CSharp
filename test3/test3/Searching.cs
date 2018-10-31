using System;

namespace test3
{
    class Searching
    {
        public int Getnum(int idx, char[] str, char[] subStr, ref bool found)
        {
            int idx_org = idx;
            int i;
            while (idx < str.Length)
            {
                //找到第一个字符的位置
                while (idx < str.Length)
                {
                    if (str[idx++] == subStr[0])
                        break;
                }
                //如果第一个字符都不匹配，或者如果strAll中剩余的字符不足，返回false
                if (idx == str.Length || subStr.Length - 1 > str.Length - idx)
                    break;

                //找到第一个字符之后，以后的每个字符都必须相同，才是完全匹配
                for (i = 1; i < subStr.Length; i++, idx++)
                {
                    if (subStr[i] != str[idx])
                    {//如果不匹配
                        idx_org++;
                        idx = idx_org;
                        break;
                    }
                }
                //如果找到了整个匹配
                if (i == subStr.Length)
                {
                    found = true;
                    return idx;
                }
            }
            found = false;
            return str.Length;
        }
    }
}
