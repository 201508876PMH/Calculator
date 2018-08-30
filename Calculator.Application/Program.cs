using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Application
{
    class Program
    {
        static void Main(string[] args)
        {
           Calculator calc1 = new Calculator();

           double holder0 = calc1.add(20, 10);
           Console.WriteLine("Din calculator har adderet: {0}", holder0);

           double holder1 = calc1.subtract(20, 10);
           Console.WriteLine("Din calculator har trukket fra: {0}", holder1);

           double holder2 = calc1.multiply(20, 10);
           Console.WriteLine("Din calculator har ganget: {0}", holder2);

           double holder3 = calc1.power(20, 10);
           Console.WriteLine("Din calculator har løftet i potens: {0}", holder3);
        }
    }
}
