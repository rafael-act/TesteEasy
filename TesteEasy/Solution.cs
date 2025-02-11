using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteEasy
{
    public static class Solution
    {
        public static bool DetectCapitalUse(string word)
        {
            if (word.Length <= 1) return true;
            bool wordUpper = false;
            bool wordLower = false;
            bool wordLowerMiddle = false;

            if (Char.IsLower(word[0]))
            {
                wordLower = true;
            }//end if
            else if (Char.IsUpper(word[0]) && Char.IsLower(word[word.Length - 1]))
            {
                wordLowerMiddle = true;
            }
            else
                wordUpper = true;

            for (int i = 1; i < word.Length; i++)
            {
                if ((wordLowerMiddle || wordLower) && Char.IsUpper(word[i])) return false;

                if (wordUpper && Char.IsLower(word[i])) return false;
            }

            return true;
        }//end DetectCapitalUse
    }


}
