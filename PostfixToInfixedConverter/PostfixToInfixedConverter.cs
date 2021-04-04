using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PostfixToInfixed
{
    public class PostfixToInfixedConverter
    {
        static char[] operands = { '+', '-', '*', '/' };
        static char[] lowPrioOperands = { '+', '-' };

        private string postfixedInput;

        public Stack<string> InfixedResult { get; private set; }

        public PostfixToInfixedConverter(string postfixedInput)
        {
            InfixedResult = new Stack<string>();
            this.postfixedInput = postfixedInput;
        }

        public void Run()
        {
            for (int i = 0; i < postfixedInput.Length; i++)
            {
                Stack<string> temp = new Stack<string>();

                if (!IsOperand(postfixedInput[i]))
                {
                    InfixedResult.Push(postfixedInput[i].ToString());
                }
                else
                {
                    temp.Push(InfixedResult.Pop());
                    temp.Push(postfixedInput[i].ToString());
                    temp.Push(InfixedResult.Pop());

                    InfixedResult.Push(ReverseElements(temp, i));
                }
            }
        }

        private string ReverseElements(Stack<string> tempContainer, int index)
        {
            StringBuilder reversedString = new StringBuilder();

            while (tempContainer.Count != 0)
            {
                reversedString.Append(tempContainer.Pop());
            }

            if (IsLowPrioOperand(postfixedInput[index]))
            {
                reversedString.Insert(0, '(');
                reversedString.Insert(reversedString.Length, ')');
            }

            return reversedString.ToString();
        }

        private bool IsOperand(char element) => operands.Contains(element);

        private bool IsLowPrioOperand(char element) => lowPrioOperands.Contains(element);
    }
}
