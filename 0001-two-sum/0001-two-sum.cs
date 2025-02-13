public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int[] result = new int[2];

        // for(int i = 0; i < nums.Length; i++) {
        //     for(int j = 0; j < nums.Length; j++) {
        //         if(i == j) continue;

        //         if(nums[i] + nums[j] == target) {
        //             result[0] = i;
        //             result[1] = j;
        //         }
        //     }
        // }

        Dictionary<int, int> r = new Dictionary<int, int>();
        for(int i = 0; i < nums.Length; i++) {
            int t = nums[i];
            if(r.ContainsKey(target - t)) {
                result[0] = r[target - t];
                result[1] = i;
                break;
            }
            r[t] = i;
        }
        return result;
    }
}