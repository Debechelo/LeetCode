using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure;
internal class SubArray {

    // Максимальная сумма подмассива 53
    public int MaxSubArray(int[] nums) {
        int ans = nums[0];
        int sum = 0;
        int min_sum = 0;
        for(int i = 0; i < nums.Length; i++) {
            sum += nums[i];
            ans = Math.Max(ans, sum - min_sum);
            min_sum = Math.Min(min_sum, sum);
        }
        return ans;
    }
}
