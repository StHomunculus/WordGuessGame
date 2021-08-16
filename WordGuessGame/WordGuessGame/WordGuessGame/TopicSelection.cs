﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace WordGuessGame
{
    class TopicSelection
    {
        public static string ChooseTheTopic()
        {
            int chosenTopic;
            var Topics = new Dictionary<int, string>();
            Topics.Add(1, "Programming");
            Topics.Add(2, "Space");
            Console.WriteLine("What topic you would like to choose?");
            foreach(var item in Topics)
            {
                Console.WriteLine($"{item.Key}) {item.Value}");
            }

            chosenTopic = Convert.ToInt32(Console.ReadLine());
            Random rand = new Random();
            int randomID = rand.Next(1, Collections.programmingList.Count + 1);

            var filteredResult = from s in Collections.programmingList
                                 where s.questionID == randomID
                                 select s.questionAnswer;

            foreach (var i in filteredResult)
            {
            }

            switch (chosenTopic)
            {
                case 1:
                    foreach (var p in Collections.programmingList)
                    {
                        if (p.questionID == randomID)
                        {

                            Console.WriteLine(p.questionMessage);
                            Console.WriteLine("");
                            return p.questionAnswer;
                        }
                    }
                    break;
                case 2:
                    foreach (var p in Collections.sovietSpaceList)
                    {
                        if (p.questionID == randomID)
                        {
                            Console.WriteLine(p.questionMessage);
                            Console.WriteLine("");
                            return p.questionAnswer;
                        }
                    }
                    break;
                default:
                    return "";
            }
            return "";
        }
    }
}
