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
            textBoxInfixed.Enabled = false;
        }

        private void buttonInfix_Click(object sender, EventArgs e)
        {
            ClearAll();
            string postfixedForm = textBoxPostfixed.Text;
            PostfixFormValidator postfixValidator = new PostfixFormValidator();
            postfixValidator.Validate(postfixedForm);

            if(postfixValidator.ValidationMessage != null)
            {
                MessageBox.Show(postfixValidator.ValidationMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            textBoxInfixed.Text = new PostfixToInfixedConverter(postfixedForm).Run();
        }

        private void buttonWatchProcess_Click(object sender, EventArgs e)
        {
            ClearAll();
            string postfixedForm = textBoxPostfixed.Text;
            PostfixFormValidator postfixValidator = new PostfixFormValidator();
            postfixValidator.Validate(postfixedForm);

            textBoxProgress.Text = textBoxPostfixed.Text;
            Application.DoEvents();

            if (postfixValidator.ValidationMessage != null)
            {
                MessageBox.Show(postfixValidator.ValidationMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            textBoxInfixed.Text = new PostfixToInfixedWatcher(postfixedForm,groupBoxRezStack,groupBoxTempStack,textBoxProgress).Run();
        }

        private void ClearAll()
        {
            textBoxProgress.Clear();
            textBoxInfixed.Clear();
            groupBoxRezStack.Controls.Clear();
            groupBoxTempStack.Controls.Clear();
        }
    }
}
