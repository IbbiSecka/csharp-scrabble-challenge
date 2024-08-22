using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_scrabble_challenge.Main
{
    public class Letters
    {
        public static Dictionary<char, int> getPair() { 
            Dictionary<char,int> letters = new Dictionary<char, int>();
            letters.Add('A', 1);
            letters.Add('E', 1);
            letters.Add('I', 1);
            letters.Add('O', 1);
            letters.Add('U', 1);
            letters.Add('L', 1);
            letters.Add('N', 1);
            letters.Add('R', 1);
            letters.Add('S', 1);
            letters.Add('T', 1);

            letters.Add('D', 2);
            letters.Add('G', 2);

            letters.Add('B', 3);
            letters.Add('C', 3);
            letters.Add('M', 3);
            letters.Add('P', 3);

            letters.Add('F', 4);
            letters.Add('H', 4);
            letters.Add('V', 4);
            letters.Add('W', 4);
            letters.Add('Y', 4);

            letters.Add('K', 5);

            letters.Add('J', 8);
            letters.Add('X', 8);

            letters.Add('Q', 10);
            letters.Add('Z', 10);

            return letters;

        }


    }
}
