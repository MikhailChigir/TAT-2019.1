using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_DEV_2
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            try
            {
                Console.OutputEncoding = Encoding.UTF8;
                if (args.Length != 1)
                    throw new ArgumentException("Invalid quantity of arguments");
                int counter = 0;
                for (int i = 0; i < args[0].Length; i++)
                {
                    if (args[0][i] == '+' || args[0][i] == 'ё')
                    {
                        counter += 1;
                    }
                }

                if (counter != 1)
                    throw new ArgumentException("Something wrong with stress in your word." +
                                                " And maybe in your life.");//!FIX remove a joke
                var dirtyHumanistCan = new PhonemeBuilder();
                foreach (var s in dirtyHumanistCan.BuildPhoneme(args[0]).ToString()) //!FIX remove truth (so political)
                    Console.WriteLine(s);
                {
                    
                }


            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
