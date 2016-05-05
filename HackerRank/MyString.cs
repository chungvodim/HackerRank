using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    public static class MyString
    {
        public static int Anagram(string str)
        {
            if (string.IsNullOrEmpty(str)) return -1;
            int anagram = 0;
            int length = str.Length;
            if (length > 10000) return -1;
            if (length % 2 == 1) return -1;
            int[] arr = new int[256];
            for (int i = 0; i < length/2; i++)
            {
                arr[(int)str[i]]++;
            }
            for (int i = length / 2; i < length; i++)
            {
                arr[(int)str[i]]--;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                anagram += Math.Abs(arr[i]);
            }
            return anagram/2;
        }

        public static bool IsUniqueCharacters(string str)
        {
            bool[] array = new bool[256]; // or larger for Unicode

            foreach (char value in str)
                if (array[(int)value])
                    return false;
                else
                    array[(int)value] = true;

            return true;
        }

        public static bool IsPermutation(string str, string str1)
        {
            if (str.Length != str1.Length)
            {
                return false;
            }
            int[] array = new int[256]; // or larger for Unicode

            foreach (char c in str)
            {
                array[(int)c]++;
            }

            foreach (var c in str1)
            {
                if (array[(int)c]-- < 0)
                    return false;
            }

            return true;
        }

        public static bool IsPangram(string sentence)
        {
            sentence = sentence.ToLower();
            char[] array = new char[26];
            List<char> charList = new List<char>();
            bool isPangram = false;
            charList.Add('a');
            charList.Add('b');
            charList.Add('c');
            charList.Add('d');
            charList.Add('e');
            charList.Add('f');
            charList.Add('g');
            charList.Add('h');
            charList.Add('i');
            charList.Add('j');
            charList.Add('k');
            charList.Add('l');
            charList.Add('m');
            charList.Add('n');
            charList.Add('o');
            charList.Add('p');
            charList.Add('q');
            charList.Add('u');
            charList.Add('s');
            charList.Add('r');
            charList.Add('t');
            charList.Add('v');
            charList.Add('w');
            charList.Add('x');
            charList.Add('y');
            charList.Add('z');

            for (int i = 0; i < sentence.Length; i++)
            {
                charList.Remove(sentence[i]);
                if (charList.Count == 0)
                {
                    isPangram = true;
                    break;
                }
            }
            return isPangram;
        }

        public static int RequiredDeletion(string str)
        {
            int result = -1;
            char c = str[0];
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == c)
                {
                    result++;
                }
                else
                {
                    c = str[i];
                }
            }
            return result;
        }

        public static int MinimumPalindrome(string str)
        {
            int numberOfDeduction = 0;
            int length = str.Length;
            int halfLength = length / 2;
            char c = str[0];
            for (int i = 0; i < halfLength; i++)
            {
                numberOfDeduction += Math.Abs((int)str[i] - (int)str[length - 1 - i]);
            }
            return numberOfDeduction;
        }

        public static bool FunnyString(string str)
        {
            bool isFunny = true;
            int length = str.Length;
            int halfLength = length / 2;
            for (int i = 1; i < length; i++)
            {
                if (Math.Abs((int)str[i] - (int)str[i - 1]) != Math.Abs((int)str[length - i - 1] - (int)str[length - i]))
                {
                    isFunny = false;
                    break;
                }
            }
            return isFunny;
        }

        public static int Gemstones(string[] strArray)
        {
            int numberOfRocks = strArray.Length;
            int[] iArr = new int[256];
            bool[] bArr = new bool[256];
            for (int i = 0; i < strArray.Length; i++)
            {
                bArr = new bool[256];
                for (int j = 0; j < strArray[i].Length; j++)
                {
                    if (!bArr[(int)strArray[i][j]])
                    {
                        iArr[(int)strArray[i][j]]++;
                        bArr[(int)strArray[i][j]] = true;
                    }
                }
            }
            return iArr.Where(x => x == numberOfRocks).Count();
        }

        public static int PalindromeIndex(string str)
        {
            int index = -1;
            int l = str.Length;
            int hl = (int)Math.Ceiling((double)l / 2);

            for (int i = 0; i < hl; i++)
            {
                if (str[i] != str[l - i - 1])
                {
                    var temp = str.Remove(i, 1);
                    if (IsPalindrome(temp,i))
                    {
                        return i;
                    }
                    else
                    {
                        return l - i - 1;
                    }
                }
            }

            return index;
        }

        private static bool IsPalindrome(string str, int i)
        {
            int l = str.Length;
            int hl = (int)Math.Ceiling((double)l / 2);
            for (int j = 0; j < hl; j++)
            {
                if (str[j] != str[l - j - 1])
                {
                    return false;
                }
            }
            return true;
        }

        public static void TwoStrings(string str1, string str2)
        {
            string result = "NO";
            bool[] arr = new bool[256];
            for (int i = 0; i < str1.Length; i++)
            {
                arr[(int)str1[i]] = true;
            }
            for (int i = 0; i < str2.Length; i++)
            {
                if (arr[(int)str2[i]] == true)
                {
                    result = "YES";
                    break;
                }
            }
            Console.WriteLine(result);
        }

        public static bool IsSubLetter(char c, string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (c == str[i]) return true;
            }
            return false;
        }

        public static void GameOfThrone(string str)
        {
            string result = "YES";
            int[] arr = new int[256];
            int numberOfOdds = 0;
            for (int i = 0; i < str.Length; i++)
            {
                arr[(int)str[i]] ++;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 1)
                {
                    numberOfOdds++;
                    if (numberOfOdds > 1)
                    {
                        result = "NO";
                        break;
                    }
                }
            }
            Console.WriteLine(result);
        }

        public static void MakeItAnagram(string str1, string str2)
        {
            int anagram = 0;
            int l1 = str1.Length;
            int l2 = str2.Length;
            int[] arr = new int[256];
            for (int i = 0; i < l1; i++)
            {
                arr[(int)str1[i]]++;
            }
            for (int i = 0; i < l2; i++)
            {
                arr[(int)str2[i]]--;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                anagram += Math.Abs(arr[i]);
            }
            Console.WriteLine(anagram);
        }

        public static void SteadyGene(string str, int m)
        {
            int n = str.Length;
            int[] arr = new int[256];
            bool isSteady = true;

            for (int i = 0; i < n; i++)
            {
                arr[(int)str[i]]++;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = arr[i] - m > 0 ? arr[i] - m : 0;
                if (arr[i] > 0) isSteady = false;
            }

            if (isSteady) 
            { 
                Console.WriteLine("0"); 
            }
            else
            {
                int a = GetMinLength(arr, n, m, str);
                Console.WriteLine(a);
            }

        }

        private static bool IsFound(int[] arr, int m)
        {
            foreach (var item in arr)
            {
                if (item > 0)
                {
                    return false;
                }
            }
            return true;
        }

        private static int GetMinLength(int[] arr, int n, int m, string str)
        {
            int e = 0;
            int ans = n;
            for (int i = 0; i < n; i++)
            {
                while (!IsFound(arr,m))
                {
                    if (e == n)
                    {
                        return ans;
                    }
                    arr[str[e]]--;
                    e++;
                }
                ans = Math.Min(ans, e - i);
                arr[str[i]]++;
            }
            return ans;
        }

        public static void SherlockAndAnagrams(string str)
        {
            int r = 0;
            int n = str.Length;
            for (int i = 0; i < n; i++)
            {
                for (int j = i; j < n; j++)
                {
                    string ss = str.Substring(i, j - i + 1);
                    if (HasAnagramPair(str, ss, i, j))
                    {
                        r++;
                    }
                }
            }
            Console.WriteLine(r);
        }

        private static bool HasAnagramPair(string str, string ss, int s, int e)
        {
            int n = str.Length;
            int l = e - s + 1;

            for (int i = s + 1; i <= n - l; i++)
            {
                if(IsAnagramPair(ss, str.Substring(i, l)))
                {
                    Console.WriteLine(String.Format("{0}/{1}", ss, str.Substring(i, l)));
                    return true;
                }
            }
            return false;
        }

        private static bool IsAnagramPair(string ss, string v)
        {
            int[] arr = new int[256];
            foreach (var c in ss)
            {
                arr[c]++;
            }
            for (int i = 0; i < v.Length; i++)
            {
                arr[v[i]]--;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
