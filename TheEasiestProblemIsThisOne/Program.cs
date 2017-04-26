using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheEasiestProblemIsThisOne
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> results = new List<string>();

            while (true)
            {
                int testCase = int.Parse(Console.ReadLine());

                if (testCase == 0)
                {
                    break;
                }

                
                int testCaseSum = 0;

                foreach (var c in testCase.ToString())
                {
                    testCaseSum += int.Parse(c.ToString());
                }


                int counter = 11;

                while (true)
                {
                    int timesPsum = 0;

                    foreach (var c in (testCase * counter).ToString())
                    {
                        timesPsum += int.Parse(c.ToString());
                    }

                    if (timesPsum == testCaseSum)
                    {
                        results.Add(counter.ToString());
                        break;
                    }

                    counter++;
                }
            }

            foreach (var s in results)
            {

                Console.WriteLine(s);
            }
        }
    }
}
