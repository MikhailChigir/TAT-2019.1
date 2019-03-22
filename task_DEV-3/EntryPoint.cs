using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_3
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            try
            {
                int[] input = new int[args.Length];
                for (int i = 0; i < args.Length; i++)
                {
                    if (int.TryParse(args[i], out input[i]))
                    {
                        //Console.WriteLine("Yep");
                    }
                    else
                    {
                        Console.WriteLine("Can not convert to int");
                    }
                }

                Employee employee = new Employee();
                Optimise optimise = new Optimise();
                Criterion1 criterion1 = new Criterion1(input[0]);
                Criterion2 criterion2 = new Criterion2(input[1]);
                Criterion3 criterion3 = new Criterion3(input[1]);
                switch (input[2])
                {
                    case 1:
                        Console.WriteLine("Maximal performance: " + criterion1.Calculate1());
                        Console.WriteLine("Amount of certain developers: " + optimise.Developers);
                        break;
                    case 2:
                        Console.WriteLine("Minimal cost: ", criterion2.Calculate2());
                        Console.WriteLine("Amount of certain developers: ", optimise.Developers);
                        break;
                    case 3:
                        Console.WriteLine("Amount of certain developers: ", criterion3.Calculate3());
                        break;
                        

                    
                        
                }
            }

            catch
            {

            }
        }
    }
}
