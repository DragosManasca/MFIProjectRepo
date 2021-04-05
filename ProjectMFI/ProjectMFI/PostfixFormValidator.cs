using System;
using System.Linq;


namespace ProjectMFI
{
    public class PostfixFormValidator
    {
        private static readonly char[] operands = { '+', '-', '*', '/' };
        private static readonly char[] letters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
        
        public string ValidationMessage;

        public void Validate(string inputString)
        {
            int operandsCounter = 0;
            int lettersCounter = 0;

            for (int i = 0; i < inputString.Length; i++)
            {
                if (IsOperand(inputString[i]))
                {
                    operandsCounter++;
                }
                else if(IsLetter(inputString[i]))
                {
                    lettersCounter++;
                }
                else
                {
                    ValidationMessage = "Invalid expresion! Your input contains forbiden elements. Only letters, 1st and second degree operands, and round brackets allowed.";
                    return;
                }
            }

            if (lettersCounter - operandsCounter != 1)
                ValidationMessage = "Incorrect postfixed form input!";
        }

        private bool IsOperand(char element) => operands.Contains(element);

        private bool IsLetter(char element) => letters.Contains(element);
    }
}
