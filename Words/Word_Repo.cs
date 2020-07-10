using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Words
{
    public enum WordType { adjetive, emotion, name, ProgramingTopic, food }


    public class Word_Repo
    {
        public string AddWord(string word)
        {
            return word;
        }

        public void questions(WordType word)
        {
            if (word == WordType.adjetive || word == WordType.emotion)
            {
                Console.WriteLine($"Enter an {word}");
            }
            else
            {
                Console.WriteLine($"enter a {word}");
            }

        }

    }
}

    