using PostfixToInfixed;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectMFI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonInfix_Click(object sender, EventArgs e)
        {
            string postfixedForm = textBoxPostfixed.Text;
            PostfixFormValidator postfixValidator = new PostfixFormValidator();
            postfixValidator.Validate(postfixedForm);

            if(postfixValidator.ValidationMessage == null)
            {
                textBoxInfixed.Text = new PostfixToInfixedConverter(postfixedForm).Run();
            }
            else
            {
                MessageBox.Show(postfixValidator.ValidationMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } 
        }
    }
}
