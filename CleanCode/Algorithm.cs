using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode
{
    public static class Algorithm
    {
        public static int SequentialSearch(int[] list, int target, int N)
        {
            for (int i = 0; i < N; i++)
            {
                if (list[i] == target)
                {
                    return i + 1;
                }
            }

            return 0;
        }

        public static int BinarySearch(int[] list, int target, int N)
        {
            int start = 0;
            int end = N - 1;

            while (start <= end)
            {
                int middle = (start + end) / 2;

                switch (Comparer<int>.Default.Compare(list[middle], target))
                {
                    case -1:
                        start = middle + 1;
                        break;
                    case 0:
                        return middle;
                    case 1:
                        end = middle - 1;
                        break;
                }
            }

            return -1;
        }

        public static bool IsUnique(string array)
        {
            if (array.Length == 1)
            {
                return true;
            }

            for (int j = 1; j < array.Length; j++)
            {
                for (int i = j; i < array.Length; i++)
                {
                    if (array[j - 1] == array[i])
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public static bool CheckPermutation(string text1, string text2)
        {
            if (text1.Length != text2.Length)
            {
                return false;
            }

            for (int i = 1; i < text2.Length + 1; i++)
            {
                if (text1[i - 1] == text2[text2.Length - i])
                {
                    return true;
                }
            }

            return false;
        }

        public static string URLify(string text)
        {
            char[] array = text.ToCharArray();



            //for (int i = 0; i < text.Length; i++)
            //{
            //    if (text[i].ToString() == " ")
            //    {
            //        text = text.Replace(text[i].ToString(), "%20");
            //    }
            //}

            return text;
        }
    }
}
