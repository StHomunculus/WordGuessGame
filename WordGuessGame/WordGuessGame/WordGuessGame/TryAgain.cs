using System;
using System.Collections.Generic;
using System.Text;

namespace WordGuessGame
{
    class TryAgain
    {
        public static void NewGame()
        {
            char playerchoise;
            Char.TryParse(Console.ReadLine(), out playerchoise);
            if (playerchoise == 'y')
            {
                var a = TopicSelection.ChooseTheTopic();
                Console.WriteLine(a);
                MenuNavigator.MenuNavigate(a);
            }
            else
            {
                Exit.ExitTheGameInstantly();
            }
        }
    }
}
