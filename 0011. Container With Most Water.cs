public class Solution {
    public int MaxArea(int[] height) {
            int maxVol = 0;
            for (int i = 0; i < height.Length; i++)
                for (int j = i + 1; j < height.Length; j++)
                {
                    int currVol = (j - i) * Math.Min(height[i], height[j]);
                    maxVol = Math.Max(maxVol, currVol);
                }
            return maxVol;
    }
}
