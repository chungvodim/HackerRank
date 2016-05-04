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
            int length = str.Length;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != str[length - i - 1])
                {
                    var temp = str.Remove(i, 1);
                    if (IsPalindrome(temp))
                    {
                        return i;
                    }
                }
            }

            return index;
        }

        private static bool IsPalindrome(string str)
        {
            int length = str.Length;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != str[length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }

        //public static int PalindromeIndex(string str)
        //{
        //    if (string.IsNullOrEmpty(str)) return -1;
        //    int index = 0;
        //    int length = str.Length;
        //    if (length > 100005) return -1;
        //    int halfLenth = length / 2;
        //    int[] arr = new int[256];
        //    for (int i = 0; i < length / 2; i++)
        //    {
        //        arr[(int)str[i]]++;
        //    }
        //    for (int i = length / 2; i < length; i++)
        //    {
        //        arr[(int)str[i]]--;
        //    }
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        index += Math.Abs(arr[i]);
        //    }
        //    return index / 2;
        //}
    }
}
