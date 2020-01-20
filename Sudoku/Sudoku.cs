using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Sudoku
{
    public class Sudoku : ISudoku
    {

        private int _nummer;
        private int _id;
        private Dictionary<int, int> startSudoku = new Dictionary<int, int>();
        private Dictionary<int, int> sudokuState = new Dictionary<int, int>();

        public void SetNummer(int nummer)
        {
            _nummer = nummer;
        }
        public int GetNummer()
        {
            return _nummer;
        }

        public int GetId()
        {
            return _id;
        }

        public void SetId(int id)
        {
            _id = id;
        }

        //Close the Applicatin
        public void CloseApplikation()
        {
            Environment.Exit(0);
        }

        //Add the Typed Numbers to Dictionary, to know wich field 
        // have a number.
        public void AddNummerToSudokuState()
        {

            if (!CheckIfIdSaved(_id) && _id > 0)
            {
                sudokuState.Add(_id, _nummer);
            }
            else if (_id > 0)
            {
                sudokuState.Remove(_id);
                sudokuState.Add(_id, _nummer);
            }


        }


        //Checks if a field saved bevor it save it again
        private bool CheckIfIdSaved(int id)
        {
            bool savedId = sudokuState.ContainsKey(id);
            return savedId;
        }

        // Evaluate if a nummer shorter than nine 
        // if it bigger then return zero
        public int EvaluateNumber(int nummer)
        {
            if (nummer > 9)
            {

                nummer = 0;

            }
            else if (nummer == 0)
            {
                nummer = 0;
            }
            SetNummer(nummer);
            return nummer;

        }

        // Start game here is the hardcoded Sudoku 
        // If you press the Start Butten the numbers will 
        // be displayed in the Grid
        public Dictionary<int, int> StartGame()
        {
            startSudoku.Clear();
            startSudoku.Add(1, 3);
            startSudoku.Add(4, 4);
            startSudoku.Add(7, 1);
            startSudoku.Add(9, 7);
            startSudoku.Add(13, 9);
            startSudoku.Add(15, 8);
            startSudoku.Add(25, 4);
            startSudoku.Add(21, 2);
            startSudoku.Add(24, 5);
            startSudoku.Add(30, 8);
            startSudoku.Add(36, 1);
            startSudoku.Add(38, 1);
            startSudoku.Add(40, 8);
            startSudoku.Add(42, 4);
            startSudoku.Add(44, 5);
            startSudoku.Add(46, 5);
            startSudoku.Add(52, 2);
            startSudoku.Add(55, 7);
            startSudoku.Add(57, 6);
            startSudoku.Add(58, 9);
            startSudoku.Add(61, 8);
            startSudoku.Add(67, 7);
            startSudoku.Add(69, 4);
            startSudoku.Add(73, 9);
            startSudoku.Add(75, 3);
            startSudoku.Add(78, 4);
            startSudoku.Add(81, 7);

            return startSudoku;
        }

        // Get the ID from the fiel there is Focused
        public void AddId(int Id)
        {
            SetId(Id);
        }

        // After klicking the Start/ Reset Button 
        // the second time if clears the sudoku state
        public void ResetValueDicitonary()
        {
            sudokuState.Clear();
        }

        // Gives the Akctuel state of the Sudoku Values to the 
        //Viewmodel there set all Values to zero and we can restart with the game.
        public Dictionary<int, int> ResetValues()
        {
            return sudokuState;
        }

        // Checks the fields there is Default seted.
        // Because the default fiels are only read.
        public bool IsDefault(int Id)
        {
            bool isDefault = startSudoku.ContainsKey(Id);
            return isDefault;
        }

        public class App : Application
        {
        }
    }
}
