using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] A = new int[] { 1, 3, 6, 4, 1, 2 };

            //Console.Write(solution(A));
            BinaryGap(100);
        }

        public static int solution(int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)

            //remove nigative values

            A = A.Where(x => x > 0).ToArray();
            int min = A.Min();
            if (min > 1)
                return 1;

            A = A.OrderBy(x => x).ToArray();
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] + 1 != A[i + 1])
                    return A[i] + 1;
            }
            return 0;
        }

        public static int BinaryGap(int input)
        {
            string binaryNumberString = Convert.ToString(input,2);
            Console.WriteLine("binary value "+binaryNumberString);
            string[] strArray = binaryNumberString.Split('1');
            int gapLength = 0;
            for (int i = 0; i < strArray.Length; i++)
            {
                Console.WriteLine(strArray[i]);
                if (strArray[i].Length == 0)
                    continue;
                if (i == (strArray.Length - 1))
                    continue;

                if (strArray[i].Length > gapLength)
                    gapLength = strArray[i].Length;

                Console.WriteLine("gap length " + gapLength.ToString());

            }
            Console.ReadKey();
            return gapLength;

        }
    }
}
