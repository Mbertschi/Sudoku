using System.Collections.Generic;
using System.Windows.Input;
using Xamarin.Forms;

namespace Sudoku.ViewModel
{
    public class MainPageViewModel : ViewModelBase
    {
        private readonly ISudoku sudoku;
        Dictionary<int, int> SetTheStart = new Dictionary<int, int>();

        public MainPageViewModel(ISudoku sudoku)
        {
            this.sudoku = sudoku;
        }

        // Close the Applikation
        private ICommand closeApplikationCommand;
        public ICommand CloseApplikationCommand
        {
            get
            {
                closeApplikationCommand = new Command(CloseApplikation);

                return closeApplikationCommand;
            }

        }

        // Start the Game 
        private ICommand startGameCommand;
        public ICommand StartGameCommand
        {
            get
            {
                startGameCommand = new Command(StartGame);

                return startGameCommand;
            }

        }

        // Load the Middle Sudoku before start
        private ICommand onCheckBoxCheckedChangedM;
        public ICommand OnCheckBoxCheckedChangedM
        {

            get
            {
                onCheckBoxCheckedChangedM = new Command(SetMiddelSudoku);

                return onCheckBoxCheckedChangedM;
            }
        }

        // Loads the Hard Sudoku before start
        private ICommand onCheckBoxCheckedChangedH;
        public ICommand OnCheckBoxCheckedChangedH
        {

            get
            {
                onCheckBoxCheckedChangedH = new Command(SetHardSudoku);

                return onCheckBoxCheckedChangedH;
            }
        }

        // Loads the Easy Sudoku before start
        private ICommand onCheckBoxCheckedChangedE;
        public ICommand OnCheckBoxCheckedChangedE
        {

            get
            {
                onCheckBoxCheckedChangedE = new Command(SetEasySudoku);

                return onCheckBoxCheckedChangedE;
            }
        }

        // Set the Variables on the Field
        private void SetDynamicVariable(int fieldNummer, int Value)
        {
            switch (fieldNummer)
            {
                case 1:
                    Nummer1 = Value;
                    ReadOnly1 = DefaultFields(nummer1, 1);
                    break;
                case 2:
                    Nummer2 = Value;
                    ReadOnly2 = DefaultFields(nummer2, 2);
                    break;
                case 3:
                    Nummer3 = Value;
                    ReadOnly3 = DefaultFields(nummer3, 3);
                    break;
                case 4:
                    Nummer4 = Value;
                    ReadOnly4 = DefaultFields(nummer4, 4);
                    break;
                case 5:
                    Nummer5 = Value;
                    ReadOnly5 = DefaultFields(nummer5, 5);
                    break;
                case 6:
                    Nummer6 = Value;
                    ReadOnly6 = DefaultFields(nummer6, 6);
                    break;
                case 7:
                    Nummer7 = Value;
                    ReadOnly7 = DefaultFields(nummer7, 7);
                    break;
                case 8:
                    Nummer8 = Value;
                    ReadOnly8 = DefaultFields(nummer8, 8);
                    break;
                case 9:
                    Nummer9 = Value;
                    ReadOnly9 = DefaultFields(nummer9, 9);
                    break;
                case 10:
                    Nummer10 = Value;
                    ReadOnly10 = DefaultFields(nummer10, 10);
                    break;
                case 11:
                    Nummer11 = Value;
                    ReadOnly11 = DefaultFields(nummer11, 11);
                    break;
                case 12:
                    Nummer12 = Value;
                    ReadOnly12 = DefaultFields(nummer12, 12);
                    break;
                case 13:
                    Nummer13 = Value;
                    ReadOnly13 = DefaultFields(nummer13, 13);
                    break;
                case 14:
                    Nummer14 = Value;
                    ReadOnly14 = DefaultFields(nummer14, 14);
                    break;
                case 15:
                    Nummer15 = Value;
                    ReadOnly15 = DefaultFields(nummer15, 15);
                    break;
                case 16:
                    Nummer16 = Value;
                    ReadOnly16 = DefaultFields(nummer16, 16);
                    break;
                case 17:
                    Nummer17 = Value;
                    ReadOnly17 = DefaultFields(nummer17, 17);
                    break;
                case 18:
                    Nummer18 = Value;
                    ReadOnly18 = DefaultFields(nummer18, 18);
                    break;
                case 19:
                    Nummer19 = Value;
                    ReadOnly19 = DefaultFields(nummer19, 19);
                    break;
                case 20:
                    Nummer20 = Value;
                    ReadOnly20 = DefaultFields(nummer20, 20);
                    break;
                case 21:
                    Nummer21 = Value;
                    ReadOnly21 = DefaultFields(nummer21, 21);
                    break;
                case 22:
                    Nummer22 = Value;
                    ReadOnly22 = DefaultFields(nummer22, 22);
                    break;
                case 23:
                    Nummer23 = Value;
                    ReadOnly23 = DefaultFields(nummer23, 23);
                    break;
                case 24:
                    Nummer24 = Value;
                    ReadOnly24 = DefaultFields(nummer24, 24);
                    break;
                case 25:
                    Nummer25 = Value;
                    ReadOnly25 = DefaultFields(nummer25, 25);
                    break;
                case 26:
                    Nummer26 = Value;
                    ReadOnly26 = DefaultFields(nummer26, 26);
                    break;
                case 27:
                    Nummer27 = Value;
                    ReadOnly27 = DefaultFields(nummer27, 27);
                    break;
                case 28:
                    Nummer28 = Value;
                    ReadOnly28 = DefaultFields(nummer28, 28);
                    break;
                case 29:
                    Nummer29 = Value;
                    ReadOnly29 = DefaultFields(nummer29, 29);
                    break;
                case 30:
                    Nummer30 = Value;
                    ReadOnly30 = DefaultFields(nummer30, 30);
                    break;
                case 31:
                    Nummer31 = Value;
                    ReadOnly31 = DefaultFields(nummer31, 31);
                    break;
                case 32:
                    Nummer32 = Value;
                    ReadOnly32 = DefaultFields(nummer32, 32);
                    break;
                case 33:
                    Nummer33 = Value;
                    ReadOnly33 = DefaultFields(nummer33, 33);
                    break;
                case 34:
                    Nummer34 = Value;
                    ReadOnly34 = DefaultFields(nummer34, 34);
                    break;
                case 35:
                    Nummer35 = Value;
                    ReadOnly35 = DefaultFields(nummer35, 35);
                    break;
                case 36:
                    Nummer36 = Value;
                    ReadOnly36 = DefaultFields(nummer36, 36);
                    break;
                case 37:
                    Nummer37 = Value;
                    ReadOnly37 = DefaultFields(nummer37, 37);
                    break;
                case 38:
                    Nummer38 = Value;
                    ReadOnly38 = DefaultFields(nummer38, 38);
                    break;
                case 39:
                    Nummer39 = Value;
                    ReadOnly39 = DefaultFields(nummer39, 39);
                    break;
                case 40:
                    Nummer40 = Value;
                    ReadOnly40 = DefaultFields(nummer40, 40);
                    break;
                case 41:
                    Nummer41 = Value;
                    ReadOnly41 = DefaultFields(nummer41, 41);
                    break;
                case 42:
                    Nummer42 = Value;
                    ReadOnly42 = DefaultFields(nummer42, 42);
                    break;
                case 43:
                    Nummer43 = Value;
                    ReadOnly43 = DefaultFields(nummer43, 43);
                    break;
                case 44:
                    Nummer44 = Value;
                    ReadOnly44 = DefaultFields(nummer44, 44);
                    break;
                case 45:
                    Nummer45 = Value;
                    ReadOnly45 = DefaultFields(nummer45, 45);
                    break;
                case 46:
                    Nummer46 = Value;
                    ReadOnly46 = DefaultFields(nummer46, 46);
                    break;
                case 47:
                    Nummer47 = Value;
                    ReadOnly47 = DefaultFields(nummer47, 47);
                    break;
                case 48:
                    Nummer48 = Value;
                    ReadOnly48 = DefaultFields(nummer48, 48);
                    break;
                case 49:
                    Nummer49 = Value;
                    ReadOnly49 = DefaultFields(nummer49, 49);
                    break;
                case 50:
                    Nummer50 = Value;
                    ReadOnly50 = DefaultFields(nummer50, 50);
                    break;
                case 51:
                    Nummer51 = Value;
                    ReadOnly51 = DefaultFields(nummer51, 51);
                    break;
                case 52:
                    Nummer52 = Value;
                    ReadOnly52 = DefaultFields(nummer52, 52);
                    break;
                case 53:
                    Nummer53 = Value;
                    ReadOnly53 = DefaultFields(nummer53, 53);
                    break;
                case 55:
                    Nummer55 = Value;
                    ReadOnly55 = DefaultFields(nummer55, 55);
                    break;
                case 56:
                    Nummer56 = Value;
                    ReadOnly56 = DefaultFields(nummer56, 56);
                    break;
                case 57:
                    Nummer57 = Value;
                    ReadOnly57 = DefaultFields(nummer57, 57);
                    break;
                case 58:
                    Nummer58 = Value;
                    ReadOnly58 = DefaultFields(nummer58, 58);
                    break;
                case 59:
                    Nummer59 = Value;
                    ReadOnly59 = DefaultFields(nummer59, 59);
                    break;
                case 60:
                    Nummer60 = Value;
                    ReadOnly60 = DefaultFields(nummer60, 60);
                    break;
                case 61:
                    Nummer61 = Value;
                    ReadOnly61 = DefaultFields(nummer61, 61);
                    break;
                case 62:
                    Nummer62 = Value;
                    ReadOnly62 = DefaultFields(nummer62, 62);
                    break;
                case 63:
                    Nummer63 = Value;
                    ReadOnly63 = DefaultFields(nummer63, 63);
                    break;
                case 64:
                    Nummer64 = Value;
                    ReadOnly64 = DefaultFields(nummer64, 64);
                    break;
                case 65:
                    Nummer65 = Value;
                    ReadOnly65 = DefaultFields(nummer65, 65);
                    break;
                case 66:
                    Nummer66 = Value;
                    ReadOnly66 = DefaultFields(nummer66, 66);
                    break;
                case 67:
                    Nummer67 = Value;
                    ReadOnly67 = DefaultFields(nummer67, 67);
                    break;
                case 68:
                    Nummer68 = Value;
                    ReadOnly68 = DefaultFields(nummer68, 68);
                    break;
                case 69:
                    Nummer69 = Value;
                    ReadOnly69 = DefaultFields(nummer69, 69);
                    break;
                case 70:
                    Nummer70 = Value;
                    ReadOnly70 = DefaultFields(nummer70, 70);
                    break;
                case 71:
                    Nummer71 = Value;
                    ReadOnly71 = DefaultFields(nummer71, 71);
                    break;
                case 72:
                    Nummer72 = Value;
                    ReadOnly72 = DefaultFields(nummer72, 72);
                    break;
                case 73:
                    Nummer73 = Value;
                    ReadOnly73 = DefaultFields(nummer73, 73);
                    break;
                case 74:
                    Nummer74 = Value;
                    ReadOnly74 = DefaultFields(nummer74, 74);
                    break;
                case 75:
                    Nummer75 = Value;
                    ReadOnly75 = DefaultFields(nummer75, 75);
                    break;
                case 76:
                    Nummer76 = Value;
                    ReadOnly76 = DefaultFields(nummer76, 76);
                    break;
                case 77:
                    Nummer77 = Value;
                    ReadOnly77 = DefaultFields(nummer77, 77);
                    break;
                case 78:
                    Nummer78 = Value;
                    ReadOnly78 = DefaultFields(nummer78, 78);
                    break;
                case 79:
                    Nummer79 = Value;
                    readOnly79 = DefaultFields(nummer79, 79);
                    break;
                case 80:
                    Nummer80 = Value;
                    ReadOnly80 = DefaultFields(nummer80, 80);
                    break;
                case 81:
                    Nummer81 = Value;
                    ReadOnly81 = DefaultFields(nummer81, 81);
                    break;
                default:
                    break;
            }

        }

        // Integer can't be emty if e nummer bigger than zero the color
        // change to black otherwise its the same color like the entrys
        private string BiggerThanZero(int nummer)
        {
            if (nummer > 0)
            {
                return "Black";
            }
            else
            {
                return "Green";
            }

        }

        // Set the default fiels read only
        private bool DefaultFields(int nummer, int key)
        {
            if (nummer > 0 && sudoku.IsDefault(key))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // starts the game 
        private void StartGame()
        {
            ResetValues();
            SetTheStart = sudoku.StartGame();
            foreach (KeyValuePair<int, int> field in SetTheStart)
            {
                SetDynamicVariable(field.Key, field.Value);
            }
        }

        // Resets the values there you put it in 
        private void ResetValues()
        {
            Dictionary<int, int> SetResetValues = sudoku.ResetValues();
            foreach (KeyValuePair<int, int> field in SetResetValues)
            {
                SetDynamicVariable(field.Key, 0);
            }
            sudoku.ResetValueDicitonary();
        }

        // Resets the default values to start with an Other sudoku
        private void ResetStartNumbers()
        {
            foreach (KeyValuePair<int, int> field in SetTheStart)
            {
                SetDynamicVariable(field.Key, 0);
            }
        }


        // Is the command for the selected Entry
        private ICommand selectedEntryCommand;
        public ICommand SelectedEntryCommand
        {
            get
            {
                selectedEntryCommand = new Command<string>(SelectEntry);

                return selectedEntryCommand;
            }

        }

        // Convert the String id to a Integer and saves in the Sudok Class
        private void SelectEntry(string id)
        {
            sudoku.AddNummerToSudokuState();
            int i;
            if (int.TryParse(id, out i))
            {
                sudoku.AddId(i);
            }


        }

        // This funktion close the application
        private void CloseApplikation()
        {

            this.sudoku.CloseApplikation();
        }

        // It's load the easy Sudoku
        private void SetEasySudoku()
        {
            ResetStartNumbers();
            this.sudoku.Serverty("Easy");

        }

        // It load the middle Sudoku
        private void SetMiddelSudoku()
        {
            ResetStartNumbers();
            this.sudoku.Serverty("Middle");

        }

        // It load the hard Sudoku
        private void SetHardSudoku()
        {
            ResetStartNumbers();
            this.sudoku.Serverty("Hard");

        }



        // Here are all the bindings for the nummers, colors and defaults
        private int nummer1;
        public int Nummer1
        {

            get { return nummer1; }
            set { nummer1 = sudoku.EvaluateNumber(value); TextColor1 = BiggerThanZero(nummer1); OnPropertyChanged(); }

        }

        private int nummer2;
        public int Nummer2
        {
            get { return nummer2; }
            set { nummer2 = sudoku.EvaluateNumber(value); 
                TextColor2 = BiggerThanZero(nummer2); OnPropertyChanged(); }
            
        }

        private int nummer3;
        public int Nummer3
        {
            get { return nummer3; }
            set { nummer3 = sudoku.EvaluateNumber(value); TextColor3 = BiggerThanZero(nummer3); OnPropertyChanged(); }

        }

        private int nummer4;
        public int Nummer4
        {
            get { return nummer4; }
            set { nummer4 = sudoku.EvaluateNumber(value); TextColor4 = BiggerThanZero(nummer4); OnPropertyChanged(); }

        }

        private int nummer5;
        public int Nummer5
        {
            get { return nummer5; }
            set { nummer5 = sudoku.EvaluateNumber(value); TextColor5 = BiggerThanZero(nummer5); OnPropertyChanged(); }

        }

        private int nummer6;
        public int Nummer6
        {
            get { return nummer6; }
            set { nummer6 = sudoku.EvaluateNumber(value); TextColor6 = BiggerThanZero(nummer6); OnPropertyChanged(); }

        }

        private int nummer7;
        public int Nummer7
        {
            get { return nummer7; }
            set { nummer7 = sudoku.EvaluateNumber(value); TextColor7 = BiggerThanZero(nummer7); OnPropertyChanged(); }

        }

        private int nummer8;
        public int Nummer8
        {
            get { return nummer8; }
            set { nummer8 = sudoku.EvaluateNumber(value); TextColor8 = BiggerThanZero(nummer8); OnPropertyChanged(); }
        }

        private int nummer9;
        public int Nummer9
        {
            get { return nummer9; }
            set { nummer9 = sudoku.EvaluateNumber(value); TextColor9 = BiggerThanZero(nummer9); OnPropertyChanged(); }

        }

        private int nummer10;
        public int Nummer10
        {
            get { return nummer10; }
            set { nummer10 = sudoku.EvaluateNumber(value); TextColor10 = BiggerThanZero(nummer10); OnPropertyChanged(); }

        }

        private int nummer11;
        public int Nummer11
        {
            get { return nummer11; }
            set { nummer11 = sudoku.EvaluateNumber(value); TextColor11 = BiggerThanZero(nummer11); OnPropertyChanged(); }

        }

        private int nummer12;
        public int Nummer12
        {
            get { return nummer12; }
            set { nummer12 = sudoku.EvaluateNumber(value); TextColor12 = BiggerThanZero(nummer12); OnPropertyChanged(); }

        }

        private int nummer13;
        public int Nummer13
        {
            get { return nummer13; }
            set { nummer13 = sudoku.EvaluateNumber(value); TextColor13 = BiggerThanZero(nummer13); OnPropertyChanged(); }

        }

        private int nummer14;
        public int Nummer14
        {
            get { return nummer14; }
            set { nummer14 = sudoku.EvaluateNumber(value); TextColor14 = BiggerThanZero(nummer14); OnPropertyChanged(); }

        }

        private int nummer15;
        public int Nummer15
        {
            get { return nummer15; }
            set { nummer15 = sudoku.EvaluateNumber(value); TextColor15 = BiggerThanZero(nummer15); OnPropertyChanged(); }

        }

        private int nummer16;
        public int Nummer16
        {
            get { return nummer16; }
            set { nummer16 = sudoku.EvaluateNumber(value); TextColor16 = BiggerThanZero(nummer16); OnPropertyChanged(); }

        }

        private int nummer17;
        public int Nummer17
        {
            get { return nummer17; }
            set { nummer17 = sudoku.EvaluateNumber(value); TextColor17 = BiggerThanZero(nummer17); OnPropertyChanged(); }

        }

        private int nummer18;
        public int Nummer18
        {
            get { return nummer18; }
            set { nummer18 = sudoku.EvaluateNumber(value); TextColor18 = BiggerThanZero(nummer18); OnPropertyChanged(); }

        }

        private int nummer19;
        public int Nummer19
        {
            get { return nummer19; }
            set { nummer19 = sudoku.EvaluateNumber(value); TextColor19 = BiggerThanZero(nummer19); OnPropertyChanged(); }

        }

        private int nummer20;
        public int Nummer20
        {
            get { return nummer20; }
            set { nummer20 = sudoku.EvaluateNumber(value); TextColor20 = BiggerThanZero(nummer20); OnPropertyChanged(); }

        }

        private int nummer21;
        public int Nummer21
        {
            get { return nummer21; }
            set { nummer21 = sudoku.EvaluateNumber(value); TextColor21 = BiggerThanZero(nummer21); OnPropertyChanged(); }

        }

        private int nummer22;
        public int Nummer22

        {
            get { return nummer22; }
            set { nummer22 = sudoku.EvaluateNumber(value); TextColor22 = BiggerThanZero(nummer22); OnPropertyChanged(); }

        }

        private int nummer23;
        public int Nummer23
        {
            get { return nummer23; }
            set { nummer23 = sudoku.EvaluateNumber(value); TextColor23 = BiggerThanZero(nummer23); OnPropertyChanged(); }

        }

        private int nummer24;
        public int Nummer24
        {
            get { return nummer24; }
            set { nummer24 = sudoku.EvaluateNumber(value); TextColor24 = BiggerThanZero(nummer24); OnPropertyChanged(); }

        }

        private int nummer25;
        public int Nummer25
        {
            get { return nummer25; }
            set { nummer25 = sudoku.EvaluateNumber(value); TextColor25 = BiggerThanZero(nummer25); OnPropertyChanged(); }

        }

        private int nummer26;
        public int Nummer26
        {
            get { return nummer26; }
            set { nummer26 = sudoku.EvaluateNumber(value); TextColor26 = BiggerThanZero(nummer26); OnPropertyChanged(); }

        }

        private int nummer27;
        public int Nummer27
        {
            get { return nummer27; }
            set { nummer27 = sudoku.EvaluateNumber(value); TextColor27 = BiggerThanZero(nummer27); OnPropertyChanged(); }

        }

        private int nummer28;
        public int Nummer28
        {
            get { return nummer28; }
            set { nummer28 = sudoku.EvaluateNumber(value); TextColor28 = BiggerThanZero(nummer28); OnPropertyChanged(); }
        }

        private int nummer29;
        public int Nummer29
        {
            get { return nummer29; }
            set { nummer29 = sudoku.EvaluateNumber(value); TextColor29 = BiggerThanZero(nummer29); OnPropertyChanged(); }
        }

        private int nummer30;
        public int Nummer30
        {
            get { return nummer30; }
            set { nummer30 = sudoku.EvaluateNumber(value); TextColor30 = BiggerThanZero(nummer30); OnPropertyChanged(); }
        }
        private int nummer31;
        public int Nummer31
        {
            get { return nummer31; }
            set { nummer31 = sudoku.EvaluateNumber(value); TextColor31 = BiggerThanZero(nummer31); OnPropertyChanged(); }
        }
        private int nummer32;
        public int Nummer32
        {
            get { return nummer32; }
            set { nummer32 = sudoku.EvaluateNumber(value); TextColor32 = BiggerThanZero(nummer32); OnPropertyChanged(); }
        }
        private int nummer33;
        public int Nummer33
        {
            get { return nummer33; }
            set { nummer33 = sudoku.EvaluateNumber(value); TextColor33 = BiggerThanZero(nummer33); OnPropertyChanged(); }
        }
        private int nummer34;
        public int Nummer34
        {
            get { return nummer34; }
            set { nummer34 = sudoku.EvaluateNumber(value); TextColor34 = BiggerThanZero(nummer34); OnPropertyChanged(); }
        }
        private int nummer35;
        public int Nummer35
        {
            get { return nummer35; }
            set { nummer35 = sudoku.EvaluateNumber(value); TextColor35 = BiggerThanZero(nummer35); OnPropertyChanged(); }
        }
        private int nummer36;
        public int Nummer36
        {
            get { return nummer36; }
            set { nummer36 = sudoku.EvaluateNumber(value); TextColor36 = BiggerThanZero(nummer36); OnPropertyChanged(); }
        }
        private int nummer37;
        public int Nummer37
        {
            get { return nummer37; }
            set { nummer37 = sudoku.EvaluateNumber(value); TextColor37 = BiggerThanZero(nummer37); OnPropertyChanged(); }
        }
        private int nummer38;
        public int Nummer38
        {
            get { return nummer38; }
            set { nummer38 = sudoku.EvaluateNumber(value); TextColor38 = BiggerThanZero(nummer38); OnPropertyChanged(); }
        }
        private int nummer39;
        public int Nummer39
        {
            get { return nummer39; }
            set { nummer39 = sudoku.EvaluateNumber(value); TextColor39 = BiggerThanZero(nummer39); OnPropertyChanged(); }
        }
        private int nummer40;
        public int Nummer40
        {
            get { return nummer40; }
            set { nummer40 = sudoku.EvaluateNumber(value); TextColor40 = BiggerThanZero(nummer40); OnPropertyChanged(); }
        }
        private int nummer41;
        public int Nummer41
        {
            get { return nummer41; }
            set { nummer41 = sudoku.EvaluateNumber(value); TextColor41 = BiggerThanZero(nummer41); OnPropertyChanged(); }
        }

        private int nummer42;
        public int Nummer42
        {
            get { return nummer42; }
            set { nummer42 = sudoku.EvaluateNumber(value); TextColor42 = BiggerThanZero(nummer42); OnPropertyChanged(); }
        }
        private int nummer43;
        public int Nummer43
        {
            get { return nummer43; }
            set { nummer43 = sudoku.EvaluateNumber(value); TextColor43 = BiggerThanZero(nummer43); OnPropertyChanged(); }
        }
        private int nummer44;
        public int Nummer44
        {
            get { return nummer44; }
            set { nummer44 = sudoku.EvaluateNumber(value); TextColor44 = BiggerThanZero(nummer44); OnPropertyChanged(); }

        }
        private int nummer45;
        public int Nummer45
        {
            get { return nummer45; }
            set { nummer45 = sudoku.EvaluateNumber(value); TextColor45 = BiggerThanZero(nummer45); OnPropertyChanged(); }

        }
        private int nummer46;
        public int Nummer46
        {
            get { return nummer46; }
            set { nummer46 = sudoku.EvaluateNumber(value); TextColor46 = BiggerThanZero(nummer46); OnPropertyChanged(); }
        }
        private int nummer47;
        public int Nummer47
        {
            get { return nummer47; }
            set { nummer47 = sudoku.EvaluateNumber(value); TextColor47 = BiggerThanZero(nummer47); OnPropertyChanged(); }
        }
        private int nummer48;
        public int Nummer48
        {
            get { return nummer48; }
            set { nummer48 = sudoku.EvaluateNumber(value); TextColor48 = BiggerThanZero(nummer48); OnPropertyChanged(); }
        }
        private int nummer49;
        public int Nummer49
        {
            get { return nummer49; }
            set { nummer49 = sudoku.EvaluateNumber(value); TextColor49 = BiggerThanZero(nummer49); OnPropertyChanged(); }

        }

        private int nummer50;
        public int Nummer50
        {
            get { return nummer50; }
            set { nummer50 = sudoku.EvaluateNumber(value); TextColor50 = BiggerThanZero(nummer50); OnPropertyChanged(); }

        }

        private int nummer51;
        public int Nummer51
        {
            get { return nummer51; }
            set { nummer51 = sudoku.EvaluateNumber(value); TextColor51 = BiggerThanZero(nummer51); OnPropertyChanged(); }

        }

        private int nummer52;
        public int Nummer52
        {
            get { return nummer52; }
            set { nummer52 = sudoku.EvaluateNumber(value); TextColor52 = BiggerThanZero(nummer52); OnPropertyChanged(); }

        }

        private int nummer53;
        public int Nummer53
        {
            get { return nummer53; }
            set { nummer53 = sudoku.EvaluateNumber(value); TextColor53 = BiggerThanZero(nummer53); OnPropertyChanged(); }

        }

        private int nummer54;
        public int Nummer54
        {
            get { return nummer54; }
            set { nummer54 = sudoku.EvaluateNumber(value); TextColor54 = BiggerThanZero(nummer54); OnPropertyChanged(); }

        }

        private int nummer55;
        public int Nummer55
        {
            get { return nummer55; }
            set { nummer55 = sudoku.EvaluateNumber(value); TextColor55 = BiggerThanZero(nummer55); OnPropertyChanged(); }

        }

        private int nummer56;
        public int Nummer56
        {
            get { return nummer56; }
            set { nummer56 = sudoku.EvaluateNumber(value); TextColor56 = BiggerThanZero(nummer56); OnPropertyChanged(); }

        }

        private int nummer57;
        public int Nummer57
        {
            get { return nummer57; }
            set { nummer57 = sudoku.EvaluateNumber(value); TextColor57 = BiggerThanZero(nummer57); OnPropertyChanged(); }

        }

        private int nummer58;
        public int Nummer58
        {
            get { return nummer58; }
            set { nummer58 = sudoku.EvaluateNumber(value); TextColor58 = BiggerThanZero(nummer58); OnPropertyChanged(); }

        }

        private int nummer59;
        public int Nummer59
        {
            get { return nummer59; }
            set { nummer59 = sudoku.EvaluateNumber(value); TextColor59 = BiggerThanZero(nummer59); OnPropertyChanged(); }

        }

        private int nummer60;
        public int Nummer60
        {
            get { return nummer60; }
            set { nummer60 = sudoku.EvaluateNumber(value); TextColor60 = BiggerThanZero(nummer60); OnPropertyChanged(); }

        }

        private int nummer61;
        public int Nummer61
        {
            get { return nummer61; }
            set { nummer61 = sudoku.EvaluateNumber(value); TextColor61 = BiggerThanZero(nummer61); OnPropertyChanged(); }

        }

        private int nummer62;
        public int Nummer62
        {
            get { return nummer62; }
            set { nummer62 = sudoku.EvaluateNumber(value); TextColor62 = BiggerThanZero(nummer62); OnPropertyChanged(); }

        }

        private int nummer63;
        public int Nummer63
        {
            get { return nummer63; }
            set { nummer63 = sudoku.EvaluateNumber(value); TextColor63 = BiggerThanZero(nummer63); OnPropertyChanged(); }

        }

        private int nummer64;
        public int Nummer64
        {
            get { return nummer64; }
            set { nummer64 = sudoku.EvaluateNumber(value); TextColor64 = BiggerThanZero(nummer64); OnPropertyChanged(); }

        }

        private int nummer65;
        public int Nummer65
        {
            get { return nummer65; }
            set { nummer65 = sudoku.EvaluateNumber(value); TextColor65 = BiggerThanZero(nummer65); OnPropertyChanged(); }

        }

        private int nummer66;
        public int Nummer66
        {
            get { return nummer66; }
            set { nummer66 = sudoku.EvaluateNumber(value); TextColor66 = BiggerThanZero(nummer66); OnPropertyChanged(); }

        }

        private int nummer67;
        public int Nummer67
        {
            get { return nummer67; }
            set { nummer67 = sudoku.EvaluateNumber(value); TextColor67 = BiggerThanZero(nummer67); OnPropertyChanged(); }

        }

        private int nummer68;
        public int Nummer68
        {
            get { return nummer68; }
            set { nummer68 = sudoku.EvaluateNumber(value); TextColor68 = BiggerThanZero(nummer68); OnPropertyChanged(); }

        }

        private int nummer69;
        public int Nummer69
        {
            get { return nummer69; }
            set { nummer69 = sudoku.EvaluateNumber(value); TextColor69 = BiggerThanZero(nummer69); OnPropertyChanged(); }

        }

        private int nummer70;
        public int Nummer70
        {
            get { return nummer70; }
            set { nummer70 = sudoku.EvaluateNumber(value); TextColor70 = BiggerThanZero(nummer70); OnPropertyChanged(); }

        }

        private int nummer71;
        public int Nummer71
        {
            get { return nummer71; }
            set { nummer71 = sudoku.EvaluateNumber(value); TextColor71 = BiggerThanZero(nummer71); OnPropertyChanged(); }

        }

        private int nummer72;
        public int Nummer72
        {
            get { return nummer72; }
            set { nummer72 = sudoku.EvaluateNumber(value); TextColor72 = BiggerThanZero(nummer72); OnPropertyChanged(); }

        }

        private int nummer73;
        public int Nummer73
        {
            get { return nummer73; }
            set { nummer73 = sudoku.EvaluateNumber(value); TextColor73 = BiggerThanZero(nummer73); OnPropertyChanged(); }

        }

        private int nummer74;
        public int Nummer74
        {
            get { return nummer74; }
            set { nummer74 = sudoku.EvaluateNumber(value); TextColor74 = BiggerThanZero(nummer74); OnPropertyChanged(); }

        }

        private int nummer75;
        public int Nummer75
        {
            get { return nummer75; }
            set { nummer75 = sudoku.EvaluateNumber(value); TextColor75 = BiggerThanZero(nummer75); OnPropertyChanged(); }

        }

        private int nummer76;
        public int Nummer76
        {
            get { return nummer76; }
            set { nummer76 = sudoku.EvaluateNumber(value); TextColor76 = BiggerThanZero(nummer76); OnPropertyChanged(); }

        }

        private int nummer77;
        public int Nummer77
        {
            get { return nummer77; }
            set { nummer77 = sudoku.EvaluateNumber(value); TextColor77 = BiggerThanZero(nummer77); OnPropertyChanged(); }

        }

        private int nummer78;
        public int Nummer78
        {
            get { return nummer78; }
            set { nummer78 = sudoku.EvaluateNumber(value); TextColor78 = BiggerThanZero(nummer78); OnPropertyChanged(); }

        }

        private int nummer79;
        public int Nummer79
        {
            get { return nummer79; }
            set { nummer79 = sudoku.EvaluateNumber(value); TextColor79 = BiggerThanZero(nummer79); OnPropertyChanged(); }

        }

        private int nummer80;
        public int Nummer80
        {
            get { return nummer80; }
            set { nummer80 = sudoku.EvaluateNumber(value); TextColor80 = BiggerThanZero(nummer80); OnPropertyChanged(); }

        }

        private int nummer81;
        public int Nummer81
        {
            get { return nummer81; }
            set { nummer81 = sudoku.EvaluateNumber(value); TextColor81 = BiggerThanZero(nummer81); OnPropertyChanged(); }

        }

        private string textColor1;
        public string TextColor1
        {
            get { return textColor1; }
            set { textColor1 = value; OnPropertyChanged(); }

        }

        private string textColor2;
        public string TextColor2
        {
            get { return textColor2; }
            set { textColor2 = value; OnPropertyChanged(); }

        }

        private string textColor3;
        public string TextColor3
        {
            get { return textColor3; }
            set { textColor3 = value; OnPropertyChanged(); }

        }

        private string textColor4;
        public string TextColor4
        {
            get { return textColor4; }
            set { textColor4 = value; OnPropertyChanged(); }

        }

        private string textColor5;
        public string TextColor5
        {
            get { return textColor5; }
            set { textColor5 = value; OnPropertyChanged(); }

        }

        private string textColor6;
        public string TextColor6
        {
            get { return textColor6; }
            set { textColor6 = value; OnPropertyChanged(); }

        }

        private string textColor7;
        public string TextColor7
        {
            get { return textColor7; }
            set { textColor7 = value; OnPropertyChanged(); }

        }

        private string textColor8;
        public string TextColor8
        {
            get { return textColor8; }
            set { textColor8 = value; OnPropertyChanged(); }

        }

        private string textColor9;
        public string TextColor9
        {
            get { return textColor9; }
            set { textColor9 = value; OnPropertyChanged(); }

        }

        private string textColor10;
        public string TextColor10
        {
            get { return textColor10; }
            set { textColor10 = value; OnPropertyChanged(); }

        }

        private string textColor11;
        public string TextColor11
        {
            get { return textColor11; }
            set { textColor11 = value; OnPropertyChanged(); }

        }

        private string textColor12;
        public string TextColor12
        {
            get { return textColor12; }
            set { textColor12 = value; OnPropertyChanged(); }

        }

        private string textColor13;
        public string TextColor13
        {
            get { return textColor13; }
            set { textColor13 = value; OnPropertyChanged(); }

        }

        private string textColor14;
        public string TextColor14
        {
            get { return textColor14; }
            set { textColor14 = value; OnPropertyChanged(); }

        }

        private string textColor15;
        public string TextColor15
        {
            get { return textColor15; }
            set { textColor15 = value; OnPropertyChanged(); }

        }

        private string textColor16;
        public string TextColor16
        {
            get { return textColor16; }
            set { textColor16 = value; OnPropertyChanged(); }

        }

        private string textColor17;
        public string TextColor17
        {
            get { return textColor17; }
            set { textColor17 = value; OnPropertyChanged(); }

        }

        private string textColor18;
        public string TextColor18
        {
            get { return textColor18; }
            set { textColor18 = value; OnPropertyChanged(); }

        }

        private string textColor19;
        public string TextColor19
        {
            get { return textColor19; }
            set { textColor19 = value; OnPropertyChanged(); }

        }

        private string textColor20;
        public string TextColor20
        {
            get { return textColor20; }
            set { textColor20 = value; OnPropertyChanged(); }

        }

        private string textColor21;
        public string TextColor21
        {
            get { return textColor21; }
            set { textColor21 = value; OnPropertyChanged(); }

        }

        private string textColor22;
        public string TextColor22
        {
            get { return textColor22; }
            set { textColor22 = value; OnPropertyChanged(); }

        }

        private string textColor23;
        public string TextColor23
        {
            get { return textColor23; }
            set { textColor23 = value; OnPropertyChanged(); }

        }

        private string textColor24;
        public string TextColor24
        {
            get { return textColor24; }
            set { textColor24 = value; OnPropertyChanged(); }

        }

        private string textColor25;
        public string TextColor25
        {
            get { return textColor25; }
            set { textColor25 = value; OnPropertyChanged(); }

        }

        private string textColor26;
        public string TextColor26
        {
            get { return textColor26; }
            set { textColor26 = value; OnPropertyChanged(); }

        }

        private string textColor27;
        public string TextColor27
        {
            get { return textColor27; }
            set { textColor27 = value; OnPropertyChanged(); }

        }

        private string textColor28;
        public string TextColor28
        {
            get { return textColor28; }
            set { textColor28 = value; OnPropertyChanged(); }

        }

        private string textColor29;
        public string TextColor29
        {
            get { return textColor29; }
            set { textColor29 = value; OnPropertyChanged(); }

        }

        private string textColor30;
        public string TextColor30
        {
            get { return textColor30; }
            set { textColor30 = value; OnPropertyChanged(); }

        }

        private string textColor31;
        public string TextColor31
        {
            get { return textColor31; }
            set { textColor31 = value; OnPropertyChanged(); }

        }
        private string textColor32;
        public string TextColor32
        {
            get { return textColor32; }
            set { textColor32 = value; OnPropertyChanged(); }

        }
        private string textColor33;
        public string TextColor33
        {
            get { return textColor33; }
            set { textColor33 = value; OnPropertyChanged(); }

        }
        private string textColor34;
        public string TextColor34
        {
            get { return textColor34; }
            set { textColor34 = value; OnPropertyChanged(); }

        }
        private string textColor35;
        public string TextColor35
        {
            get { return textColor35; }
            set { textColor35 = value; OnPropertyChanged(); }

        }
        private string textColor36;
        public string TextColor36
        {
            get { return textColor36; }
            set { textColor36 = value; OnPropertyChanged(); }

        }
        private string textColor37;
        public string TextColor37
        {
            get { return textColor37; }
            set { textColor37 = value; OnPropertyChanged(); }

        }
        private string textColor38;
        public string TextColor38
        {
            get { return textColor38; }
            set { textColor38 = value; OnPropertyChanged(); }

        }
        private string textColor39;
        public string TextColor39
        {
            get { return textColor39; }
            set { textColor39 = value; OnPropertyChanged(); }

        }
        private string textColor40;
        public string TextColor40
        {
            get { return textColor40; }
            set { textColor40 = value; OnPropertyChanged(); }

        }
        private string textColor41;
        public string TextColor41
        {
            get { return textColor41; }
            set { textColor41 = value; OnPropertyChanged(); }

        }
        private string textColor42;
        public string TextColor42
        {
            get { return textColor42; }
            set { textColor42 = value; OnPropertyChanged(); }

        }
        private string textColor43;
        public string TextColor43
        {
            get { return textColor43; }
            set { textColor43 = value; OnPropertyChanged(); }

        }
        private string textColor44;
        public string TextColor44
        {
            get { return textColor44; }
            set { textColor44 = value; OnPropertyChanged(); }

        }
        private string textColor45;
        public string TextColor45
        {
            get { return textColor45; }
            set { textColor45 = value; OnPropertyChanged(); }

        }
        private string textColor46;
        public string TextColor46
        {
            get { return textColor46; }
            set { textColor46 = value; OnPropertyChanged(); }

        }
        private string textColor47;
        public string TextColor47
        {
            get { return textColor47; }
            set { textColor47 = value; OnPropertyChanged(); }

        }
        private string textColor48;
        public string TextColor48
        {
            get { return textColor48; }
            set { textColor48 = value; OnPropertyChanged(); }

        }
        private string textColor49;
        public string TextColor49
        {
            get { return textColor49; }
            set { textColor49 = value; OnPropertyChanged(); }

        }
        private string textColor50;
        public string TextColor50
        {
            get { return textColor50; }
            set { textColor50 = value; OnPropertyChanged(); }

        }
        private string textColor51;
        public string TextColor51
        {
            get { return textColor51; }
            set { textColor51 = value; OnPropertyChanged(); }

        }
        private string textColor52;
        public string TextColor52
        {
            get { return textColor52; }
            set { textColor52 = value; OnPropertyChanged(); }

        }
        private string textColor53;
        public string TextColor53
        {
            get { return textColor53; }
            set { textColor53 = value; OnPropertyChanged(); }

        }
        private string textColor54;
        public string TextColor54
        {
            get { return textColor54; }
            set { textColor54 = value; OnPropertyChanged(); }

        }
        private string textColor55;
        public string TextColor55
        {
            get { return textColor55; }
            set { textColor55 = value; OnPropertyChanged(); }

        }
        private string textColor56;
        public string TextColor56
        {
            get { return textColor56; }
            set { textColor56 = value; OnPropertyChanged(); }

        }
        private string textColor57;
        public string TextColor57
        {
            get { return textColor57; }
            set { textColor57 = value; OnPropertyChanged(); }

        }
        private string textColor58;
        public string TextColor58
        {
            get { return textColor58; }
            set { textColor58 = value; OnPropertyChanged(); }

        }
        private string textColor59;
        public string TextColor59
        {
            get { return textColor59; }
            set { textColor59 = value; OnPropertyChanged(); }

        }
        private string textColor60;
        public string TextColor60
        {
            get { return textColor60; }
            set { textColor60 = value; OnPropertyChanged(); }

        }
        private string textColor61;
        public string TextColor61
        {
            get { return textColor61; }
            set { textColor61 = value; OnPropertyChanged(); }

        }
        private string textColor62;
        public string TextColor62
        {
            get { return textColor62; }
            set { textColor62 = value; OnPropertyChanged(); }

        }
        private string textColor63;
        public string TextColor63
        {
            get { return textColor63; }
            set { textColor63 = value; OnPropertyChanged(); }

        }
        private string textColor64;
        public string TextColor64
        {
            get { return textColor64; }
            set { textColor64 = value; OnPropertyChanged(); }

        }
        private string textColor65;
        public string TextColor65
        {
            get { return textColor65; }
            set { textColor65 = value; OnPropertyChanged(); }

        }
        private string textColor66;
        public string TextColor66
        {
            get { return textColor66; }
            set { textColor66 = value; OnPropertyChanged(); }

        }
        private string textColor67;
        public string TextColor67
        {
            get { return textColor67; }
            set { textColor67 = value; OnPropertyChanged(); }

        }
        private string textColor68;
        public string TextColor68
        {
            get { return textColor68; }
            set { textColor68 = value; OnPropertyChanged(); }

        }
        private string textColor69;
        public string TextColor69
        {
            get { return textColor69; }
            set { textColor69 = value; OnPropertyChanged(); }

        }
        private string textColor70;
        public string TextColor70
        {
            get { return textColor70; }
            set { textColor70 = value; OnPropertyChanged(); }

        }
        private string textColor71;
        public string TextColor71
        {
            get { return textColor71; }
            set { textColor71 = value; OnPropertyChanged(); }

        }
        private string textColor72;
        public string TextColor72
        {
            get { return textColor72; }
            set { textColor72 = value; OnPropertyChanged(); }

        }
        private string textColor73;
        public string TextColor73
        {
            get { return textColor73; }
            set { textColor73 = value; OnPropertyChanged(); }

        }
        private string textColor74;
        public string TextColor74
        {
            get { return textColor74; }
            set { textColor74 = value; OnPropertyChanged(); }

        }
        private string textColor75;
        public string TextColor75
        {
            get { return textColor75; }
            set { textColor75 = value; OnPropertyChanged(); }

        }
        private string textColor76;
        public string TextColor76
        {
            get { return textColor76; }
            set { textColor76 = value; OnPropertyChanged(); }


        }
        private string textColor77;
        public string TextColor77
        {
            get { return textColor77; }
            set { textColor77 = value; OnPropertyChanged(); }

        }
        private string textColor78;
        public string TextColor78
        {
            get { return textColor78; }
            set { textColor78 = value; OnPropertyChanged(); }

        }
        private string textColor79;
        public string TextColor79
        {
            get { return textColor79; }
            set { textColor79 = value; OnPropertyChanged(); }

        }
        private string textColor80;
        public string TextColor80
        {
            get { return textColor80; }
            set { textColor80 = value; OnPropertyChanged(); }

        }
        private string textColor81;
        public string TextColor81
        {
            get { return textColor81; }
            set { textColor81 = value; OnPropertyChanged(); }

        }

        private bool readOnly1;
        public bool ReadOnly1
        {
            get { return readOnly1; }
            set { readOnly1 = value; OnPropertyChanged(); }

        }
        private bool readOnly2;
        public bool ReadOnly2
        {
            get { return readOnly2; }
            set { readOnly2 = value; OnPropertyChanged(); }

        }
        private bool readOnly3;
        public bool ReadOnly3
        {
            get { return readOnly3; }
            set { readOnly3 = value; OnPropertyChanged(); }

        }

        private bool readOnly4;
        public bool ReadOnly4
        {
            get { return readOnly4; }
            set { readOnly4 = value; OnPropertyChanged(); }

        }
        private bool readOnly5;
        public bool ReadOnly5
        {
            get { return readOnly5; }
            set { readOnly5 = value; OnPropertyChanged(); }

        }
        private bool readOnly6;
        public bool ReadOnly6
        {
            get { return readOnly6; }
            set { readOnly6 = value; OnPropertyChanged(); }

        }

        private bool readOnly7;
        public bool ReadOnly7
        {
            get { return readOnly7; }
            set { readOnly7 = value; OnPropertyChanged(); }

        }
        private bool readOnly8;
        public bool ReadOnly8
        {
            get { return readOnly8; }
            set { readOnly8 = value; OnPropertyChanged(); }

        }
        private bool readOnly9;
        public bool ReadOnly9
        {
            get { return readOnly9; }
            set { readOnly9 = value; OnPropertyChanged(); }

        }
        private bool readOnly10;
        public bool ReadOnly10
        {
            get { return readOnly10; }
            set { readOnly10 = value; OnPropertyChanged(); }

        }
        private bool readOnly11;
        public bool ReadOnly11
        {
            get { return readOnly11; }
            set { readOnly11 = value; OnPropertyChanged(); }

        }
        private bool readOnly12;
        public bool ReadOnly12
        {
            get { return readOnly12; }
            set { readOnly12 = value; OnPropertyChanged(); }

        }
        private bool readOnly13;
        public bool ReadOnly13
        {
            get { return readOnly13; }
            set { readOnly13 = value; OnPropertyChanged(); }

        }
        private bool readOnly14;
        public bool ReadOnly14
        {
            get { return readOnly14; }
            set { readOnly14 = value; OnPropertyChanged(); }

        }
        private bool readOnly15;
        public bool ReadOnly15
        {
            get { return readOnly15; }
            set { readOnly15 = value; OnPropertyChanged(); }

        }
        private bool readOnly16;
        public bool ReadOnly16
        {
            get { return readOnly16; }
            set { readOnly16 = value; OnPropertyChanged(); }

        }
        private bool readOnly17;
        public bool ReadOnly17
        {
            get { return readOnly17; }
            set { readOnly17 = value; OnPropertyChanged(); }

        }
        private bool readOnly18;
        public bool ReadOnly18
        {
            get { return readOnly18; }
            set { readOnly18 = value; OnPropertyChanged(); }

        }
        private bool readOnly19;
        public bool ReadOnly19
        {
            get { return readOnly19; }
            set { readOnly19 = value; OnPropertyChanged(); }

        }
        private bool readOnly20;
        public bool ReadOnly20
        {
            get { return readOnly20; }
            set { readOnly20 = value; OnPropertyChanged(); }

        }
        private bool readOnly21;
        public bool ReadOnly21
        {
            get { return readOnly21; }
            set { readOnly21 = value; OnPropertyChanged(); }

        }
        private bool readOnly22;
        public bool ReadOnly22
        {
            get { return readOnly22; }
            set { readOnly22 = value; OnPropertyChanged(); }

        }
        private bool readOnly23;
        public bool ReadOnly23
        {
            get { return readOnly23; }
            set { readOnly23 = value; OnPropertyChanged(); }

        }

        private bool readOnly24;
        public bool ReadOnly24
        {
            get { return readOnly24; }
            set { readOnly24 = value; OnPropertyChanged(); }

        }
        private bool readOnly25;
        public bool ReadOnly25
        {
            get { return readOnly25; }
            set { readOnly25 = value; OnPropertyChanged(); }

        }
        private bool readOnly26;
        public bool ReadOnly26
        {
            get { return readOnly26; }
            set { readOnly26 = value; OnPropertyChanged(); }

        }
        private bool readOnly27;
        public bool ReadOnly27
        {
            get { return readOnly27; }
            set { readOnly27 = value; OnPropertyChanged(); }

        }
        private bool readOnly28;
        public bool ReadOnly28
        {
            get { return readOnly28; }
            set { readOnly28 = value; OnPropertyChanged(); }

        }
        private bool readOnly29;
        public bool ReadOnly29
        {
            get { return readOnly29; }
            set { readOnly29 = value; OnPropertyChanged(); }

        }
        private bool readOnly30;
        public bool ReadOnly30
        {
            get { return readOnly30; }
            set { readOnly30 = value; OnPropertyChanged(); }

        }
        private bool readOnly31;
        public bool ReadOnly31
        {
            get { return readOnly31; }
            set { readOnly31 = value; OnPropertyChanged(); }

        }

        private bool readOnly32;
        public bool ReadOnly32
        {
            get { return readOnly32; }
            set { readOnly32 = value; OnPropertyChanged(); }

        }
        private bool readOnly33;
        public bool ReadOnly33
        {
            get { return readOnly33; }
            set { readOnly33 = value; OnPropertyChanged(); }

        }
        private bool readOnly34;
        public bool ReadOnly34
        {
            get { return readOnly34; }
            set { readOnly34 = value; OnPropertyChanged(); }

        }
        private bool readOnly35;
        public bool ReadOnly35
        {
            get { return readOnly35; }
            set { readOnly35 = value; OnPropertyChanged(); }

        }
        private bool readOnly36;
        public bool ReadOnly36
        {
            get { return readOnly36; }
            set { readOnly36 = value; OnPropertyChanged(); }

        }
        private bool readOnly37;
        public bool ReadOnly37
        {
            get { return readOnly37; }
            set { readOnly37 = value; OnPropertyChanged(); }

        }
        private bool readOnly38;
        public bool ReadOnly38
        {
            get { return readOnly38; }
            set { readOnly38 = value; OnPropertyChanged(); }

        }
        private bool readOnly39;
        public bool ReadOnly39
        {
            get { return readOnly39; }
            set { readOnly39 = value; OnPropertyChanged(); }

        }
        private bool readOnly40;
        public bool ReadOnly40
        {
            get { return readOnly40; }
            set { readOnly40 = value; OnPropertyChanged(); }

        }
        private bool readOnly41;
        public bool ReadOnly41
        {
            get { return readOnly41; }
            set { readOnly41 = value; OnPropertyChanged(); }

        }
        private bool readOnly42;
        public bool ReadOnly42
        {
            get { return readOnly42; }
            set { readOnly42 = value; OnPropertyChanged(); }

        }
        private bool readOnly43;
        public bool ReadOnly43
        {
            get { return readOnly43; }
            set { readOnly43 = value; OnPropertyChanged(); }

        }

        private bool readOnly44;
        public bool ReadOnly44
        {
            get { return readOnly44; }
            set { readOnly44 = value; OnPropertyChanged(); }

        }
        private bool readOnly45;
        public bool ReadOnly45
        {
            get { return readOnly45; }
            set { readOnly45 = value; OnPropertyChanged(); }

        }
        private bool readOnly46;
        public bool ReadOnly46
        {
            get { return readOnly46; }
            set { readOnly46 = value; OnPropertyChanged(); }

        }
        private bool readOnly47;
        public bool ReadOnly47
        {
            get { return readOnly47; }
            set { readOnly47 = value; OnPropertyChanged(); }

        }
        private bool readOnly48;
        public bool ReadOnly48
        {
            get { return readOnly48; }
            set { readOnly48 = value; OnPropertyChanged(); }

        }
        private bool readOnly49;
        public bool ReadOnly49
        {
            get { return readOnly49; }
            set { readOnly49 = value; OnPropertyChanged(); }

        }
        private bool readOnly50;
        public bool ReadOnly50
        {
            get { return readOnly50; }
            set { readOnly50 = value; OnPropertyChanged(); }

        }
        private bool readOnly51;
        public bool ReadOnly51
        {
            get { return readOnly51; }
            set { readOnly51 = value; OnPropertyChanged(); }

        }
        private bool readOnly52;
        public bool ReadOnly52
        {
            get { return readOnly52; }
            set { readOnly52 = value; OnPropertyChanged(); }

        }
        private bool readOnly53;
        public bool ReadOnly53
        {
            get { return readOnly53; }
            set { readOnly53 = value; OnPropertyChanged(); }

        }
        private bool readOnly54;
        public bool ReadOnly54
        {
            get { return readOnly54; }
            set { readOnly54 = value; OnPropertyChanged(); }

        }
        private bool readOnly55;
        public bool ReadOnly55
        {
            get { return readOnly55; }
            set { readOnly55 = value; OnPropertyChanged(); }

        }
        private bool readOnly56;
        public bool ReadOnly56
        {
            get { return readOnly56; }
            set { readOnly56 = value; OnPropertyChanged(); }

        }
        private bool readOnly57;
        public bool ReadOnly57
        {
            get { return readOnly57; }
            set { readOnly57 = value; OnPropertyChanged(); }

        }
        private bool readOnly58;
        public bool ReadOnly58
        {
            get { return readOnly58; }
            set { readOnly58 = value; OnPropertyChanged(); }

        }
        private bool readOnly59;
        public bool ReadOnly59
        {
            get { return readOnly59; }
            set { readOnly59 = value; OnPropertyChanged(); }

        }

        private bool readOnly60;
        public bool ReadOnly60
        {
            get { return readOnly60; }
            set { readOnly60 = value; OnPropertyChanged(); }

        }
        private bool readOnly61;
        public bool ReadOnly61
        {
            get { return readOnly61; }
            set { readOnly61 = value; OnPropertyChanged(); }

        }

        private bool readOnly62;
        public bool ReadOnly62
        {
            get { return readOnly62; }
            set { readOnly62 = value; OnPropertyChanged(); }

        }

        private bool readOnly63;
        public bool ReadOnly63
        {
            get { return readOnly63; }
            set { readOnly63 = value; OnPropertyChanged(); }

        }
        private bool readOnly64;
        public bool ReadOnly64
        {
            get { return readOnly64; }
            set { readOnly64 = value; OnPropertyChanged(); }

        }
        private bool readOnly65;
        public bool ReadOnly65
        {
            get { return readOnly65; }
            set { readOnly65 = value; OnPropertyChanged(); }

        }
        private bool readOnly66;
        public bool ReadOnly66
        {
            get { return readOnly66; }
            set { readOnly66 = value; OnPropertyChanged(); }

        }
        private bool readOnly67;
        public bool ReadOnly67
        {
            get { return readOnly67; }
            set { readOnly67 = value; OnPropertyChanged(); }

        }
        private bool readOnly68;
        public bool ReadOnly68
        {
            get { return readOnly68; }
            set { readOnly68 = value; OnPropertyChanged(); }

        }
        private bool readOnly69;
        public bool ReadOnly69
        {
            get { return readOnly69; }
            set { readOnly69 = value; OnPropertyChanged(); }

        }
        private bool readOnly70;
        public bool ReadOnly70
        {
            get { return readOnly70; }
            set { readOnly70 = value; OnPropertyChanged(); }

        }
        private bool readOnly71;
        public bool ReadOnly71
        {
            get { return readOnly71; }
            set { readOnly71 = value; OnPropertyChanged(); }

        }
        private bool readOnly72;
        public bool ReadOnly72
        {
            get { return readOnly72; }
            set { readOnly72 = value; OnPropertyChanged(); }

        }
        private bool readOnly73;
        public bool ReadOnly73
        {
            get { return readOnly73; }
            set { readOnly73 = value; OnPropertyChanged(); }

        }
        private bool readOnly74;
        public bool ReadOnly74
        {
            get { return readOnly74; }
            set { readOnly74 = value; OnPropertyChanged(); }

        }
        private bool readOnly75;
        public bool ReadOnly75
        {
            get { return readOnly75; }
            set { readOnly75 = value; OnPropertyChanged(); }

        }
        private bool readOnly76;
        public bool ReadOnly76
        {
            get { return readOnly76; }
            set { readOnly76 = value; OnPropertyChanged(); }

        }
        private bool readOnly77;
        public bool ReadOnly77
        {
            get { return readOnly77; }
            set { readOnly77 = value; OnPropertyChanged(); }

        }
        private bool readOnly78;
        public bool ReadOnly78
        {
            get { return readOnly78; }
            set { readOnly78 = value; OnPropertyChanged(); }

        }
        private bool readOnly79;
        public bool ReadOnly79
        {
            get { return readOnly79; }
            set { readOnly79 = value; OnPropertyChanged(); }

        }
        private bool readOnly80;
        public bool ReadOnly80
        {
            get { return readOnly80; }
            set { readOnly80 = value; OnPropertyChanged(); }

        }
        private bool readOnly81;
        public bool ReadOnly81
        {
            get { return readOnly81; }
            set { readOnly81 = value; OnPropertyChanged(); }

        }


    }


}
