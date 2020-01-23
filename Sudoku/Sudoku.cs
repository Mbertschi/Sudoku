using Sudoku.SudokuRessources;
using System;
using System.Collections.Generic;
using Xamarin.Forms;


namespace Sudoku
{
    public class Sudoku : ISudoku
    {
        private static Ressources ressources;
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
            sudokuState.Add(_id, _nummer);
            return sudokuState;
        }

        // Checks the fields there is Default seted.
        // Because the default fiels are only read.
        public bool IsDefault(int Id)
        {
            bool isDefault = startSudoku.ContainsKey(Id);
            return isDefault;
        }

        // Check wich severty Sudoku you want
        public void Serverty(string severty)
        {
           startSudoku.Clear();
            foreach(KeyValuePair<int,int> defaultNummers in Ressources.getInstance().GetTemplate(severty))
            {
                startSudoku.Add(defaultNummers.Key, defaultNummers.Value);
            }
           
        }


        public class App : Application
        {
        }
    }
}
