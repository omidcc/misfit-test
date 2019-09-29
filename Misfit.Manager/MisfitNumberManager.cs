using System;

namespace Misfit.Manager
{
    
    public class MisfitNumberManager : IMisfitNumberManager
    {
        public MisfitNumberManager()
        {

        }

        public string Sum(string firstNumber, string secondNumber)
        {
            // Before proceeding further, make sure length  
            // of secondNumber is larger.  
            if (firstNumber.Length > secondNumber.Length)
            {
                string t = firstNumber;
                firstNumber = secondNumber;
                secondNumber = t;
            }

            // Take an empty string for storing result  
            string str = "";

            // Calculate length of both string  
            int n1 = firstNumber.Length, n2 = secondNumber.Length;
            int diff = n2 - n1;

            // Initially take carry zero  
            int carry = 0;

            // Traverse from end of both strings  
            for (int i = n1 - 1; i >= 0; i--)
            {
                // Do school mathematics, compute sum of  
                // current digits and carry  
                int sum = ((int)(firstNumber[i] - '0') +
                        (int)(secondNumber[i + diff] - '0') + carry);
                str += (char)(sum % 10 + '0');
                carry = sum / 10;
            }

            // Add remaining digits of secondNumber[]  
            for (int i = n2 - n1 - 1; i >= 0; i--)
            {
                int sum = ((int)(secondNumber[i] - '0') + carry);
                str += (char)(sum % 10 + '0');
                carry = sum / 10;
            }

            // Add remaining carry  
            if (carry > 0)
                str += (char)(carry + '0');

            // reverse resultant string 
            char[] ch2 = str.ToCharArray();
            Array.Reverse(ch2);
            return new string(ch2);
        }
    }
}
