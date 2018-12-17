public class Solution {
        public int Reverse(int x)
        {

            if (x == int.MinValue)
                return 0;

            bool negative = false;
            if (x < 0)
            {
                x = -x;
                negative = true;
            }

            int res = 0;
            while (x != 0)
            {
                int tail = x % 10;
                x = x / 10;
                if (res > ((int.MaxValue - tail) / 10))
                    return 0;
                else
                    res = res * 10 + tail;
            };
            return negative ? -res : res;
        }
}
