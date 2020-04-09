using System;

namespace KMP
{
    class Program
    {
        static void Main(string[] args)
        {
            string txt = "abcdefabcabcdeabc";
            string pat = "bcde";
            KMPSearch(pat, txt);
            Console.ReadLine();
        }

        static void KMPSearch(string pat, string txt)
        {
            int M = pat.Length;
            int N = txt.Length;
            int[] map = new int[M];

            CreateMap(pat, M, map);
            int i = 0;
            int j = 0;
            while (i < N)
            {
                if (pat[j] == txt[i])
                {
                    i++;
                    j++;
                }
                if (j == M)
                {
                    Console.WriteLine("Key at " + (i - j));
                    j = map[j - 1];
                }
                else if (i < N && pat[j] != txt[i])
                {
                    if (j != 0)
                    {
                        j = map[j - 1];
                    }
                    else
                    {
                        i++;
                    }
                }
            }
        }

        static void CreateMap(string pat, int M, int[] map)
        {
            int len = 0;
            map[0] = 0;

            int i = 1;
            while (i < M)
            {
                if (pat[i] == pat[len])
                {
                    len++;
                    map[i] = len;
                    i++;
                }
                else
                {
                    if (len != 0)
                    {
                        len = map[len - 1];
                    }
                    else
                    {
                        map[i] = 0;
                        i++;
                    }
                }
            }
        }
    }
}
