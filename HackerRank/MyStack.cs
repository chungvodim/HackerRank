using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    public static class MyStack
    {
        public static void BalancedParentheses(string str)
        {
            // đầu tiên cần kiểm tra độ dài của chuỗi phải là số chắn
            int n = str.Length;
            if (n % 2 != 0)
            {
                Console.WriteLine("NO");
            }
            else
            {
                //Nạp chuỗi cần kiểm tra vào ngăn xếp và loại đi những cặp đã cân bằng
                Stack<char> st = new Stack<char>();
                for (int i = 0; i < n ; i++)
                {
                    if(st.Count > 0)
                    {
                        char c = st.Pop();
                        if(!IsBalancedPair(c, str[i]))
                        {
                            st.Push(c);
                            st.Push(str[i]);
                        }
                    }
                    else
                    {
                        st.Push(str[i]);
                    }
                }
                // Kiểm tra phần còn lại của chuỗi có đối xứng hay không
                n = st.Count;
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < n; i++)
                {
                    sb.Append(st.Pop());
                }
                string s = sb.ToString();
                for (int i = 0; i < n; i++)
                {
                    if (!IsBalancedPair( s[n - i - 1], s[i]))
                    {
                        Console.WriteLine("NO");
                        return;
                    }
                }
                Console.WriteLine("YES");
            }
        }

        private static bool IsBalancedPair(char c1, char c2)
        {
            bool r = false;
            switch (c1)
            {
                case '{':
                    r = c2 == '}';
                    break;
                case '[':
                    r = c2 == ']';
                    break;
                case '(':
                    r = c2 == ')';
                    break;
            }
            return r;
        }

        private static Stack<string> st = new Stack<string>();
        public static void TextEditor(string str)
        {
            if(str == "4")
            {
                st.Pop();
            }
            else
            {
                string[] ar = str.Split(' ');
                var op = ar[0];
                var arg = ar[1];
                int n = 0;
                switch (op)
                {
                    case "1":
                        if(st.Count > 0)
                        {
                            st.Push(st.Peek() + arg);
                        }
                        else
                        {
                            st.Push(arg);
                        }
                        break;
                    case "2":
                        n = Convert.ToInt32(arg);
                        st.Push(st.Peek().Remove(st.Peek().Length - n, n));
                        break;
                    case "3":
                        n = Convert.ToInt32(arg);
                        Console.WriteLine(st.Peek()[n - 1]);
                        break;
                }
            }
        }
    }
}
