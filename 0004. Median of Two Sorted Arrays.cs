public class Solution {
     public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int half = (nums1.Length + nums2.Length) / 2;
            if (nums1.Length > nums2.Length)
            {
                int[] temp = nums1;
                nums1 = nums2;
                nums2 = temp;
            }
            int iLeft = 0;
            int iRight = nums1.Length;

            while (iLeft < iRight)
            {
                int i = (iLeft + iRight) / 2;
                int j = half - i;

                if (i != nums1.Length && nums2[j - 1] > nums1[i])
                {
                    iLeft = i + 1;
                }
                else if (i != 0 && nums1[i - 1] > nums2[j])
                {
                    iRight = i - 1;
                }
                else
                {
                    iRight = i;
                    iLeft = i;
                }
            }

            int iCurr = iLeft;
            int jCurr = half - iCurr;

            int rightMin = 0;
            if (iCurr == nums1.Length)
                rightMin = nums2[jCurr];
            else if (jCurr == nums2.Length)
                rightMin = nums1[iCurr];
            else
                rightMin = Math.Min(nums1[iCurr], nums2[jCurr]);
            if ((nums1.Length + nums2.Length) % 2 == 1)
                return rightMin;

            int leftMax = 0;
            if (iCurr == 0)
                leftMax = nums2[jCurr - 1];
            else if (jCurr == 0)
                leftMax = nums1[iCurr - 1];
            else
                leftMax = Math.Max(nums1[iCurr - 1], nums2[jCurr - 1]);

            return ((double)leftMax + (double)rightMin) / 2;
        }
}
