
using System.Text;

namespace Contract
{
    public interface IPrintSequenceStrategy
    {
        StringBuilder GetSortedSequence(string input);
    }
}
