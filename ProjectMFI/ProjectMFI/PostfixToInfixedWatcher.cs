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
        private string progressInput;
        private Stack<TextBox> resultTextBoxes;
        private Stack<TextBox> tempTextBoxes;

        public GroupBox ResultStackGrBox;
        public GroupBox TempStackGrBox;
        public TextBox ProgressTextBox;

        public PostfixToInfixedWatcher(string postfixedInput, GroupBox resultStack, GroupBox tempStack, TextBox progressTextBox) : base(postfixedInput)
        {
            this.postfixedInput = postfixedInput;
            progressInput = postfixedInput;
            ResultStackGrBox = resultStack;
            TempStackGrBox = tempStack;
            ProgressTextBox = progressTextBox;
            resultTextBoxes = new Stack<TextBox>();
            tempTextBoxes = new Stack<TextBox>();
        }

        public override string Run()
        {
            Thread.Sleep(2000);
            for (int i = 0; i < postfixedInput.Length; i++)
            {
                Stack<string> temp = new Stack<string>();

                if (!IsOperand(postfixedInput[i]))
                {
                    InfixedResult.Push(postfixedInput[i].ToString());
                    yRezGrupBoxCoordonate -= yModifyingUnits;
                    progressInput = progressInput.Remove(0, 1);

                    resultTextBoxes.Push(AddNewTextBoxTo(ResultStackGrBox, yRezGrupBoxCoordonate, InfixedResult));
                }
                else
                {
                    temp.Push(InfixedResult.Pop());
                    SwitchFromResultToTempStack();
                    AddNewTextBoxTo(TempStackGrBox, yTempGrupBoxCoordonate, temp);

                    temp.Push(postfixedInput[i].ToString());
                    yTempGrupBoxCoordonate -= yModifyingUnits;
                    progressInput = progressInput.Remove(0, 1);
                    tempTextBoxes.Push(AddNewTextBoxTo(TempStackGrBox, yTempGrupBoxCoordonate, temp));

                    temp.Push(InfixedResult.Pop());
                    SwitchFromResultToTempStack();
                    AddNewTextBoxTo(TempStackGrBox, yTempGrupBoxCoordonate, temp);

                    InfixedResult.Push(CreateStringFrom(temp, i));
                    yRezGrupBoxCoordonate -= yModifyingUnits;
                    resultTextBoxes.Push(AddNewTextBoxTo(ResultStackGrBox, yRezGrupBoxCoordonate, InfixedResult));
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
                TempStackGrBox.Controls.RemoveAt(tempTextBoxes.Count - 1);
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
            ProgressTextBox.Text = progressInput;
            Application.DoEvents();
            Thread.Sleep(2000);

            return textBox;
        }

        private void SwitchFromResultToTempStack()
        {
            tempTextBoxes.Push(resultTextBoxes.Pop());
            ResultStackGrBox.Controls.Remove(tempTextBoxes.Peek());
            yRezGrupBoxCoordonate += yModifyingUnits;
            yTempGrupBoxCoordonate -= yModifyingUnits;
        }
    }
}
