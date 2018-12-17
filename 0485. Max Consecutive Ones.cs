public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
                        int maxLenth = 0;
                int currLentth = 0;
                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] == 1)
                        currLentth++;
                    else
                    {
                        maxLenth = Math.Max(maxLenth, currLentth);
                        currLentth = 0;
                    }
                }
                maxLenth = Math.Max(maxLenth, currLentth);

                return maxLenth;
    }
}
