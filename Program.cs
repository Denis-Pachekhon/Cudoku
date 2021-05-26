using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _.Net_Laba3
{
    class Program
    {
        static void Main(string[] args)
        {
            Caretaker caretaker = new Caretaker();
            caretaker.SaveGameState();
            caretaker.Play();
            caretaker.LoadGameState();
            caretaker.Play1();
        }
    }
}
