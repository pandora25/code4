using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arQam = { 1, 2, 3, 4, 5 };
            int maxNumber = 10;

           bool result =  IsSumLarger(arQam, maxNumber);
            Console.WriteLine(result);
        }
        #region
        public static bool IsSumLarger(int[] numbers, int comparisonNumber)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i]++;
                sum += numbers[i];
            }
            if (sum > comparisonNumber)
            {
                return true;

            }
            else
            {
                return false;
            }
        }
        #endregion
    }
}
