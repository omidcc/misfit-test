using System;
using System.Numerics;

namespace Misfit.Manager
{
    
    public class MisfitNumberManager : IMisfitNumberManager
    {
        public MisfitNumberManager()
        {

        }

        public string AddNumbers(string firstNumber, string secondNumber)
        {
            BigInteger num1 = new BigInteger();
            BigInteger num2 = new BigInteger();

            BigInteger.TryParse(firstNumber, out num1);
            BigInteger.TryParse(secondNumber, out num2);

            return (num1 + num2).ToString();
        }
    }
}
