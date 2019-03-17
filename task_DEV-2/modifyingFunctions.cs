namespace task_DEV_2
{
    internal class ModifyingFunctions
    {
        public string YoatedTo2Letters(char letter)
        {
            switch (letter)
            {
                case 'я':
                    return "йа";
                case 'е':
                    return "йэ";
                case 'ё':
                    return "йо";
                case 'ю':
                    return "йу";
                default:
                    return "go away"; //!!!!!!!!!!!!!!!!!!!!!!!!!!!FIX add throwEx
            }
        }

        public string YoatedToApostrophe(char letter)

        {
            switch (letter)
            {
                case 'я':
                    return "'а";
                case 'е':
                    return "'э";
                case 'ё':
                    return "'о";
                case 'ю':
                    return "'у";
                default:
                    return "go away"; //!!!!!!!!!!!!!!!!!!!!!!!!!!!FIX add throwEx
            }
        }

        public string VoicelessToVoiced(char letter)
        {
            switch (letter)
            {
                case 'п':
                    return "б";
                case 'ф':
                    return "в";
                case 'с':
                    return "з";
                case 'к':
                    return "г";
                case 'т':
                    return "д";
                case 'ш':
                    return "ж";
                default: return "go away"; // !!!!!!!!!!!!!!!!!!!!FIX add throwEx
            }
        }

        public string VoicedToViceless(char letter)
        {
            switch (letter)
            {
                case 'б':
                    return "п";
                case 'в':
                    return "ф";
                case 'з':
                    return "с";
                case 'г':
                    return "к";
                case 'д':
                    return "т";
                case 'ж':
                    return "ш";
                default: return "go away"; // !!!!!!!!!!!!!!!!!!!!FIX add throwEx
            }
        }
    }
}