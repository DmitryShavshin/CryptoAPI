using System;
using System.Collections.Generic;

namespace CryptoAPI.Core
{
    public class RandomChartInfo
    {
        public List<int> Numbers()
        {
            var nums = new List<int>();
            Random random = new Random();
            for (int i = 0; i < 15; i++)
            {
                nums.Add(random.Next(20, 99));
            }
            return nums;
        }
    }
}
