using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WordGuessGame
{
    class MenuNavigator
    {
        public static void MenuNavigate(string answerForGame)
        {
            int userChoice = 0;
            Console.WriteLine("What you want to do?" + System.Environment.NewLine +
                             "1) Guess a letter" + System.Environment.NewLine +
                             "2) Guess whole word" + System.Environment.NewLine +
                             "3) Get a hint" + System.Environment.NewLine +
                             "4) Exit the game" + System.Environment.NewLine);

                while ((userChoice != 1) && (userChoice != 2) && (userChoice != 3) && (userChoice != 4))
                {
                    Int32.TryParse(Console.ReadLine(), out userChoice);
                }


                switch (userChoice)
                {
                    case 1:
                        {
                            DecisionMaker.GuessTheLetter(answerForGame);
                            break;
                        }
                    case 2:
                        {
                            DecisionMaker.GuessWord(answerForGame);
                            break;
                        }
                    case 3:
                        {
                            int choisehint = 0;
                            HintSelection.HintPrint();
                            Console.WriteLine("I choose: ");
                            Int32.TryParse(Console.ReadLine(), out choisehint);
                            switch (choisehint)
                            {
                                case 1:
                                    {
                                    if (Collections.hintList.ElementAt(choisehint - 1).IsUsed == false)
                                    {
                                        HintDecision.LengthOfWord(answerForGame);
                                    }
                                    else
                                    {
                                        Console.WriteLine("Hint is already used");
                                        Console.WriteLine("");
                                        MenuNavigator.MenuNavigate(answerForGame);
                                    }
                                        
                                        break;
                                    }
                                case 2:
                                    {
                                        if (Collections.hintList.ElementAt(choisehint - 1).IsUsed == false)
                                        {
                                            HintDecision.AmountOfThisLetter(answerForGame);
                                        }
                                        else
                                        {
                                            Console.WriteLine("Hint is already used");
                                            Console.WriteLine("");
                                            MenuNavigator.MenuNavigate(answerForGame);
                                        }
                                    break;
                                }
                                case 3:
                                    {
                                        if (Collections.hintList.ElementAt(choisehint - 1).IsUsed == false)
                                        {
                                            HintDecision.OpenLastLetter(answerForGame);
                                        }
                                        else
                                        {
                                            Console.WriteLine("Hint is already used");
                                            Console.WriteLine("");
                                            MenuNavigator.MenuNavigate(answerForGame);
                                        }
                                    break;
                                }
                                case 4:
                                    {
                                        if (Collections.hintList.ElementAt(choisehint - 1).IsUsed == false)
                                        {
                                            HintDecision.OpenFirstLetter(answerForGame);
                                        }
                                        else
                                        {
                                            Console.WriteLine("Hint is already used");
                                            Console.WriteLine("");
                                            MenuNavigator.MenuNavigate(answerForGame);
                                        }
                                    break;
                                }
                                case 5:
                                    {
                                        if (Collections.hintList.ElementAt(choisehint - 1).IsUsed == false)
                                        {
                                            HintDecision.OpenRandomLetter(answerForGame);
                                        }
                                        else
                                        {
                                            Console.WriteLine("Hint is already used");
                                            Console.WriteLine("");
                                            MenuNavigator.MenuNavigate(answerForGame);
                                        }
                                    break;
                                    }
                                default:
                                    break;
                            }
                            break;
                        }
                    case 4:
                        {
                            Exit.ExitTheGameInstantly();
                            break;
                        }
                    default:
                        break;
                }

        }
    }
 }
