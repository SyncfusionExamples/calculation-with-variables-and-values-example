using Syncfusion.Calculate;
using System;

namespace Calculation_with_CalcQuickBase
{
    class Program
    {
        static void Main(string[] args)
        {
            PerformParseAndCompute();
        }

        private static void PerformParseAndCompute()
        {
            CalcQuickBase calcQuick = new CalcQuickBase();

            calcQuick["A"] = "5";
            calcQuick["B"] = "6";
            calcQuick["C"] = "11";

            //Computing expressions,
            calcQuick["result"] = "=([A]+[B])/[C]";

            //Computing In-Built formulas,
            calcQuick["result1"] = "=SUM([A],[B])";

            Console.WriteLine("The calculated result of formula (([A]+[B])/[C]) : " + calcQuick["result"]);
            Console.WriteLine("The calculated result of formula (SUM([A],[B])) : " + calcQuick["result1"]);
            Console.ReadKey();
        }
    }
}
