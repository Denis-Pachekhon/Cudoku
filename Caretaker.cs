using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _.Net_Laba3
{
    class Caretaker
    {
        
        private readonly GameOriginator game = new GameOriginator();
        private readonly Stack<GameMemento> saves = new Stack<GameMemento>();
        
        public void Play()
        {
            game.Play();
        }
        public void Play1()
        {
            game.Play1();
        }
        public void SaveGameState()
        {
            saves.Push(game.GameSave());
        }
        public void LoadGameState()
        {
            game.LoadGame(saves.Peek());
        }
    }
}
