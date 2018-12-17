public class Solution {
    public int[] TwoSum(int[] nums, int target) {
            IDictionary<int, int> numsDic = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++){
                int remain = target - nums[i];
                if (numsDic.ContainsKey(remain))
                   return new int[] { numsDic[remain], i };
                if (!numsDic.ContainsKey(nums[i]))
                    numsDic.Add(nums[i], i);
            }
            throw new Exception("have not solution");        
    }
}
