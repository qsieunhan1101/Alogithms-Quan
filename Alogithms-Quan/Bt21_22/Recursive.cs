using System;

namespace Alogithms_Quan
{
    internal class Recursive
    {

        /// <summary>
        /// Tinh luong cua nam thu n co luong tang bang 10% nam truoc(khong dung de quy)
        /// </summary>
        /// <param name="salary">luong co ban</param>
        /// <param name="n">so nam</param>
        /// <returns></returns>
        public float calSalaryNonRecursive(float salary, int n)
        {
            float salary_n = salary;
            float rate = (float)10 / 100;

            for (int i = 1; i <= n; i++)
            {
                salary_n = salary_n + salary_n * rate;
            }
            return salary_n;
        }
        /// <summary>
        /// Tinh luong cua nam thu n co luong tang bang 10% nam truoc(co dung de quy)
        /// 
        /// </summary>
        /// <param name="salary">luong co ban</param>
        /// <param name="n">so nam</param>
        /// <returns></returns>
        public float calSalaryRecursive(float salary, int n)
        {
            float rate = (float)10 / 100;
            if (n == 1)
            {
                return salary + salary * rate;
            }
            float salary_n = 0;
            salary_n = salary + salary * rate;
            return calSalaryRecursive(salary_n, n - 1);

        }

        public double calMonthNonRecursive(float money, float rate)
        {
            double e = 2.71828;
            double t = 1 + rate / 100;
            double n = 0;
            n = Math.Log(3, e) / Math.Log((double)t);

            return n;
        }

        public double calMonthRecursive(float money, float rate)
        {
            if (money == 0)
            {
                return 0;
            }
            float lai = money * rate;
            money = money - lai;

            return calMonthNonRecursive(lai, rate);
        }
    }
}
