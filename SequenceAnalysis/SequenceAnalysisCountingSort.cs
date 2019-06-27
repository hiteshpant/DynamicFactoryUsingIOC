using Contract;
using System;
using System.ComponentModel.Composition;
using System.Text;

namespace SequenceAnalysis
{
    [Export(typeof(IPrintSequenceStrategy))]
    public class SequenceAnalysisCountingSort : IPrintSequenceStrategy
    {
        private readonly int _maxChar = 26;

        public StringBuilder GetSortedSequence(string input)
        {
            var words = input.Split(' ');

            int[] sortedWord = new int[_maxChar];

            SortUpperCaseWord(words, ref sortedWord);

            return PopulateSortedUpperCaseSequence(sortedWord);
        }

        private void SortUpperCaseWord(string[] words, ref int[] sortedWord)
        {
            foreach (var word in words)
            {
                if (IsUpperCase(word))
                {
                    for (int i = 0; i < word.Length; i++)
                    {
                        sortedWord[word[i] - 'A']++;
                    }
                }
            }
        }

        private StringBuilder PopulateSortedUpperCaseSequence(int[] sortedWord)
        {
            StringBuilder output = new StringBuilder();
            for (int i = 0; i < _maxChar; i++)
            {
                for (int j = 0; j < sortedWord[i]; j++)
                {
                    output.Append((char)(i + 'A'));
                }
            }
            return output;
        }

        private bool IsUpperCase(string substring)
        {
            bool result = true;
            for (int i = 0; i < substring.Length; i++)
            {
                if (substring[i] >= 65 && substring[i] <= 90)
                    continue;
                else
                    result = false;
            }
            return result;
        }
    }
}
