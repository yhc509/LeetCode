public class Solution {
    public int SumOfDigit(int num) {
        int sum = 0;
        while(true) {
            sum += num % 10;
            if(num < 10) break;
            num = num / 10;
        }
        return sum;
    }

    public int MaximumSum(int[] nums) {
        Dictionary<int, int> dict = new Dictionary<int, int>();

        // Array.Sort(nums);
        // Array.Reverse(nums);
        
        int max = -1;
        for(int i = 0; i < nums.Length; i++) {
            var n = nums[i];
            var digitSum = SumOfDigit(n);
            if(dict.ContainsKey(digitSum) == false) {
                dict.Add(digitSum, n);
            }
            else {
                max = Math.Max(max, dict[digitSum] + n);
                dict[digitSum] = Math.Max(dict[digitSum], n);
            }
        }

        return max;
    }
}