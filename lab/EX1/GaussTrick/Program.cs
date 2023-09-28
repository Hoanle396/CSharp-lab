using System;
using System.Collections.Generic;
using System.Numerics;

class Program
{
    static List<string> F(string s)
    {
        List<string> r = new List<string>();
        int m = 0;
        List<string> c = new List<string>();

        // Tạo danh sách tất cả các chuỗi con
        for (int i = 0; i < s.Length; i++)
        {
            for (int j = i + 1; j <= s.Length; j++)
            {
                string t = s.Substring(i, j - i);
                r.Add(t);
            }
        }

        // Duyệt qua danh sách các chuỗi con và kiểm tra điều kiện
        foreach (string d in r)
        {
            string a = R(d);
            if (r.Contains(a))
            {
                int l = d.Length;
                if (l > m)
                {
                    m = l;
                    c = new List<string> { d, a };
                }
            }
        }

        return c;
    }

    static string R(string s)
    {
        char[] a = s.ToCharArray();
        Array.Reverse(a);
        return new string(a);
    }

    static BigInteger C(string a, string b)
    {
        return BigInteger.Parse(a) * BigInteger.Parse(b) + BigInteger.Parse(b) - BigInteger.Parse(a);
    }

    static void Main(string[] args)
    {
        string s = "657327332966921663763508656967373613019713315988026211439100229700959506001934112620889513317910316373769656805367366129661842496741252";
        List<string> substrings = F(s);

        if (substrings.Count == 2)
        {
            string a = substrings[0];
            string b = substrings[1];
            BigInteger result = C(a, b);
            Console.WriteLine("Result = " + result);
        }
        else
        {
            Console.WriteLine("Không tìm thấy chuỗi con thỏa mãn yêu cầu.");
        }
    }
}