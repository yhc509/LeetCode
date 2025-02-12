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
        Dictionary<int, List<int>> dict = new Dictionary<int, List<int>>();

        Array.Sort(nums);
        Array.Reverse(nums);
        
        for(int i = 0; i < nums.Length; i++) {
            var digitSum = SumOfDigit(nums[i]);
            Console.WriteLine(nums[i] + "->" + digitSum);
            if(dict.ContainsKey(digitSum) == false) {
                var l = new List<int>();
                dict.Add(digitSum, l);
            }
            else {
                if(dict[digitSum].Count >= 2) continue;
            }
            dict[digitSum].Add(nums[i]);
        }

        int result = -1;

        foreach(var k in dict) {
            if(k.Value.Count < 2) continue;
            int sum = k.Value.Sum();
            Console.WriteLine($"{k.Key}, {sum}");
            if(result <= sum) {
                result = sum;
            }
        }

        return result;
    }
}