using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace task_DEV_2
{
    class ChangingSymbols
    {
        private string signs = "ьъ";
        private string vowels = "аеёиоуыэюя";
        private string consonants = "бвгджзйклмнпрстфхцчшщ";
        private string voicedConsonants = "бвзгдж";
        private string voicelessConsonants = "пфсктш";
        private string hissingConsonants = "жш";
        private string stress = "+";

        public string ChangingLetterType(char letter)
        {
            if (signs.Contains(letter))
            {
                return "sign";
            }
            else if (vowels.Contains(letter))
            {
                return "vowel";
            }

            else if (voicedConsonants.Contains(letter))
            {
                if (hissingConsonants.Contains(letter))
                {
                    return "voiced hissing consonant";

                }
                else return "voiced consonant";

            }
            
            else if (voicelessConsonants.Contains(letter))

            { if (hissingConsonants.Contains(letter))
                {
                    return "voiceless hissing consonant";
                }
                else return "voiceless consonant";

            }
            else if (consonants.Contains(letter))
            {
                return "consonant";

            }
            else if (stress.Contains(letter))
            {
                return "stress";

            }
            else return "undefined";
        }    

    }
    
}
