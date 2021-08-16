using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WordGuessGame
{
    class HintDecision
    {
        public static void OpenLastLetter(string correctAnswer)
        {
            Console.WriteLine("Enter the letter,please...");
            char[] charArr = correctAnswer.ToCharArray();
            Console.WriteLine("Last letter is: " + charArr[charArr.Length-1]);
            Console.WriteLine("");
            Collections.hintList.ElementAt(2).IsUsed = true;
            MenuNavigator.MenuNavigate(correctAnswer);
        }

        public static void AmountOfThisLetter(string correctAnswer)
        {
            Console.WriteLine("Enter the letter,please...");

            List<char> charList = new List<char>();
            charList.AddRange(correctAnswer.ToCharArray());
            char letter = (char)Console.Read();
            int amount = charList.Count(x => x.Equals(letter));
            Console.WriteLine("There are "+ amount + " letters " + letter);
            Console.WriteLine("");
            Collections.hintList.ElementAt(1).IsUsed = true;
            MenuNavigator.MenuNavigate(correctAnswer);

        }

        public static void LengthOfWord(string correctAnswer)
        {
            Console.WriteLine(correctAnswer.Length);
            Console.WriteLine("");
            Collections.hintList.ElementAt(0).IsUsed = true;
            MenuNavigator.MenuNavigate(correctAnswer);
        }
        public static void OpenFirstLetter(string correctAnswer)
        {
            Console.WriteLine("First letter is: " + correctAnswer.Substring(0, 1));
            Console.WriteLine("");
            Collections.hintList.ElementAt(3).IsUsed = true;
            MenuNavigator.MenuNavigate(correctAnswer);
        }
        public static void OpenRandomLetter(string correctAnswer)
        {
            var rand = new Random();
            char[] charArray = correctAnswer.ToCharArray();
            var randomNum = rand.Next(0, charArray.Length-1);
            char randomChar = charArray[randomNum];
            Console.WriteLine("Opened letter: " + randomChar);
            Console.WriteLine("");
            Collections.hintList.ElementAt(4).IsUsed = true;
            MenuNavigator.MenuNavigate(correctAnswer);
        }

    }
}
