using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programs_Practice
{
    internal class CouponNumbers
    {
        public static int GenerateDistinctCoupons(int n)
        {
            Random random = new Random();
            HashSet<int> distinctCoupons = new HashSet<int>();
            int totalRandomNumbers = 0;

            while (distinctCoupons.Count < n)
            {
                int randomNumber = random.Next(1, n + 1);
                if (!distinctCoupons.Contains(randomNumber))
                {
                    distinctCoupons.Add(randomNumber);
                }
                totalRandomNumbers++;
            }

            return totalRandomNumbers;
        }
    }
}
