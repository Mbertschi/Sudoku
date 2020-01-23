using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Essentials;

namespace Sudoku
{
    public interface ISudoku
    {
        void CloseApplikation();

        int EvaluateNumber(int nummer);

        Dictionary<int, int> StartGame();

        void AddId(int Id);

        bool IsDefault(int Id);

        void AddNummerToSudokuState();

        Dictionary<int, int> ResetValues();

        void ResetValueDicitonary();

        void Serverty(string Serverty);

    }
}
