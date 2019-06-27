using Microsoft.VisualStudio.TestTools.UnitTesting;
using SequenceAnalysis;

namespace Test
{
    [TestClass]
    public class SequenceAnalysisTest
    {
      
        [TestMethod]
        public void TestEmptySequence()
        {
            //Arrange
            SequenceAnalysisCountingSort algo = new SequenceAnalysisCountingSort();

            //Act 
            algo.GetSortedSequence(string.Empty);

            //Assert
            Assert.AreEqual(string.Empty, string.Empty);
        }


        [TestMethod]
        public void TestSequence()
        {
            //Arrange
            SequenceAnalysisCountingSort algo = new SequenceAnalysisCountingSort();

            //Act 
            var output =algo.GetSortedSequence("This IS a STRING");

            //Assert
            Assert.AreEqual("GIINRSST", output.ToString());
        }


        [TestMethod]
        public void TestSequenceWithSpecialCharacter()
        {
            //Arrange
            SequenceAnalysisCountingSort algo = new SequenceAnalysisCountingSort();

            //Act 
            var output = algo.GetSortedSequence("This IS a STRING** RT$#@%^ jsadasldj CORRECT");

            //Assert
            Assert.AreEqual("CCEIORRST", output.ToString());
        }
    }
}
