using System;
using System.Collections.Generic;
using System.Text;

namespace Sudoku.SudokuRessources
{
    public class Ressources
    {
        private static Ressources instance;

        private Ressources() 
        {
        }

        public static Ressources getInstance()
            {
              if(Ressources.instance == null)
            {
                Ressources.instance = new Ressources();
            }
            return Ressources.instance;
            
             }

        public Dictionary<int,int> GetTemplate(String severity)
        {
            if (severity.Equals("Easy"))
            {
                return Easy;
            }
            else if (severity.Equals("Middle"))
            {
                return Middle;
            }
            else
            {
                return Hard;
            }
        }


        // Template for an easy Sudoku
        Dictionary<int, int> Easy = new Dictionary<int, int> {
            { 1, 3 },
            { 4, 4 },
            {7, 1},
            {9, 7},
            {13, 9},
            {15, 8},
            {25, 4},
            {21, 2},
            {24, 5},
            {30, 8},
            {36, 1},
            {38, 1},
            {40, 8},
            {42, 4},
            {44, 5},
            {46, 5},
            {52, 2},
            {55, 7},
            {57, 6},
            {58, 9},
            {61, 8},
            {67, 7},
            {69, 4},
            {73, 9},
            {75, 3},
            {78, 4},
            {81, 7},
            };

        // Temlate for an easy middle Sudoku 
        Dictionary<int, int> Middle = new Dictionary<int, int>
        {
            {2, 7},
            {7, 9},
            {9, 6},
            {10, 9},
            {14, 7},
            {19, 1},
            {23,6},
            {25, 4},
            {28, 6},
            {31, 2},
            {34, 5},
            {36, 1},
            {39, 9},
            {42, 4},
            {43, 3},
            {45, 6},
            {46, 8},
            {51, 5},
            {53, 9},
            {56, 5},
            {57, 8},
            {61, 7},
            {66, 3},
            {68, 2},
            {72, 1},
            {75, 9},
            {79, 3}

        };

        // It is the template for a hard Sudoku
        Dictionary<int, int> Hard = new Dictionary<int, int>
        {
            {2, 1},
            {3, 5},
            {9, 6},
            {10, 9},
            {12, 6},
            {16, 1},
            {18, 2},
            {22, 7},
            {26, 8},
            {28, 2},
            {31, 3},
            {40, 7},
            {42, 8},
            {44, 3},
            {50, 6},
            {54, 7},
            {58, 4},
            {60, 2},
            {67, 6},
            {72, 9 },
            {78, 9},
            {79, 1},
            {80, 5}
        };
    }
}
