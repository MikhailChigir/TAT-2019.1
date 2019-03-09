using System;

namespace task_DEV_1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            try
            {
                if (args.Length != 1)
                    throw new ArgumentException("Invalid quantity of arguments");

                if (args[0].Length < 2)
                    throw new ArgumentException("Argument is too short");
                var searcher = new ReiterationSearcher();
                foreach (var s in searcher.GetStrings(args[0])) Console.WriteLine(s);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}