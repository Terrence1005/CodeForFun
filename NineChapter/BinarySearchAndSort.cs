using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NineChapter
{
    public class BinarySearchAndSort
    {

        /*
        For a given sorted array (ascending order) and a target number, find the first index of this number in O(log n) time complexity.
        If the target number does not exist in the array, return -1.
         * 
         */
        public static int BinarySearch(int[] nums, int target)
        {
            //get mid
            // o(logn)
            if (nums.Length == 0)
            {
                return -1;
            }

            int start = 0;
            int end = nums.Length - 1;
            int mid;
            while (start + 1 < end)
            {
                mid = start + (end - start) / 2;// prevent overflow for (start+end)/2
                if (nums[mid] == target)
                {
                    end = mid;
                }

                else if (nums[mid] > target)
                {
                    end = mid;
                }

                else if (nums[mid] < target)
                {
                    start = mid;
                }
            }

            if (nums[start] == target)
            {
                return start;
            }

            if (nums[end] == target)
            {
                return end;
            }

            return -1;
        }

        /*
         *find the last bound
         */

        public static int BinarySearchFindLastIndex(int[] nums, int target)
        {
            if (nums.Length == 0)
            {
                return -1;
            }

            int start = 0;
            int end = nums.Length - 1;
            int mid = 0;

            while (start + 1 < end)
            {
                mid = start + (end - start) / 2;
                if (nums[mid] == target)
                {
                    start = mid;
                }
                else if (nums[mid] > target)
                {
                    end = mid;
                }
                else if (nums[mid] < target)
                {
                    start = mid;
                }
            }

            if (nums[end] == target)
            {
                return end;
            }
            if (nums[start] == target)
            {
                return start;
            }

            return -1;
        }

        /*
         Given a sorted array of n integers, find the starting and ending position of a given target value.
         If the target is not found in the array, return [-1, -1].
         */

        public static int[] BinarySearchForBound(int[] nums, int target)
        {
            var first = BinarySearchAndSort.BinarySearch(nums, target);
            var last = BinarySearchFindLastIndex(nums, target);

            return new int[] { first, last };
        }

        /*Given a sorted array and a target value, return the index if the target is found.If not, return the index where it would be if it were inserted in order.
         * 
         */

        public static int BinarySearchInsertNumPosition(int[] nums, int target)
        {
            // find first num that greater or equal to target
            if (nums.Length == 0)
            {
                return 0;
            }

            int start = 0;
            int end = nums.Length - 1;
            int mid = 0;

            while (start + 1 < end)
            {
                mid = start + (end - start) / 2;
                if (nums[mid] == target)
                {
                    end = mid;
                }
                else if (nums[mid] < target)
                {
                    start = mid;
                }
                else if (nums[mid] > target)
                {
                    end = mid;
                }
            }

            if (nums[start] >= target)
            {
                return start;
            }

            if (nums[end] >= target)
            {
                return end;
            }

            return end + 1;
        }

        /*
         Write an efficient algorithm that searches for a value in an m x n matrix.
         This matrix has the following properties:
         Integers in each row are sorted from left to right.
         The first integer of each row is greater than the last integer of the previous row.
         No duplicate integers in each row or column.
         */

        public static bool BinarySearch2DMatrix(int[][] matrix, int target)
        {
            int row = matrix.Length;
            int column = matrix[0].Length;

            int start = 0;
            int end = row * column - 1;
            int mid = 0;

            while (start + 1 < end)
            {
                mid = start + (end - start) / 2;
                int c = mid % row;
                int r = mid / row;
                if (matrix[r][c] == target)
                {
                    end = mid;
                }

                else if (matrix[r][c] > target)
                {
                    end = mid;
                }

                else if (matrix[r][c] < target)
                {
                    start = mid;
                }


            }
            int rs = start / row;
            int cs = start % row;
            int re = end / row;
            int ce = end % row;
            if (matrix[rs][cs] == target)
            {
                return true;
            }

            if (matrix[re][ce] == target)
            {
                return true;
            }

            return false;
        }

        /*
         Write an efficient algorithm that searches for a value in an m x n matrix, return the occurrence of it.

        This matrix has the following properties:

        Integers in each row are sorted from left to right.
        Integers in each column are sorted from up to bottom.
        No duplicate integers in each row or column.
         */

        public static int BinarySearch2DMatrixWithDup(int[][] matrix, int target)
        {
            int r = matrix.Length - 1;
            int c = 0;
            int ans = 0;

            while (r >= 0 && c < matrix[0].Length)
            {
                if (target == matrix[r][c])
                {
                    ans++;
                    r--;
                    c++;
                    continue;
                }
                if (target < matrix[r][c])
                {
                    r--;
                }
                else
                {
                    c++;
                }
            }

            return ans;

        }

        /*
         First bad version
         You are a product manager and currently leading a team to develop a new product. Unfortunately, the latest version of your product fails the quality check. Since each version is developed based on the previous version, all the versions after a bad version are also bad.

         Suppose you have n versions [1, 2, ..., n] and you want to find out the first bad one, which causes all the following ones to be bad.

         You are given an API bool isBadVersion(version) which will return whether version is bad. Implement a function to find the first bad version. You should minimize the number of calls to the API.
         */

        /*
         There is an integer array which has the following features:

         The numbers in adjacent positions are different.
         A[0] < A[1] && A[A.length - 2] > A[A.length - 1].
        We define a position P is a peak if:

        A[P] > A[P-1] && A[P] > A[P+1]
        Find a peak element in this array. Return the index of the peak.

        It's guaranteed the array has at least one peak.
        The array may contain multiple peeks, find any of them.
        The array has at least 3 numbers in it.
         */

        public static int FindPeekElement(int[] nums)
        {
            int start = 1;
            int end = nums.Length - 2;
            int mid = 0;

            while (start + 1 < end)
            {
                mid = start + (end - start) / 2;
                if (nums[mid] < nums[mid - 1])
                {
                    end = mid;
                }
                else if (nums[mid] < nums[mid + 1])
                {
                    start = mid;
                }
                else
                {
                    end = mid;
                }
            }

            if (nums[start] < nums[end])
            {
                return end;
            }
            else
            {
                return start;
            }
        }

        /*
         Suppose a sorted array is rotated at some pivot unknown to you beforehand.
         if duplicate in array can only be o(n);
        (i.e., 0 1 2 4 5 6 7 might become 4 5 6 7 0 1 2).

        Find the minimum element.
         
         */

        public static int FindMinInRotateArray(int[] nums)
        {
            int start = 0;
            int end = nums.Length - 1;

            while (start + 1 < end)
            {
                int mid = start + (end - start) / 2;
                if (nums[mid] >= end)
                {
                    start = mid;
                }
                else
                {
                    end = mid;
                }
            }

            if (nums[start] < nums[end])
            {
                return nums[start];
            }
            else
            {
                return nums[end];
            }
        }

        /*
         * Description
        English
        if dup then only can be o(n); use for loop;
        Suppose a sorted array is rotated at some pivot unknown to you beforehand.

        (i.e., 0 1 2 4 5 6 7 might become 4 5 6 7 0 1 2).

        You are given a target value to search. If found in the array return its index, otherwise return -1.

        You may assume no duplicate exists in the array.
         */

        public static int FindTargetInRotateArray(int[] nums, int target)
        {
            int start = 0;
            int end = nums.Length - 1;
            while (start + 1 < end)
            {
                int mid = start + (end - start) / 2;
                if (nums[mid] == target)
                {
                    return mid;
                }

                if (nums[start] < nums[mid])
                {
                    if (nums[start] <= target && target <= nums[mid])
                    {
                        end = mid;
                    }
                    else
                    {
                        start = mid;
                    }
                }
                else
                {
                    if (nums[end] >= target && target >= nums[mid])
                    {
                        start = mid;
                    }
                    else
                    {
                        end = mid;
                    }
                }
            }

            if (nums[start] == target)
            {
                return start;
            }

            if (nums[end] == target)
            {
                return end;
            }

            return -1;
        }

        /*
         
        Merge two given sorted ascending integer array A and B into a new sorted integer array.
        */

        public static int[] MergeTwoSortedArray(int[] A, int[] B)
        {
            int aLen = A.Length;
            int bLen = B.Length;


            int[] c = new int[aLen + bLen];
            int i = 0;
            int ai = 0;
            int bi = 0;


            while (i < aLen + bLen)
            {
                if (ai > aLen - 1 || bi > bLen - 1)
                {
                    break;
                }
                else
                {
                    if (A[ai] > B[bi])
                    {
                        c[i] = B[bi];
                        bi++;
                    }
                    else
                    {
                        c[i] = A[ai];
                        ai++;
                    }
                }

                i++;
            }

            while (ai < aLen)
            {
                c[i] = A[ai];
                i++;
                ai++;
            }

            while (bi < bLen)
            {
                c[i] = B[bi];
                i++;
                bi++;
            }





            return c;
        }

        /*
         Given two sorted integer arrays A and B, merge B into A as one sorted array.
         */

        public static int[] MergeSortedArrayIntoA(int[] A, int m, int[] B, int n)
        {
            int ai = m - 1;
            int bi = n - 1;

            int i = m + n - 1;
            while (i >= 0)
            {
                if (ai < 0 || bi < 0)
                {
                    break;
                }
                if (A[ai] >= B[bi])
                {
                    A[i] = A[ai];
                    ai--;
                }
                else
                {
                    A[i] = B[bi];
                    bi--;
                }
                i--;
            }

            while (ai >= 0)
            {
                A[i] = A[ai];
                ai--;
                i--;
            }

            while (bi >= 0)
            {
                A[i] = B[bi];
                bi--;
                i--;
            }

            return A;
        }


        /*
         There are two sorted arrays A and B of size m and n respectively. Find the median of the two sorted arrays.
         The definition of the median:

         The median here is equivalent to the median in the mathematical definition.

         The median is the middle of the sorted array.

         If there are n numbers in the array and n is an odd number, the median is A[(n-1)/2]A[(n−1)/2].

         If there are n numbers in the array and n is even, the median is (A[n / 2] + A[n / 2 + 1]) / 2.

         For example, the median of the array A=[1,2,3] is 2, and the median of the array A=[1,19] is 10.
         */



        /*
         * Fang fang de cheng fa kou jue biao
         * 
       */

        public static void MultiplyForm(int j, int len)
        {

            for (int i = 1; i <= len; i++)
            {
                Console.Write(i);
                Console.Write('*');
                Console.Write(j);

                Console.Write('=');
                Console.Write(i * j);
                Console.Write(';');
            }

        }

        /*
         median of two sorted array, hard do more review.
         */

        public static double FindMedianSortedArray(int[] A, int[] B)
        {
            if ((A.Length + B.Length) % 2 != 0)
            {
                return FindKth(A, 0, B, 0, (A.Length + B.Length) / 2);
            }
            else
            {
                return (FindKth(A, 0, B, 0, (A.Length + B.Length) / 2) + FindKth(A, 0, B, 0, (A.Length + B.Length) / 2 + 1)) / 2.0;
            }
        }

        public static int FindKth(int[] A, int A_start, int[] B, int B_start, int k)
        {
            if (A_start >= A.Length)
            {
                return B[B_start + k - 1];
            }
            if (B_start >= B.Length)
            {
                return A[A_start + k - 1];
            }

            if (k == 1)
            {
                return Math.Min(A[A_start], B[B_start]);
            }

            int A_key = A_start + k / 2 - 1 < A.Length ? A[A_start + k / 2 - 1] : int.MaxValue;
            int B_key = B_start + k / 2 - 1 < B.Length ? B[B_start + k / 2 - 1] : int.MaxValue;

            if (A_key < B_key)
            {
                return FindKth(A, A_start + k / 2, B, B_start, k - k / 2);
            }
            else
            {
                return FindKth(A, A_start, B, B_start + k / 2, k - k / 2);
            }
        }

        /*
        Given a rotated sorted array, recover it to sorted array in-place.
        [4, 5, 1, 2, 3] -> [1, 2, 3, 4, 5]

         */

        public static int[] RecoverSortedArray(int[] A)
        {
            int maxIndex = 0;
            int minIndex = 1;

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] - A[i + 1] > 0)
                {
                    maxIndex = i;
                    minIndex = i + 1;
                    break;
                }
            }

            A = Reverse(A, 0, maxIndex);
            A = Reverse(A, minIndex, A.Length - 1);
            A = Reverse(A, 0, A.Length - 1);

            return A;

        }

        public static int[] Reverse(int[] A, int start, int end)
        {
            for (int i = start, j = end; i < j; i++, j--)
            {
                int temp = A[i];
                A[i] = A[j];
                A[j] = temp;

            }

            return A;
        } 



        /*
         Given a string(Given in the way of char array) and an offset, rotate the string by offset in place. (rotate from left to right)
         Input: str="abcdefg", offset = 3
         Output: str = "efgabcd"	
         Explanation: Note that it is rotated in place, that is, after str is rotated, it becomes "efgabcd".
         */

        public static string RotateStringByOffset(string input, int offset)
        {
            if (offset >= input.Length)
            {
                offset = offset % input.Length;
            }
            if (offset == 0) return input;

            input = Reverse(input, 0, input.Length - offset - 1);
            input = Reverse(input, input.Length - offset, input.Length - 1);
            input = Reverse(input, 0, input.Length - 1);

            return input;

        }

        public static string Reverse(string A, int startIndex, int endIndex)
        {
            var array = A.ToCharArray();
            for (int i = startIndex, j = endIndex; i < j; i++, j--)
            {
                var temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }

            return new string(array);
        }

        /*
         Given an input string, reverse the string word by word.
         */

        public static string ReverseStringByWord(string input)
        {
            var splitedArray = input.Split(' ');
            for (int i = 0; i < splitedArray.Length; i++)
            {
                splitedArray[i] = Reverse(splitedArray[i], 0, splitedArray[i].Length - 1);
            }

            string output = "";

            for (int i = 0; i < splitedArray.Length; i++)
            {
                if (i == splitedArray.Length - 1)
                {
                    output += splitedArray[i];
                }
                else
                {
                    output += splitedArray[i] + ' ';
                }

            }

            output = Reverse(output, 0, output.Length - 1);

            return output;
        }

        /*
         1.Binary Search Template (4 key points)
         2.Rotated Sorted Array
            a. Find Minimum
            b. Find Target
            c. why o(n) with duplicates? 

         3.Find Median in Two Sorted Array
         4. Reverse in 3 steps.
         
         */



    }
}
