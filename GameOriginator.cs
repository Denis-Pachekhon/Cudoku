using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _.Net_Laba3
{
    class GameOriginator
    {
        public GameOriginator()
        {
            this.sudokuGrid = new SudokuGrid(digitFactory);
            map_state = sudokuGrid.GetMap();
        }
        private DigitFactory digitFactory = new DigitFactory();
        private SudokuGrid sudokuGrid;
        private Cell[,] map_state;
        public void Play()
        {
            Console.WriteLine(sudokuGrid.Display());
            map_state[0, 0] = sudokuGrid.AddCell(digitFactory, 5, 0, 0);
            Console.WriteLine(sudokuGrid.Display());
        }
        public void Play1()
        {
            Console.WriteLine(sudokuGrid.Display());
         
           
        }
        public GameMemento GameSave()
        {
            return new GameMemento(map_state);
        }
        public void LoadGame(GameMemento memento)
        {
            map_state = memento.GetState();
        }
    }
}
