using System;
using System.Collections;

namespace Data_Structure;
internal class ActionsWithArray {

    //Добавить в массив в форме целого числа
    public static IList<int> AddToArrayForm(int[] num, int k) {
        if(k == 0)
            return new List<int>(num);

        var list = new List<int>();
        var list1 = new List<int>(num);
        while(k != 0) {
            list.Add(k % 10);
            k /= 10;
        }
        
        list1.Reverse();

        int additional = 0;
        int length = Math.Max(num.Length, list.Count);
        if(list.Count < list1.Count)
            (list, list1) = (list1, list);
        for(int i = 0; i < length; i++) {
            list[i] += additional;
            if(i < list1.Count) {
                list[i] += list1[i];
            } 
            if(list[i] > 9) {
                list[i] = list[i] % 10;
                additional = 1;
            } else
                additional = 0;
        }
        if(additional == 1)
            list.Add(1);

        list.Reverse();
        return list;
    }

    // Содержит дубликат 217
    public bool ContainsDuplicate(int[] nums) {
        HashSet<int> heap = new HashSet<int>();
        for(int i = 0; i < nums.Length; i++) {
            if(heap.Contains(nums[i]))
                return true;
            else
                heap.Add(nums[i]);
        }
        return false;
    }

    // Сумма 2 значений из массива равная target 1
    public int[]? TwoSum(int[] nums, int target) {
        var dict = new Dictionary<int, int>(nums.Length) {
            { nums[0], 0 }
        };
        for(int i = 1; i < nums.Length; i++) {
            if(dict.ContainsKey(target - nums[i]))
                return new int[] { dict[target - nums[i]], i };
            if(!dict.ContainsKey(nums[i]))
                dict.Add(nums[i], i);
        }
        return null;
    }

    // Объединить отсортированный массив 88
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        if(n == 0)
            return;
        for(int i = n + m - 1, n1Ind = m - 1, n2Ind = n - 1; i >= 0 && n2Ind != -1; i--) {
            if(n1Ind != -1 && nums2[n2Ind] < nums1[n1Ind]) {
                nums1[i] = nums1[n1Ind--];
            } else
                nums1[i] = nums2[n2Ind--];
        }
    }

    // Пересечение двух массивов I 349
    private int[] Intersection(int[] nums1, int[] nums2) {
        if(nums1.Length < nums2.Length) {
            return Intersection(nums2, nums1);
        }
        System.Array.Sort(nums1);
        System.Array.Sort(nums2);

        var list = new List<int>();
        int iNums1 = 0, jNums2 = 0;
        while(iNums1 < nums1.Length && jNums2 < nums2.Length) {
            if(nums1[iNums1] == nums2[jNums2]) {
                list.Add(nums1[iNums1]);
                while(iNums1 < nums1.Length && nums1[iNums1] == list[^1])
                    iNums1++;
                while(jNums2 < nums2.Length && nums2[jNums2] == list[^1])
                    jNums2++;
            } else if(nums1[iNums1] < nums2[jNums2]) {
                iNums1++;
            } else {
                jNums2++;
            }
        }

        return list.ToArray();
    }

    // Пересечение двух массивов II 350
    private int[] Intersect(int[] nums1, int[] nums2) {
        if(nums1.Length < nums2.Length) {
            return Intersect(nums2, nums1);
        }
        System.Array.Sort(nums1);
        System.Array.Sort(nums2);

        var list = new List<int>();
        int iNums1 = 0, jNums2 = 0;
        while(iNums1 < nums1.Length && jNums2 < nums2.Length) {
            if(nums1[iNums1] == nums2[jNums2]) {
                list.Add(nums1[iNums1]);
                iNums1++;
                jNums2++;
            } else if(nums1[iNums1] < nums2[jNums2]) {
                iNums1++;
            } else {
                jNums2++;
            }
        }

        return list.ToArray();
    }

    // Лучшее время для покупки и продажи акций 121
    public int MaxProfit(int[] prices) {
        int minprice = int.MaxValue;
        int maxprofit = 0;
        for(int i = 0; i < prices.Length; i++) {
            if(prices[i] < minprice)
                minprice = prices[i];
            else if(prices[i] - minprice > maxprofit)
                maxprofit = prices[i] - minprice;
        }
        return maxprofit;
    }
}
