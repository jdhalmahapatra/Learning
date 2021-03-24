using System;
using System.Collections.Generic;
using System.Linq;

namespace SimpleArraySum
{
    
    class Program
    {
        static int ArraySum(int[] A)
        {
            int sum = 0;
            for(int i=0; i<A.Length; i++)
            {
                sum = sum + A[i];
            }
            return sum;
        }
        public static void plusMinus()
        {
            int[] arr = { -4, 3, -9, 0, 4, 1 };
            int positiveNumCount = 0, negativeNumCount = 0, zeroNumCount = 0, n = arr.Length;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] > 0)
                    positiveNumCount += 1;
                else if (arr[i] < 0)
                    negativeNumCount += 1;
                else
                    zeroNumCount += 1;
            }
            decimal Pos = (decimal)positiveNumCount / n;
            decimal Neg = (decimal)negativeNumCount / n;
            decimal Zer = (decimal)zeroNumCount / n;

            Console.WriteLine(string.Format("{0:0.000000}", Pos));
            Console.WriteLine(string.Format("{0:0.000000}", Neg));
            Console.WriteLine(string.Format("{0:0.000000}", Zer));
        }

        public static void Staircase(int n)
        {
            Console.WriteLine("The Staircase diagram is below\n");
            for (int i =1; i<=n; i++)
            {
                string printStr = new string(' ', n - i) + new string ('#', i);
                Console.WriteLine("{0}", printStr);
            }
        }
        
        public static int diagonalDifference(List<List<int>> arr, int n)
        {
            int leftDiagonal = 0, rightDiagonal = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {

                    // Condition for Left 
                    // diagonal 
                    if (i == j)
                        leftDiagonal += arr[i][j];

                    // Condition for Right 
                    // diagonal 
                    if ((i + j) == (n - 1))
                        rightDiagonal += arr[i][j];
                }
            }

            Console.WriteLine("Principal Diagonal:"
                                      + leftDiagonal);

            Console.WriteLine("Secondary Diagonal:"
                                      + rightDiagonal);

            return Math.Abs(leftDiagonal - rightDiagonal);

        }

        static void Main(string[] args)
        {
            //Console.WriteLine("Enter the size of an array");
            //int a = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("size of an array is {0}", a.ToString());
            //Console.Write("Input elements of Array :\n");
            //int[] A = new int[1000];
            //for (int i = 0; i < a; i++)
            //{
            //    Console.Write("element - {0} : ", i);
            //    A[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //int sum = ArraySum(A);
            //Console.WriteLine("The sum of Array elements are {0}", sum);
            //Console.ReadKey();

            //Console.WriteLine("Enter the number which will represent the rows and columns of Matrix");
            //int a = Convert.ToInt32(Console.ReadLine());


            //List<List<int>> arr = new List<List<int>> {
            //          new List<int>() { 1, 2, 3, 4 },
            //         new List<int>() { 5, 6, 7, 8 },
            //         new List<int>() { 1, 2, 3, 4 },
            //         new List<int>() { 5, 6, 7, 8 } 


            //    };

            //List<List<int>> arr1 = new List<List<int>> {
            //    new List<int>() { 6, 6, 7, - 10, 9, - 3, 8, 9, - 1 },
            //    new List<int>() { 9, 7, - 10, 6, 4, 1, 6, 1, 1},
            //    new List<int>() { -1, - 2, 4, - 6, 1, - 4, - 6, 3, 9},
            //    new List<int>() { -8, 7, 6, - 1, - 6, - 6, 6, - 7, 2},
            //    new List<int>() { -10, - 4, 9, 1, - 7, 8, - 5, 3, - 5},
            //    new List<int>() { -8, - 3, - 4, 2, - 3, 7, - 5, 1, - 5},
            //    new List<int>() { -2, - 7, - 4, 8, 3, - 1, 8, 2, 3},
            //    new List<int>() { -3, 4, 6, - 7, - 7, - 8, - 3, 9, - 6},
            //    new List<int>() { -2, 0, 5, 4, 4, 4, - 3, 3, 0},
            // };
            //Console.WriteLine("Enter the number which will represent the rows and columns of Matrix using space");
            //for (int i = 0; i < a; i++)
            //{
            //    arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
            //}
            //int result = diagonalDifference(arr1, a);
            //Console.WriteLine("The difference result is {0}", result);
            //plusMinus();
            Staircase(4);
            Console.ReadKey();

        }
    }
}
