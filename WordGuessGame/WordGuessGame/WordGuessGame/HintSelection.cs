using System;
using System.Collections.Generic;
using System.Text;

namespace WordGuessGame
{
    class HintSelection
    {
        public static void HintPrint()
        {
            foreach (var p in Collections.hintList)
            {
                Console.WriteLine(p.ID + ") " + p.Name);
            }
        }
    }
}
