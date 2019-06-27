using Contract;
using SumOfMultiple;
using System.ComponentModel.Composition;

namespace SequenceAnalysis
{
    [Export(typeof(ISumOfMultipleStrategy))]
    public class SumOfMultipleAlgoBrutForce : ISumOfMultipleStrategy
    {
        public long CalcullateSumOfMultipleStategy(long limit)
        {
            long SumOf3 = GetSumDivisbleByInputNumber(3, (limit-1));
            long SumOf5 = GetSumDivisbleByInputNumber(5, (limit-1));
            long sumOf15 = GetSumDivisbleByInputNumber(15, (limit-1));

            return SumOf3 + SumOf5 - sumOf15;
        }

        public int GetSumDivisbleByInputNumber(int input,long limit)
        {
            int sum = 0;
            for (int i = 1; i <= limit; i++)
            {
                if (i % input == 0)
                    sum += i;
            }
            return sum;
        }
       
    }
}
