
namespace ProjectMFI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxPostfixed = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxInfixed = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonInfix = new System.Windows.Forms.Button();
            this.groupBoxRezStack = new System.Windows.Forms.GroupBox();
            this.groupBoxTempStack = new System.Windows.Forms.GroupBox();
            this.buttonWatchProcess = new System.Windows.Forms.Button();
            this.textBoxProgress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxPostfixed
            // 
            this.textBoxPostfixed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPostfixed.Location = new System.Drawing.Point(142, 25);
            this.textBoxPostfixed.Name = "textBoxPostfixed";
            this.textBoxPostfixed.Size = new System.Drawing.Size(405, 27);
            this.textBoxPostfixed.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Postfixed Form";
            // 
            // textBoxInfixed
            // 
            this.textBoxInfixed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxInfixed.Location = new System.Drawing.Point(142, 76);
            this.textBoxInfixed.Name = "textBoxInfixed";
            this.textBoxInfixed.Size = new System.Drawing.Size(405, 27);
            this.textBoxInfixed.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Infixed Form";
            // 
            // buttonInfix
            // 
            this.buttonInfix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInfix.Location = new System.Drawing.Point(412, 124);
            this.buttonInfix.Name = "buttonInfix";
            this.buttonInfix.Size = new System.Drawing.Size(135, 29);
            this.buttonInfix.TabIndex = 4;
            this.buttonInfix.Text = "Change to Infixed";
            this.buttonInfix.UseVisualStyleBackColor = true;
            this.buttonInfix.Click += new System.EventHandler(this.buttonInfix_Click);
            // 
            // groupBoxRezStack
            // 
            this.groupBoxRezStack.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxRezStack.Location = new System.Drawing.Point(12, 220);
            this.groupBoxRezStack.Name = "groupBoxRezStack";
            this.groupBoxRezStack.Size = new System.Drawing.Size(264, 381);
            this.groupBoxRezStack.TabIndex = 5;
            this.groupBoxRezStack.TabStop = false;
            this.groupBoxRezStack.Text = "Result Stack";
            // 
            // groupBoxTempStack
            // 
            this.groupBoxTempStack.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxTempStack.Location = new System.Drawing.Point(282, 220);
            this.groupBoxTempStack.Name = "groupBoxTempStack";
            this.groupBoxTempStack.Size = new System.Drawing.Size(265, 381);
            this.groupBoxTempStack.TabIndex = 6;
            this.groupBoxTempStack.TabStop = false;
            this.groupBoxTempStack.Text = "Tepmorary Stack";
            // 
            // buttonWatchProcess
            // 
            this.buttonWatchProcess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonWatchProcess.Location = new System.Drawing.Point(282, 124);
            this.buttonWatchProcess.Name = "buttonWatchProcess";
            this.buttonWatchProcess.Size = new System.Drawing.Size(124, 29);
            this.buttonWatchProcess.TabIndex = 7;
            this.buttonWatchProcess.Text = "Watch Process";
            this.buttonWatchProcess.UseVisualStyleBackColor = true;
            this.buttonWatchProcess.Click += new System.EventHandler(this.buttonWatchProcess_Click);
            // 
            // textBoxProgress
            // 
            this.textBoxProgress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxProgress.Location = new System.Drawing.Point(142, 174);
            this.textBoxProgress.Name = "textBoxProgress";
            this.textBoxProgress.Size = new System.Drawing.Size(405, 27);
            this.textBoxProgress.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Progress";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 613);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxProgress);
            this.Controls.Add(this.buttonWatchProcess);
            this.Controls.Add(this.groupBoxTempStack);
            this.Controls.Add(this.groupBoxRezStack);
            this.Controls.Add(this.buttonInfix);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxInfixed);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPostfixed);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Postfix To Infixed Convertor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPostfixed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonInfix;
        private System.Windows.Forms.GroupBox groupBoxRezStack;
        private System.Windows.Forms.GroupBox groupBoxTempStack;
        private System.Windows.Forms.Button buttonWatchProcess;
        private System.Windows.Forms.TextBox textBoxInfixed;
        private System.Windows.Forms.TextBox textBoxProgress;
        private System.Windows.Forms.Label label3;
    }
}

