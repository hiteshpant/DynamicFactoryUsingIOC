using System;
using System.Linq;
using Contract;

namespace Runner
{
    public class Startup
    {

        static void Main(string[] args)
        {
            bool isContinued = true;
            while (isContinued)
            {
                Console.WriteLine("Enter 1 to calculate Sum of natural Number");
                Console.WriteLine("Enter 2 to print sorted Sequence of the string");

                Enum.TryParse(Console.ReadLine(), out Options input);
                Bootstrap bootstrap = new Bootstrap();

                if (IsInputValid(input))
                {
                    if (input == Options.SumOfMultiple)
                        ExecuteSumOfMultipleCalculation(bootstrap);
                    else if (input == Options.SequenceAnalysis)
                        ExecutePrintSortedSequence(bootstrap);
                }
                else
                    Console.WriteLine("Please enter valid choice");

                isContinued = ExecutionToBeContinued();
            }
        }

        private static void ExecutePrintSortedSequence(Bootstrap bootstrap)
        {
            Console.WriteLine("Please Input string for SequenceAnalysis");
            var inputString = Console.ReadLine();
            var output = bootstrap.SequenceAlgoPlugins.FirstOrDefault().GetSortedSequence(inputString);
            Console.WriteLine(output);  
        }       

        private static void ExecuteSumOfMultipleCalculation(Bootstrap bootstrap)
        {
            bool isContinued = true;

            while (isContinued)
            {
                Console.WriteLine("Please Select Algo to calcullate Sum of natural Number");

                Console.WriteLine("1 for calculate using Airthmetic formula strategy");
                Console.WriteLine("2 for calculate using brut force strategy");

                Enum.TryParse(Console.ReadLine(), out SumOfMultiple selecteAlgo);

                bool isInputValid = selecteAlgo == SumOfMultiple.AP || selecteAlgo == SumOfMultiple.BrutForce;
                if (isInputValid)
                {
                    ISumOfMultipleStrategy instance = GetSumOfMultipleInstance(bootstrap, selecteAlgo);

                    Console.WriteLine("Please enter the max limit for sum calculation");

                    int.TryParse(Console.ReadLine(), out int limit);

                    Console.WriteLine("Sum is : " + instance.CalcullateSumOfMultipleStategy(limit));
                }

                isContinued = ExecutionToBeContinued();
            }
        }

        private static ISumOfMultipleStrategy GetSumOfMultipleInstance(Bootstrap bootstrap, SumOfMultiple selectedAlgo)
        {
            var plugins = bootstrap.SumOfMultiplePlugins;

            if (selectedAlgo == SumOfMultiple.AP)
                return plugins.FirstOrDefault(x => x.GetType().Name.Equals("SumOfMultipleAlgoByAP"));

            else if (selectedAlgo == SumOfMultiple.BrutForce)
                return plugins.FirstOrDefault(x => x.GetType().Name.Equals("SumOfMultipleAlgoBrutForce"));
            //Default strategy
            else
                return plugins.FirstOrDefault(x => x.GetType().Name.Equals("SumOfMultipleAlgoBrutForce"));
        }

        private static bool IsInputValid(Options input)
        {
            return input == Options.SequenceAnalysis || input == Options.SumOfMultiple;
        }

        private static bool ExecutionToBeContinued()
        {
            bool isContinued;
            Console.WriteLine("Press Q to quit or any other key to continue");
            var result = Console.ReadLine();
            isContinued = result.ToUpperInvariant() == "Q" ? false : true;
            return isContinued;
        }
    }


}
