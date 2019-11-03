using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NineChapter
{
    public class Program
    {
        static void Main(string[] args)
        {

            //StrStr test
            var src = "Hello";
            var trgt = "ll";
            var strIndex = Strstr.StrStrIndex(src, trgt);

            //Console.WriteLine(strIndex);

            //Subsets
            var myIntegers = new int[] { 1, 2, 3 };
            var myMatrix = Strstr.Subsets(myIntegers);

            for (int i = 0; i < myMatrix.Count; i++)
            {
                for (int j = 0; j < myMatrix[i].Count; j++)
                {
                    Console.Write(myMatrix[i][j]);
                    Console.Write(',');
                }
                Console.WriteLine();
            }


            //Binary Search Test
            var nums = new int[] { 1, 4, 4, 5, 7, 7, 8, 9, 9, 10 };
            var target = 9;

            var result = BinarySearchAndSort.BinarySearch(nums, target);
            //Console.WriteLine(result);

            var another = BinarySearchAndSort.BinarySearchFindLastIndex(nums, target);
            //Console.WriteLine(another);

            var firstAndLast = BinarySearchAndSort.BinarySearchForBound(nums, target);
            var output = firstAndLast[0].ToString() + "," + firstAndLast[1].ToString();

            //Console.WriteLine(output);

            var nums2 = new int[] { 1, 2, 3, 5, 7, 9, 11, 13, 18, 20 };

            var num1 = 8;
            var ip1 = BinarySearchAndSort.BinarySearchInsertNumPosition(nums2, num1);
            //Console.WriteLine(ip1);

            var num2 = 19;
            var ip2 = BinarySearchAndSort.BinarySearchInsertNumPosition(nums2, num2);
            //Console.WriteLine(ip2);

            //var matrix = new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };
            var matrix = new int[][] { new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 }, new int[] { 7, 8, 9 } };

            var isExist1 = BinarySearchAndSort.BinarySearch2DMatrix(matrix, 4);
            //Console.WriteLine(isExist1);

            var nums3 = new int[] { 1, 2, 3, 5, 7, 9, 8, 6, 7, 9, 4, 10 };

            var peakIndex = BinarySearchAndSort.FindPeekElement(nums3);

            //Console.WriteLine(peakIndex);

            var num4 = new int[] { 4, 5, 6, 7, 0, 1, 2, 3 };
            var least = BinarySearchAndSort.FindMinInRotateArray(num4);

            //Console.WriteLine(least);

            var index = BinarySearchAndSort.FindTargetInRotateArray(num4, 2);
            //Console.WriteLine(index);

            var A = new int[] { 1, 2, 6, 7 };
            var B = new int[] { 3, 4, 5, };

            var c = BinarySearchAndSort.MergeTwoSortedArray(A, B);

            //for (int i = 0; i < c.Length; i++)
            //{
            //    Console.Write(c[i]);
            //    Console.Write(',');
            //}
            //Console.WriteLine();

            var A1 = new int[] { 1, 2, 6, 7, 9 };
            var B1 = new int[] { 3, 4, 5, 6, 8, 10, 12 };

            var c1 = BinarySearchAndSort.MergeTwoSortedArray(A1, B1);

            //for (int j = 0; j < c1.Length; j++)
            //{
            //    Console.Write(c1[j]);
            //    Console.Write(',');
            //}
            //Console.WriteLine();

            var A2 = new int[] { 1, 2, 6, 7, 9, 0, 0, 0, 0, 0, 0, 0 };
            var B2 = new int[] { 3, 4, 5, 6, 8, 10, 12 };

            var c2 = BinarySearchAndSort.MergeSortedArrayIntoA(A2, 5, B2, 7);

            //for (int k = 0; k < c2.Length; k++)
            //{
            //    Console.Write(c2[k]);
            //    Console.Write(',');
            //}
            //Console.WriteLine();

            BinarySearchAndSort.MultiplyForm(1, 1);
            Console.WriteLine();
            BinarySearchAndSort.MultiplyForm(2, 2);
            Console.WriteLine();
            BinarySearchAndSort.MultiplyForm(3, 3);
            Console.WriteLine();
            BinarySearchAndSort.MultiplyForm(4, 4);
            Console.WriteLine();
            BinarySearchAndSort.MultiplyForm(5, 5);
            Console.WriteLine();
            BinarySearchAndSort.MultiplyForm(6, 6);
            Console.WriteLine();
            BinarySearchAndSort.MultiplyForm(7, 7);
            Console.WriteLine();
            BinarySearchAndSort.MultiplyForm(8, 8);
            Console.WriteLine();
            BinarySearchAndSort.MultiplyForm(9, 9);
            Console.WriteLine();

            int[] Am = { 1, 2, 3, 4, 5, 6, 7, 7, 8, 8, 10, 98 };
            int[] Bm = { 3, 5, 6, 11, 23, 45 };

            //Console.WriteLine(BinarySearchAndSort.FindMedianSortedArray(Am, Bm));

            //Console.WriteLine();
            int[] Ar = { 3, 4, 5, 6, 7, 1, 2 };

            Ar = BinarySearchAndSort.RecoverSortedArray(Ar);

            //for (int i = 0; i < Ar.Length; i++)
            //{
            //    Console.Write(Ar[i]);
            //    Console.Write(',');
            //}

            //Console.WriteLine();

            var origin = "abcdefg";
            //Console.WriteLine(BinarySearchAndSort.RotateStringByOffset(origin, 3));

            var originSentence = "You should do something better";
            //Console.WriteLine(BinarySearchAndSort.ReverseStringByWord(originSentence));
        }
    }
}
