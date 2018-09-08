using System;

namespace Scenario_1_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            String n = Console.ReadLine();
            Console.WriteLine(getSignificantDigits(n));
        }

        static int getSignificantDigits(String n)
        {
            if(n == "0")
            {
                return 0;
            } else if (n.Length == 1)
            {
                return 1;
            } else
            {                
                int result = getSignificantDigits(n.Substring(1));

                int d = n[0] - '0';
                if(d == 0)
                {
                    if(result > 0)
                    {
                        return result + 1;
                    } else
                    {
                        return 0;
                    }
                } else
                {
                    return result + 1;
                }
            }

        }
    }
}
