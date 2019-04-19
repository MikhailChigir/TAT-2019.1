using System.Text;

namespace task_DEV_2
{
    public class PhonemeBuilder
    {
        //private string phoneme = "undefined";
        private string rType = "undefined";
        private string vType = "undefined";

        public StringBuilder BuildPhoneme(string word)
        {
            var victim = new ChangableSymbols();
            var rapist = new ChangingSymbols();
            var modify = new ModifyingFunctions();
            //var output = new StringBuilder();
            var phoneme = new StringBuilder();
            for (var i = 0; i < word.Length; i++)
                if (victim.IsChangable(word[i]))
                {
                    vType = victim.ChangableLetterType(word[i]);
                    if (vType.Contains("yoated"))
                    {
                        if (i == 0)
                        {
                            phoneme.Append(modify.YoatedTo2Letters(word[i]));
                        }
                        else
                        {
                            rType = rapist.ChangingLetterType(word[i - 1]);
                            if (rType.Contains("vowel") || rType.Contains("signs"))
                                phoneme.Append(modify.YoatedTo2Letters(word[i]));
                            else if (rType.Contains("consonant")) phoneme.Append(modify.YoatedToApostrophe(word[i]));
                        }
                    }
                    else if (vType.Contains("voiced") && i > 0)
                    {
                        rType = rapist.ChangingLetterType(word[i - 1]);
                        if (rType.Contains("voiceless") || i == word.Length)
                            phoneme.Append(modify.VoicedToViceless(word[i]));
                    }
                    else if (vType.Contains("voiceless"))
                    {
                        rType = rapist.ChangingLetterType(word[i + 1]);
                        if (rType.Contains("voiced"))
                            phoneme.Append(modify.VoicelessToVoiced(word[i]));
                        else phoneme.Append(word[i]);
                    }
                    else if (vType.Contains("special"))
                    {
                        if (word[i] == 'о')
                        {
                            rType = rapist.ChangingLetterType(word[i + 1]);
                            if (rType.Contains("stress"))
                                phoneme.Append("а");
                            else phoneme.Append("о");
                        }

                        if (word[i] == 'и' && i > 0)
                        {
                            rType = rapist.ChangingLetterType(word[i - 1]);
                            if (rType.Contains("hissing"))
                                phoneme.Append("ы");
                            else phoneme.Append("и");
                        }
                    }
                    else
                    {
                        phoneme.Append(word[i]);
                    }
                }
                else if (word[i] == 'ь')
                {
                    if (i == word.Length - 1)
                    {
                        phoneme.Append("'");
                    }

                    else
                    {
                        rType = rapist.ChangingLetterType(word[i + 1]);
                        if (!rType.Contains("yoated")) phoneme.Append("'");
                    }
                }
                else if(word[i] != '+')
                {
                    phoneme.Append(word[i]);
                }

            return phoneme;
        }
    }
}