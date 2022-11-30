public class Program {
    public static void Main(string[] args) {
        int target = 7;
        int[] nums = { 2, 3, 1, 2, 4, 2 };
        Console.WriteLine(MinSubArrayLen(target, nums));

        int[] nums1 = { 1, 2, 3, 4 };
        int[] u = ProductExceptSelf1(nums1);

        int[] nums2 = { 23, 2, 6, 4, 7 };
        int k = 13;
        Console.WriteLine(CheckSubarraySum(nums2, k));

        Console.WriteLine(1);
    }

    //Учитывая массив положительных целых чисел nums и целочисленное положительное значение target,
    //верните минимальную длину subarray, сумма которого больше или равна target.
    //Если такого подмассива нет, вместо этого верните 0.
    //int target = 7;
    //int[] nums = { 2, 3, 1, 2, 4, 3 };
    //MinSubArrayLen(target, nums)  ( 2, [4,3])
    public static int MinSubArrayLen(int target, int[] nums) {
        int numsLength = nums.Length;
        int maxLenSubarr = int.MaxValue;
        int left = 0;
        int sum = 0;
        for(int i = 0; i < numsLength; i++) {
            sum += nums[i];
            while(sum >= target) {
                maxLenSubarr = Math.Min(maxLenSubarr, i + 1 - left);
                sum -= nums[left++];
            }
        }
        return (maxLenSubarr != int.MaxValue) ? maxLenSubarr : 0;
    }

    //Учитывая целочисленный массив nums, верните массив answer таким образом, чтобы answer[i] был равен произведению всех элементов nums, кроме nums[i].
    //Произведение любого префикса или суффикса чисел гарантированно укладывается в 32-разрядное целое число.
    //Вы должны написать алгоритм, который выполняется за O(n) время и без использования операции деления.
    //int[] nums = { 1, 2, 3, 4 };
    //ProductExceptSelf(nums)  ([24, 12, 4, 6]);
    public static int[] ProductExceptSelf(int[] nums) {
        int numsLength = nums.Length;
        int comp = 1;
        int zeroes = 0;
        for(int i = 0; i < numsLength; i++) {
            if(nums[i] != 0)
                comp *= nums[i];
            else if(++zeroes == 2)
                return new int[numsLength];
        }

        if(zeroes == 1) {
            int zeroInd = Array.IndexOf(nums, 0);
            nums = new int[numsLength];
            nums[zeroInd] = comp;
            return nums;
        }

        for(int i = 0; i < numsLength; i++)
            nums[i] = comp / nums[i];
        return nums;
    }

    public static int[] ProductExceptSelf1(int[] nums) {
        int numsLength = nums.Length;
        int[] res = new int[numsLength];

        res[0] = nums[0];
        for(int i = 1; i < numsLength - 1; i++) {
            res[i] = res[i - 1] * nums[i];
        }

        res[numsLength - 1] = res[numsLength - 2];
        int r = 1;
        for(int i = numsLength - 1; i > 0; i--) {
            res[i] = res[i - 1] * r;
            r *= nums[i];
        }
        res[0] = r;

        return res;
    }

    public static bool CheckSubarraySum(int[] nums, int k) {
        if(nums.Length == 1)
            return false;

        int numsLength = nums.Length;
        int sum = 0;

        for(int i = 0; i < numsLength - 1; i++) {
            sum += nums[i];
            for(int j = i + 1; j < numsLength; j++) {
                sum += nums[j];
                if(sum % k == 0)
                    return true;
            }
            sum = 0;
        }
        return false;
    }

}