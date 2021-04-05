using PostfixToInfixed;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectMFI
{
    public class PostfixToInfixedWatcher : PostfixToInfixedConverter
    {
        private int xCoordonate = 75;
        private int yRezGrupBoxCoordonate = 380;
        private int yTempGrupBoxCoordonate = 380;
        private int yModifyingUnits = 30;
        private Stack<TextBox> resultTextBoxes;
        private Stack<TextBox> tempTextBoxes;

        public GroupBox ResultStackGB;
        public GroupBox TempStackGB;

        public PostfixToInfixedWatcher(string postfixedInput, GroupBox resultStack, GroupBox tempStack) : base(postfixedInput)
        {
            this.postfixedInput = postfixedInput;
            ResultStackGB = resultStack;
            TempStackGB = tempStack;
            resultTextBoxes = new Stack<TextBox>();
            tempTextBoxes = new Stack<TextBox>();
        }

        public override string Run()
        {
            for (int i = 0; i < postfixedInput.Length; i++)
            {
                Stack<string> temp = new Stack<string>();

                if (!IsOperand(postfixedInput[i]))
                {
                    InfixedResult.Push(postfixedInput[i].ToString());
                    yRezGrupBoxCoordonate -= yModifyingUnits;

                    resultTextBoxes.Push(AddNewTextBoxTo(ResultStackGB, yRezGrupBoxCoordonate, InfixedResult));
                }
                else
                {
                    temp.Push(InfixedResult.Pop());
                    SwitchFromResultToTempStack();
                    AddNewTextBoxTo(TempStackGB, yTempGrupBoxCoordonate, temp);

                    temp.Push(postfixedInput[i].ToString());
                    yTempGrupBoxCoordonate -= yModifyingUnits;
                    tempTextBoxes.Push(AddNewTextBoxTo(TempStackGB, yTempGrupBoxCoordonate, temp));

                    temp.Push(InfixedResult.Pop());
                    SwitchFromResultToTempStack();
                    AddNewTextBoxTo(TempStackGB, yTempGrupBoxCoordonate, temp);

                    InfixedResult.Push(CreateStringFrom(temp, i));
                    yRezGrupBoxCoordonate -= yModifyingUnits;
                    resultTextBoxes.Push(AddNewTextBoxTo(ResultStackGB, yRezGrupBoxCoordonate, InfixedResult));
                }
            }

            return InfixedResult.Pop();
        }

        protected override string CreateStringFrom(Stack<string> tempContainer, int index)
        {
            StringBuilder reversedString = new StringBuilder();

            while (tempContainer.Count != 0)
            {
                reversedString.Append(tempContainer.Pop());
                TempStackGB.Controls.RemoveAt(tempTextBoxes.Count()-1);
                tempTextBoxes.Pop();
                yTempGrupBoxCoordonate += yModifyingUnits;
            }

            if (IsLowPrioOperand(postfixedInput[index]) && index != postfixedInput.Length - 1)
            {
                reversedString.Insert(0, '(');
                reversedString.Insert(reversedString.Length, ')');
            }

            return reversedString.ToString();
        }

        private TextBox AddNewTextBoxTo(GroupBox grupBox, int yCoordonate,Stack<string> textBoxValue)
        {
            TextBox textBox = new TextBox();
            textBox.Text = textBoxValue.Peek();
            textBox.Location = new Point(xCoordonate, yCoordonate);
            textBox.TextAlign = HorizontalAlignment.Center;
            grupBox.Controls.Add(textBox);
            Application.DoEvents();
            Thread.Sleep(2000);

            return textBox;
        }

        private void SwitchFromResultToTempStack()
        {
            tempTextBoxes.Push(resultTextBoxes.Pop());
            ResultStackGB.Controls.Remove(tempTextBoxes.Peek());
            yRezGrupBoxCoordonate += yModifyingUnits;
            yTempGrupBoxCoordonate -= yModifyingUnits;
        }
    }
}
