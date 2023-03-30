using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsAPalindrome(string word)
        {
            #region attempted refactor

            //this didn't end up being CCR, abandoned before complete, but leaving for vis

            //char[] charArray = word.ToCharArray();
            //Array.Reverse(charArray);
            //new string(charArray);
            //var reverse = charArray;
            //bool answer = word == reverse ? true : false;
            #endregion

            //primary logic
            string backwards = "";
            for (int i = word.Length - 1; i >= 0; i--)
            {
                backwards += word[i];
            }
            //return field
            bool answer = word == backwards ? true : false;
            return answer;

            #region old return block
            //ternary easier to manage
            //if (word == backwards)
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}
            #endregion

        }
    }
}
