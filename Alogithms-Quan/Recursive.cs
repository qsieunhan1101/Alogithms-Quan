using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alogithms_Quan
{
    internal class Recursive
    {
        public float calSalaryNonRecursive(float salary, int n) 
        {
            float salary_n = salary;
            for (int i = 1; i <= n; i++ )
            {
                salary_n = salary_n + salary_n * 10/100;
            }
            return salary_n;
        }
    }
}
