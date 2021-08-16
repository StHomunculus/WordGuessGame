using System;
using System.Linq;
namespace WordGuessGame
{
    class Program
    {
        static void Main(string[] args)
        {

            var a = TopicSelection.ChooseTheTopic();
            Console.WriteLine("This is answer: " + a + "   It's written in order you could check that hints work properly");
            Console.WriteLine("");
            MenuNavigator.MenuNavigate(a);
            

        }
    }
}