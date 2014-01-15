using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathUser
{
    class Program
    {
        static void Main(string[] args)
        {
            localhost.MathService myMathService = new localhost.MathService();
            Console.Write("2 + 4 = {0}", myMathService.Add(2, 4));
            Console.ReadLine();
        }
    }
}
