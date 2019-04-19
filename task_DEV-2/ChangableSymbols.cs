using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_DEV_2
{
    public class ChangableSymbols
    {
        private string changable = "оеюяёбвзгджпфсктши";
        private string yoatedVowels = "яеёю";
        private string voicedConsonants = "бвзгдж";
        private string voicelessConsonants = "пфсктш";
        public bool IsChangable(char letter)
        {
            return changable.Contains(letter);
        }

        public string ChangableLetterType(char letter)
        {
            if (yoatedVowels.Contains(letter))
            {
                return "yoated vowel";
            }

            else if (voicedConsonants.Contains(letter))
            {
                return "voiced consonant";
            }

            else if (voicelessConsonants.Contains(letter))
            {
                return "voiceless consonant";
            }

            else return "special";
        }
    }
}
