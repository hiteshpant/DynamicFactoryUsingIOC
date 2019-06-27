using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SequenceAnalysis;
using SumOfMultiple;

namespace UnitTestProject1
{
    [TestClass]
    public class SumOfSequenceTest
    {
        [TestMethod]
        public void TestSumOfSequenceByAPExcluding()
        {
            //Arrange
            SumOfMultipleAlgoByAP algo = new SumOfMultipleAlgoByAP();

            //Act 
            var output=algo.CalcullateSumOfMultipleStategy(15);

            //Assert
            Assert.AreEqual(45, output);
        }


        [TestMethod]
        public void TestSumOfSequenceByBrutForceExcluding()
        {
            //Arrange
            SumOfMultipleAlgoBrutForce algo = new SumOfMultipleAlgoBrutForce();

            //Act 
            var output = algo.CalcullateSumOfMultipleStategy(15);

            //Assert
            Assert.AreEqual(45, output);
        }

        [TestMethod]
        public void TestSumOfSequenceByAPIncluding()
        {
            //Arrange
            SumOfMultipleAlgoByAP algo = new SumOfMultipleAlgoByAP();

            //Act 
            var output = algo.CalcullateSumOfMultipleStategy(16);

            //Assert
            Assert.AreEqual(60, output);
        }


        [TestMethod]
        public void TestSumOfSequenceByBrutForceIncluding()
        {
            //Arrange
            SumOfMultipleAlgoBrutForce algo = new SumOfMultipleAlgoBrutForce();

            //Act 
            var output = algo.CalcullateSumOfMultipleStategy(16);

            //Assert
            Assert.AreEqual(60, output);
        }


        [TestMethod]
        public void TestSumOfSequenceByAPBoundaryCond()
        {
            //Arrange
            SumOfMultipleAlgoByAP algo = new SumOfMultipleAlgoByAP();

            //Act 
            var output = algo.CalcullateSumOfMultipleStategy(0);

            //Assert
            Assert.AreEqual(0, output);
        }


        [TestMethod]
        public void TestSumOfSequenceBrutForceBoundaryCond()
        {
            //Arrange
            SumOfMultipleAlgoBrutForce algo = new SumOfMultipleAlgoBrutForce();

            //Act 
            var output = algo.CalcullateSumOfMultipleStategy(0);

            //Assert
            Assert.AreEqual(0, output);
        }

        [TestMethod]
        public void TestSumOfSequenceByAPNegativeVal()
        {
            //Arrange
            SumOfMultipleAlgoByAP algo = new SumOfMultipleAlgoByAP();

            //Act 
            var output = algo.CalcullateSumOfMultipleStategy(-180);

            //Assert
            Assert.AreEqual(0, output);
        }


        [TestMethod]
        public void TestSumOfSequenceBrutForceNegativeVal()
        {
            //Arrange
            SumOfMultipleAlgoBrutForce algo = new SumOfMultipleAlgoBrutForce();

            //Act 
            var output = algo.CalcullateSumOfMultipleStategy(-180);

            //Assert
            Assert.AreEqual(0, output);
        }


    }
}
