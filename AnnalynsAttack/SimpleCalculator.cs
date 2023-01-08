using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch
{
    class SimpleCalculator
    {
        public static string Calculate(int operand1, int operand2, string operation) => operation switch
        {
            "*" => $"{operand1} * {operand2} = {operand1 * operand2}",
            "+" => $"{operand1} + {operand2} = {operand1 + operand2}",
            "/" => operand2 != 0 ? $"{operand1} / {operand2} = {operand1 / operand2}" : "Division by zero is not allowed.",
            "" => throw new ArgumentException(),
            null => throw new ArgumentNullException(),
            _ => throw new ArgumentOutOfRangeException()
        };

        //try
        //{
        //    if (operation == String.Empty) throw new ArgumentException();
        //    else if (operation == null) throw new ArgumentNullException();
        //    else if (operation == "+") return $"{operand1} + {operand2} = {operand1 + operand2}";
        //    else if (operation == "*") return $"{operand1} * {operand2} = {operand1 * operand2}";
        //    else if (operation == "/") return $"{operand1} / {operand2} = {operand1 / operand2}";
        //    else throw new ArgumentOutOfRangeException();
        //}
        //catch (Exception e)
        //{
        //    Console.WriteLine(e.Message);
        //    return null;
        //}
    }
}
