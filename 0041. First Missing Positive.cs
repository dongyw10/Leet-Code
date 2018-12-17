    public class Solution
    {
        public int FirstMissingPositive(int[] nums)
        {
            IDictionary<int,int> dic = new Dictionary<int, int>();
            int max = int.MinValue;
            for(int i=0;i<nums.Length;i++)
            {
                max = Math.Max(max, nums[i]);
                if (!dic.ContainsKey(nums[i]))
                    dic.Add(nums[i], i);
            }
            for (int i = 1; i <= max+1; i++)
            {
                if (!dic.ContainsKey(i))
                    return i;
            }
            return 1;
        }
    }
