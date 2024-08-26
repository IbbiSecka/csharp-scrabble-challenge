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
            word = word.ToUpper();

            letterScore = Letters.getPair();
        }

        public int score()
        {
            if (string.IsNullOrEmpty(word))
            {
                return 0;
            }

            int totalScore = 0;
            

            var charArray = word.ToCharArray(); //Populate charArray with word split up

            foreach (char letter in charArray)
            {
                // Check if the character exists in the dictionary
                if (letterScore.ContainsKey(letter))
                {
                    totalScore += letterScore[letter];
                }
            }
            // Adding together each letter's score, populating it in the totalscore variable
            Console.WriteLine(totalScore);
            return totalScore;
        }
    }
}
