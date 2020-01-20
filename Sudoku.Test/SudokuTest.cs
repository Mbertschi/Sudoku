using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace Sudoku.Test
{
    [TestClass]
    public class SudokuTest
    {
        private Sudoku testee;
 

        public SudokuTest()
        {
            this.testee = new Sudoku();

        }




        [TestMethod]
        public void AddNummerToSudokuStateTest_SetID_And_Nummer_Zero_Return_EmptyDictionary()
        {
            //Arrange
            testee.SetId(0);
            testee.SetNummer(0);

            //Activity
            this.testee.AddNummerToSudokuState();

            //Expect
            Assert.AreEqual(0, testee.ResetValues().Count());
           
        }


        [TestMethod]
        public void EvaluateNumber_in_12_out_0()
        {
            //Arrange
            var expect = 0;

            //Activity
           var result = testee.EvaluateNumber(12);

            //Expect
            Assert.AreEqual(expect, result );

        }


        [TestMethod]
        public void EvaluateNumber_in_0_out_0()
        {
            //Arrange
            var expect = 0;

            //Activity
            var result = testee.EvaluateNumber(0);

            //Expect
            Assert.AreEqual(expect, result);

        }


        [TestMethod]
        public void EvaluateNumber_in_6_out_6()
        {
            //Arrange
            var expect = 6;

            //Activity
            var result = testee.EvaluateNumber(6);

            //Expect
            Assert.AreEqual(expect, result);

        }



    }
}
