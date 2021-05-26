using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Security.Cryptography;

namespace _.Net_Laba3
{
    public class SudokuGrid
    {
        private const int BLOCK_SIZE = 3;
        //private Collection<Cell> cellss = new Collection<Cell>();
        private GridContext gridContext = new GridContext();
        private Cell[,] map = new Cell[BLOCK_SIZE * BLOCK_SIZE, BLOCK_SIZE * BLOCK_SIZE];

        public Cell[,] GetMap()
        {
            if(map == null)
            {
                throw new Exception("Карта не сформована");
            }
            return map;
        }
        public Cell AddCell(DigitFactory digitFactory, int value, int i, int j)
        {
            Cell cell = new Cell(digitFactory[value]);
            cell.Row = i;
            cell.Column = j;
            return cell;
        }
        public SudokuGrid(DigitFactory digitFactory)
        {
            
            for (int i = 0; i < BLOCK_SIZE * BLOCK_SIZE; i++)
            {
                for (int j = 0; j < BLOCK_SIZE * BLOCK_SIZE; j++)
                {
                    int value = (i * BLOCK_SIZE + i / BLOCK_SIZE + j) % (BLOCK_SIZE * BLOCK_SIZE) + 1;
                    map[i, j] = AddCell(digitFactory, value, i, j);
                }
            }
            Transposition();
            HideCells(20, digitFactory);
        }
        private void Transposition()
        {
            Cell[,] tmap = new Cell[BLOCK_SIZE * BLOCK_SIZE, BLOCK_SIZE * BLOCK_SIZE]; 
            for (int i = 0; i < BLOCK_SIZE * BLOCK_SIZE; i++)
            {
                for (int j = 0; j < BLOCK_SIZE * BLOCK_SIZE; j++)
                {
                    tmap[i, j] = map[i, j];
                    tmap[i, j].Row = j;
                    tmap[i, j].Column = i;
                    tmap[i, j] = map[j, i];
                    
                }
            }
            map = tmap;
            
        }
        
        private void HideCells(int countHideCells, DigitFactory digitFactory)
        {
            Random random = new Random();
            while(countHideCells > 0)
            {
                for (int i = 0; i < BLOCK_SIZE * BLOCK_SIZE; i++)
                {
                    for (int j = 0; j < BLOCK_SIZE * BLOCK_SIZE; j++)
                    {
                        int value = random.Next(0, 3);
                        if(value == 0)
                        {
                            map[i, j] = AddCell(digitFactory, value, i, j);
                            countHideCells--;
                        }
                        
                    }
                }
            }
        }
        //public string Display()
        //{
        //    string result = String.Empty;
        //    foreach (Cell cell in map)
        //    {
        //        Digit digit = cell.Digit;
        //        gridContext.Row = cell.Row;
        //        gridContext.Column = cell.Column;
        //        result += digit.Display(gridContext);
        //    }
        //    return result;
        //}
        //public string Display()
        //{
        //    int count = 0;
        //    string result = String.Empty;
        //    foreach (Cell cell in map)
        //    {
        //        Digit digit = cell.Digit;
        //        result += digit.Display();
        //        count++;
        //        if (count == 9)
        //        {
        //            result += "\n";
        //            count = 0;
        //        }

        //    }
        //    return result;
        //}
    }
}