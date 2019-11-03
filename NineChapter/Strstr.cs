using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NineChapter
{
    public class Strstr
    {
        /*
         For a given source string and a target string, you should output the first index(from 0) of target string in source string.

        If target does not exist in source, just return -1.
         */

        public static int StrStrIndex(string source, string target)
        {
            if ((source == null && target == null) || source.Length < target.Length)
            {
                return -1;
            };

            if (source.Equals(target))
            {
                return 0;
            }

            var sourceArr = source.ToCharArray();
            var targetArr = target.ToCharArray();
            var j = 0;

            for (int i = 0; i < source.Length - target.Length + 1; i++)
            {
                for(j = 0; j <target.Length; j++)
                {
                    if (!sourceArr[i + j].Equals(targetArr[j]))
                    {
                        break;
                    }
                }

                if (j == target.Length)
                {
                    return i;
                }
            }

            return -1;

        }

        /*
         Subset Given a set of distinct integers, return all possible subsets.

            Elements in a subset must be in non-descending order.
            The solution set must not contain duplicate subsets.
            Have you met this question in a real interview?  
            Example
            Example 1:

            Input: [0]
            Output:
            [
              [],
              [0]
            ]
            Example 2:

            Input: [1,2,3]
            Output:
            [
              [3],
              [1],
              [2],
              [1,2,3],
              [1,3],
              [2,3],
              [1,2],
              []
            ]
            Challenge
            Can you do it in both recursively and iteratively?
         */

        public static IList<IList<int>> Subsets(int[] nums)
        {
            IList<IList<int>> results = new List<IList<int>>();

            FindSubSetsByIndex(0, new List<int>(), nums, results);

            return results;
        }

        public static void FindSubSetsByIndex(int index, List<int> item, int[] nums, IList<IList<int>> result)
        {
            result.Add(new List<int>(item));
            for (int i = index; i < nums.Length; i++)
            {
                item.Add(nums[i]);
                FindSubSetsByIndex(i + 1, item, nums, result);
                item.RemoveAt(item.Count - 1);
            }

        }

        /*
         Given a collection of integers that might contain duplicates, nums, return all possible subsets (the power set).

        Note: The solution set must not contain duplicate subsets.

        Example:

        Input: [1,2,2]
        Output:
        [
          [2],
          [1],
          [1,2,2],
          [2,2],
          [1,2],
          []
        ]
         
         */

        public static IList<IList<int>> UniqueSubsets(int[] nums)
        {
            IList<IList<int>> results = new List<IList<int>>();

            Array.Sort(nums);
            UniqueFindSubSetsByIndex(0, new List<int>(), nums, results);

            return results;
        }

        public static void UniqueFindSubSetsByIndex(int index, List<int> item, int[] nums, IList<IList<int>> result)
        {
            result.Add(new List<int>(item));
            for (int i = index; i < nums.Length; i++)
            {
           
                if (i != index && nums[i] == nums[i - 1])
                {
                    continue;
                }
                item.Add(nums[i]);
                FindSubSetsByIndex(i + 1, item, nums, result);
                item.RemoveAt(item.Count - 1);
            }

        }
    }
}
