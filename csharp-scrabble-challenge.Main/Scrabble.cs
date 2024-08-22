using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace csharp_scrabble_challenge.Main
{
    public class Scrabble

    {
        public string word;
        public Dictionary<char, int> letterScore;
        public Scrabble(string word)
        {            
            //TODO: do something with the word variable
            word = word.ToLower();
            

        }

        public int score()
        {
            int totalScore = 0;
            //TODO: score calculation code goes here
            int score = 0;

            var charArray = word.ToCharArray(); //Populate charArray with word split up

            charArray.ToList().ForEach(x =>
            {
                int score = letterScore[Char.ToLower(x)];
                totalScore = totalScore + score;
            }); // Adding together each letter's score, populating it in the totalscore variable
            Console.WriteLine(totalScore);
            return totalScore;
        }
    }
}
