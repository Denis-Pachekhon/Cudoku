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
        public string Display()
        {
            int count = 0;
            string result = String.Empty;
            foreach (Cell cell in map_state)
            {
                Digit digit = cell.Digit;
                result += digit.Display();
                count++;
                if (count == 9)
                {
                    result += "\n";
                    count = 0;
                }

            }
            return result;
        }
        public void Play()
        {
            Console.WriteLine(Display());
            map_state[0, 0] = sudokuGrid.AddCell(digitFactory, 5, 0, 0);
            Console.WriteLine(Display());
        }
        public void Play1()
        {
            Console.WriteLine(Display());
         
           
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
