using Contract;
using System.ComponentModel.Composition;

namespace SumOfMultiple
{
    [Export(typeof(ISumOfMultipleStrategy))]
    public class SumOfMultipleAlgoByAP : ISumOfMultipleStrategy
    {
        public long CalcullateSumOfMultipleStategy(long limit)
        {
            long sumOfThree = 0, sumOfFive = 0, sumOf15 = 0;
            var n = limit - 1;
            if (limit > 0)
            {
                sumOfThree = getSumUsingAPFormula(n / 3, 3, 3);
                sumOfFive = getSumUsingAPFormula(n / 5, 5, 5);
                sumOf15 = getSumUsingAPFormula(n / 15, 15, 15);
            }

            //p(a union B) = p(a)+p(b)-p(a intersection B)

            return sumOfThree + sumOfFive - sumOf15;
        }


        private long getSumUsingAPFormula(long n, int a, int d)
        {
            //As number divisible by 3 will form an AP
            //using formula for sum of AP n/2(2a + (n-1)d)

            return (n * (2 * a + (n - 1) * d))/2;
        }
    }
}
