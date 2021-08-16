using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WordGuessGame
{
    public class DecisionMaker
    {
        public static void GuessTheLetter(string correctAnswer)
        {
            Console.WriteLine("Enter the letter,please...");
            char letter = (char)Console.Read();
            bool result = correctAnswer.Contains(letter);
            if (result) {
                Console.WriteLine("You are right!");
            }
            Console.WriteLine("");
            MenuNavigator.MenuNavigate(correctAnswer);
        }

        public static void GuessWord(string correctAnswer)
        {
            Console.WriteLine("Enter the word,please...");
            string usersWord = Console.ReadLine();
            bool result = usersWord.Equals(correctAnswer);
            if (result) 
            {
                Console.WriteLine("Congratulations! You guessed the word!" + System.Environment.NewLine +
                    "Start a new game? (y/n)");
                Console.WriteLine("");
                TryAgain.NewGame();
            }
            else
            {
                Console.WriteLine("Wrong! The game is over." + System.Environment.NewLine +
                    "Start a new game? (y/n)");
                Console.WriteLine("");
                TryAgain.NewGame();
            }
        }
    }
}
