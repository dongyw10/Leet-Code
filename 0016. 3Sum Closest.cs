    public class Solution
    {
        public int ThreeSumClosest(int[] nums, int target)
        {
            int res = 0;
            if (nums == null || nums.Length < 3)
                return 0;

            Array.Sort(nums);
            int currentClosest = int.MaxValue;

            for (int i = 0; i < nums.Length - 2; i++)
            {
                if (i == 0 || nums[i] > nums[i - 1])
                {
                    int j = i + 1;
                    int k = nums.Length - 1;

                    while (j < k)
                    {
                        if (nums[i] + nums[j] + nums[k] == target)
                        {
                            return target;
                        }
                        else
                        {
                            int sum = nums[i] + nums[j] + nums[k];
                            if (currentClosest == int.MaxValue)
                                currentClosest = sum;
                            else
                            {
                                if (Math.Abs(sum - target) < Math.Abs(currentClosest - target))
                                    currentClosest = sum;
                            }
                            if (sum < target)
                                j++;
                            else
                                k--;
                        }
                    }
                }
            }
            return currentClosest;
        }

    }
