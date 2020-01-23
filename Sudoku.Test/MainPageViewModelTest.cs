using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Sudoku.ViewModel;
using System.Collections.Generic;

namespace Sudoku.Test

{   [TestClass]
    public class MainPageViewModelTest
    {

        private readonly Mock<ISudoku> sudokuMock;
        private readonly MainPageViewModel testee;

        public MainPageViewModelTest()
        {
            sudokuMock = new Mock<ISudoku>();
            this.testee = new MainPageViewModel(sudokuMock.Object);
        }

        [TestMethod]
        public void StartGame_AddDefaultFields_CheckIsReadOnly()
        {
            //Arange
            Dictionary<int, int> testDefaults = new Dictionary<int, int>
            {
            {2, 1},
            {3, 5},
            {9, 6},
            {10, 9}
            };
            Dictionary<int, int> reset = new Dictionary<int, int>{
                {1,1 } };

            string start = "0";
            //Act
            
            sudokuMock.Setup(m => m.ResetValues()).Returns(reset);
            sudokuMock.Setup(m => m.StartGame()).Returns(testDefaults);
            sudokuMock.Setup(m => m.IsDefault(2)).Returns(true);
            sudokuMock.Setup(m => m.EvaluateNumber(1)).Returns(1);
            sudokuMock.Setup(m => m.IsDefault(3)).Returns(true);
            sudokuMock.Setup(m => m.EvaluateNumber(5)).Returns(5);
            sudokuMock.Setup(m => m.IsDefault(9)).Returns(true);
            sudokuMock.Setup(m => m.EvaluateNumber(6)).Returns(6);
            sudokuMock.Setup(m => m.IsDefault(10)).Returns(true);
            sudokuMock.Setup(m => m.EvaluateNumber(9)).Returns(9);
            this.testee.StartGameCommand.Execute(start);
            
 

            // Assets
            Assert.AreEqual(testee.ReadOnly2, true);
            Assert.AreEqual(testee.ReadOnly3, true);
            Assert.AreEqual(testee.ReadOnly9, true);
            Assert.AreEqual(testee.ReadOnly10, true);
            Assert.AreEqual(testee.ReadOnly70, false);
        }

        [TestMethod]
        public void ResetValues_Expect_DefaultValues()
        {
            //Arange
            Dictionary<int, int> testDefaults = new Dictionary<int, int>
            {
            {2, 1},
            {3, 5},
            {9, 6},
            {10, 9}
            };
            Dictionary<int, int> reset = new Dictionary<int, int>{
               };

            string start = "0";
            //Act

            sudokuMock.Setup(m => m.ResetValues()).Returns(reset);
            sudokuMock.Setup(m => m.StartGame()).Returns(testDefaults);
            sudokuMock.Setup(m => m.IsDefault(2)).Returns(true);
            sudokuMock.Setup(m => m.EvaluateNumber(1)).Returns(1);
            sudokuMock.Setup(m => m.EvaluateNumber(5)).Returns(5);
            sudokuMock.Setup(m => m.EvaluateNumber(6)).Returns(6);
            sudokuMock.Setup(m => m.EvaluateNumber(9)).Returns(9);

            //Starts the Game
            this.testee.StartGameCommand.Execute(start);
            this.testee.SelectedEntryCommand.Execute(start);
            this.testee.Nummer12 = 6;
            sudokuMock.Setup(m => m.AddId(12));
            sudokuMock.Setup(m => m.EvaluateNumber(6)).Returns(6);
            sudokuMock.Setup(m => m.AddNummerToSudokuState());

            this.testee.SelectedEntryCommand.Execute(start);
            this.testee.Nummer35 = 1;
            sudokuMock.Setup(m => m.AddId(35));
            sudokuMock.Setup(m => m.EvaluateNumber(1)).Returns(1);
            sudokuMock.Setup(m => m.AddNummerToSudokuState());

            this.testee.SelectedEntryCommand.Execute(start);
            this.testee.Nummer46 = 9;
            sudokuMock.Setup(m => m.AddId(46));
            sudokuMock.Setup(m => m.EvaluateNumber(9)).Returns(9);
            sudokuMock.Setup(m => m.AddNummerToSudokuState());


            //First Assets
            Assert.AreEqual(6, this.testee.Nummer12);
            Assert.AreEqual(9, this.testee.Nummer46);
            Assert.AreEqual(1, this.testee.Nummer35);


            //Reset to Default
            reset.Add(12, 6);
            reset.Add(35, 1);
            reset.Add(46, 9);
            sudokuMock.Setup(m => m.StartGame()).Returns(testDefaults);
            this.testee.StartGameCommand.Execute(start);



            // Assets
            Assert.AreEqual(0, this.testee.Nummer12);
            Assert.AreEqual(0, this.testee.Nummer35);
            Assert.AreEqual(0, this.testee.Nummer46);
            Assert.AreEqual(1, this.testee.Nummer2);
            Assert.AreEqual(5, this.testee.Nummer3);
            Assert.AreEqual(6, this.testee.Nummer9);
            Assert.AreEqual(9, this.testee.Nummer10);
        }




    }
}
