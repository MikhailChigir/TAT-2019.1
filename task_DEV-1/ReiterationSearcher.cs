using System.Collections.Generic;
using System.Text;

namespace task_DEV_1
{
    internal class ReiterationSearcher
    {
        /// <summary>
        ///     returns all strings without reiterations, which are longer than two symbols
        /// </summary>
        /// <param name="arg"> initial string </param>
        /// <returns> all strings without reiterations, which are longer than two symbols </returns>
        public List<string> GetUnrepeatSymb(string arg)
        {
            var output = new List<string>();
            var outputPart = new StringBuilder();
            outputPart.Append(arg[0]);
            for (var i = 1; i < arg.Length; i++)
                if (arg[i] != arg[i - 1])
                {
                    outputPart.Append(arg[i]);
                    if (outputPart.Length >= 2)
                    {
                        output.Add(outputPart.ToString());
                        if (outputPart.Length >= 3)
                            for (var j = 0; j < outputPart.Length - 2; j++)
                            {
                                outputPart.Remove(0, j + 1);
                                output.Add(outputPart.ToString());
                            }
                    }
                }
                else
                {
                    outputPart.Remove(0, outputPart.Length);
                    outputPart.Append(arg[i]);
                }

            return output;
        }
    }
}