using System;

namespace Open_Lab_04._12
{
    public class Numbers
    {
        public int MissingNum(int[] nums)
        {
            Array.Sort(nums);
            for (int i = 0; i < 9; i++)
            {
                if (nums[i] != i + 1)
                    return i + 1;
            }

            return 10;
        }
    }
}
