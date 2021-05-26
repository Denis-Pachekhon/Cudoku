using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _.Net_Laba3
{
    class GameMemento
    {
        private const int BLOCK_SIZE = 3; 
        private Cell[,] map_state = new Cell[BLOCK_SIZE * BLOCK_SIZE, BLOCK_SIZE* BLOCK_SIZE];
        public GameMemento(Cell[,] map_state)
        {
            for (int i = 0; i < BLOCK_SIZE * BLOCK_SIZE; i++)
            {
                for (int j = 0; j < BLOCK_SIZE * BLOCK_SIZE; j++)
                {
                    this.map_state[i, j] = (Cell)map_state[i, j].Clone(); 
                }
            }
            
        }
        public Cell[,] GetState()
        {
            return map_state;
        }
    }
}
