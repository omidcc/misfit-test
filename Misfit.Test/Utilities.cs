using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Misfit.Test
{
    public class Utilities
    {
        public string Sum(string firstNumber, string secondNumber)
        {
            BigInteger num1 = new BigInteger();
            BigInteger num2 = new BigInteger();

            BigInteger.TryParse(firstNumber, out num1);
            BigInteger.TryParse(secondNumber, out num2);

            return (num1 + num2).ToString();
        }
    }
}
