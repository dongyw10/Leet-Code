public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
            IList<IList<int>> result = new List<IList<int>>();
            if (nums == null || nums.Length < 3)
                return result;

            Array.Sort(nums);

            for (int i = 0; i < nums.Length - 2; i++)
            {
                if (i == 0 || nums[i] > nums[i - 1])
                {
                    int j = i + 1;
                    int k = nums.Length - 1;

                    while (j < k)
                    {
                        if (nums[i] + nums[j] + nums[k] == 0)
                        {
                            List<int> l = new List<int>();
                            l.Add(nums[i]);
                            l.Add(nums[j]);
                            l.Add(nums[k]);
                            result.Add(l);

                            j++;
                            k--;

                            //handle duplicate here
                            while (j < k && nums[j] == nums[j - 1])
                                j++;
                            while (j < k && nums[k] == nums[k + 1])
                                k--;
                        }
                        else if (nums[i] + nums[j] + nums[k] < 0)
                        {
                            j++;
                        }
                        else
                        {
                            k--;
                        }
                    }
                }

            }
            return result;        
    }
}
