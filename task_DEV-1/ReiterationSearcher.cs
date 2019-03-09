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
        public List<string> GetStrings(string arg)
        {
            var output = new List<string>();
            var circleSave = new StringBuilder();
            circleSave.Append(arg[0]);
            for (var i = 1; i < arg.Length; i++)
                if (arg[i] != arg[i - 1])
                {
                    circleSave.Append(arg[i]);
                    if (circleSave.Length >= 2)
                    {
                        output.Add(circleSave.ToString());
                        if (circleSave.Length >= 3)
                            for (var j = 0; j < circleSave.Length - 2; j++)
                            {
                                circleSave.Remove(0, j + 1);
                                output.Add(circleSave.ToString());
                            }
                    }
                }
                else
                {
                    circleSave.Remove(0, circleSave.Length);
                    circleSave.Append(arg[i]);
                }

            return output;
        }
    }
}