using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Words;

namespace MadLib_Console
{
   public class ConsoleUI
    {
        protected readonly Word_Repo _Repo = new Word_Repo();

        
        public void MainMenu()
        {
            bool continuetoRun = true;
            while(continuetoRun)
            {
                Console.WriteLine("Welcome to Mad Lib!");

                Console.WriteLine("if you want to quit click Q.");

                Console.WriteLine("Press any key to conitnue.");

                string Userinput = Console.ReadLine();

                if (Userinput == "q")
                {
                    continuetoRun = false;
                }
                else
                {
                    _Repo.questions(WordType.adjetive);
                    string adjetiveOne = Console.ReadLine();

                    _Repo.questions(WordType.emotion);
                     string emotionOne = Console.ReadLine();

                    _Repo.questions(WordType.name);
                    string nameONe = Console.ReadLine();

                    _Repo.questions(WordType.adjetive);
                    string adjetiveTwo = Console.ReadLine();

                    _Repo.questions(WordType.ProgramingTopic);
                    string ProgramTopicOne = Console.ReadLine();

                    _Repo.questions(WordType.adjetive);
                    string adjetiveThree = Console.ReadLine();

                    _Repo.questions(WordType.adjetive);
                    string adjetiveFour= Console.ReadLine();

                    _Repo.questions(WordType.ProgramingTopic);
                    string ProgramingTopicTwo= Console.ReadLine();

                    _Repo.questions(WordType.food);
                    string foodOne = Console.ReadLine();

                    Console.WriteLine($"My first day at Eleven Fifty Academy was {_Repo.AddWord(adjetiveOne)} and I was very {_Repo.AddWord(emotionOne)}_.\n" +
                        $"My instructor’s name was {_Repo.AddWord(nameONe)}they were very {_Repo.AddWord(adjetiveTwo)}.\n" +
                        $"The first thing we learned was {_Repo.AddWord(ProgramTopicOne) } and I thought this topic was{_Repo.AddWord(adjetiveThree)}.\n" +
                        $"My first assignment was very{_Repo.AddWord(adjetiveFour)} and it was over {_Repo.AddWord(ProgramTopicOne)}.\n" +
                        $"It was finally time for lunch, and I had {_Repo.AddWord(foodOne)}to eat.\n");

                    Console.ReadKey();
                    continuetoRun = false;
                }
            }
             
        }
    }
}
