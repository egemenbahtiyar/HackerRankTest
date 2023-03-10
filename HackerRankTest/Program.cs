using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRankTest
{
    class Program
    {
        public static int jumpingOnClouds(List<int> c)
        {
            int jumps = 0;


            for (int i = 0; i < c.Count-1; i++)
            {
                if (i == c.Count - 2 && c[i] == 0 && c[i + 1] == 0)
                {
                    jumps++;
                }
                else if (c[i] == 0 && c[i + 1] == 0 && c[i + 2] == 0)
                {
                    jumps++;
                    i+=1;
                }
                else if (c[i] == 0 && c[i + 1] == 0 && c[i + 2] == 1)
                {
                    jumps++;
                }
                else if (c[i] == 0 && c[i + 1] == 1 && c[i + 2] == 0)
                {
                    jumps++;
                    i+=1;
                }
                else if (c[i] == 0 && c[i + 1] == 1 && c[i + 2] == 1)
                {
                    jumps+=2;
                    i += 1;
                }

            }

            return jumps;


        }
        static void Main(string[] args)
        {
            Console.WriteLine(jumpingOnClouds(new List<int> { 0,0,0,1,0,0 }));
        }
    }
}