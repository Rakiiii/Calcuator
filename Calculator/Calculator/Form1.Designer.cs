namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtbIntegerPart = new System.Windows.Forms.TextBox();
            this.txtbNumerator = new System.Windows.Forms.TextBox();
            this.txtbDenominator = new System.Windows.Forms.TextBox();
            this.btnNumber1 = new System.Windows.Forms.Button();
            this.btnOperationMultiplication = new System.Windows.Forms.Button();
            this.btnOperationDivision = new System.Windows.Forms.Button();
            this.btnOperationMinus = new System.Windows.Forms.Button();
            this.btnOperationPlus = new System.Windows.Forms.Button();
            this.btnNumber9 = new System.Windows.Forms.Button();
            this.btnNumber8 = new System.Windows.Forms.Button();
            this.btnNumber7 = new System.Windows.Forms.Button();
            this.btnNumber6 = new System.Windows.Forms.Button();
            this.btnNumber5 = new System.Windows.Forms.Button();
            this.btnNumber4 = new System.Windows.Forms.Button();
            this.btnNumber3 = new System.Windows.Forms.Button();
            this.btnNumber2 = new System.Windows.Forms.Button();
            this.btnNumber0 = new System.Windows.Forms.Button();
            this.btnOperationEqual = new System.Windows.Forms.Button();
            this.txtbOperation = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtbIntegerPart
            // 
            this.txtbIntegerPart.Location = new System.Drawing.Point(12, 66);
            this.txtbIntegerPart.Name = "txtbIntegerPart";
            this.txtbIntegerPart.Size = new System.Drawing.Size(100, 22);
            this.txtbIntegerPart.TabIndex = 0;
            this.txtbIntegerPart.Enter += new System.EventHandler(this.txtbIntegerPart_Enter);
            this.txtbIntegerPart.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbIntegerPart_KeyPress);
            // 
            // txtbNumerator
            // 
            this.txtbNumerator.Location = new System.Drawing.Point(118, 45);
            this.txtbNumerator.Name = "txtbNumerator";
            this.txtbNumerator.Size = new System.Drawing.Size(100, 22);
            this.txtbNumerator.TabIndex = 1;
            this.txtbNumerator.Enter += new System.EventHandler(this.txtbNumerator_Enter);
            this.txtbNumerator.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbNumerator_KeyPress);
            // 
            // txtbDenominator
            // 
            this.txtbDenominator.Location = new System.Drawing.Point(118, 88);
            this.txtbDenominator.Name = "txtbDenominator";
            this.txtbDenominator.Size = new System.Drawing.Size(100, 22);
            this.txtbDenominator.TabIndex = 2;
            this.txtbDenominator.Enter += new System.EventHandler(this.txtbDenominator_Enter);
            this.txtbDenominator.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbDenominator_KeyPress);
            // 
            // btnNumber1
            // 
            this.btnNumber1.Location = new System.Drawing.Point(12, 176);
            this.btnNumber1.Name = "btnNumber1";
            this.btnNumber1.Size = new System.Drawing.Size(75, 23);
            this.btnNumber1.TabIndex = 3;
            this.btnNumber1.Text = "1";
            this.btnNumber1.UseVisualStyleBackColor = true;
            this.btnNumber1.Click += new System.EventHandler(this.btnNumber1_Click);
            // 
            // btnOperationMultiplication
            // 
            this.btnOperationMultiplication.Location = new System.Drawing.Point(12, 147);
            this.btnOperationMultiplication.Name = "btnOperationMultiplication";
            this.btnOperationMultiplication.Size = new System.Drawing.Size(75, 23);
            this.btnOperationMultiplication.TabIndex = 4;
            this.btnOperationMultiplication.Text = "*";
            this.btnOperationMultiplication.UseVisualStyleBackColor = true;
            this.btnOperationMultiplication.Click += new System.EventHandler(this.btnOperationMultiplication_Click);
            // 
            // btnOperationDivision
            // 
            this.btnOperationDivision.Location = new System.Drawing.Point(12, 263);
            this.btnOperationDivision.Name = "btnOperationDivision";
            this.btnOperationDivision.Size = new System.Drawing.Size(75, 23);
            this.btnOperationDivision.TabIndex = 5;
            this.btnOperationDivision.Text = "/";
            this.btnOperationDivision.UseVisualStyleBackColor = true;
            this.btnOperationDivision.Click += new System.EventHandler(this.btnOperationDivision_Click);
            // 
            // btnOperationMinus
            // 
            this.btnOperationMinus.Location = new System.Drawing.Point(93, 147);
            this.btnOperationMinus.Name = "btnOperationMinus";
            this.btnOperationMinus.Size = new System.Drawing.Size(75, 23);
            this.btnOperationMinus.TabIndex = 6;
            this.btnOperationMinus.Text = "-";
            this.btnOperationMinus.UseVisualStyleBackColor = true;
            this.btnOperationMinus.Click += new System.EventHandler(this.btnOperationMinus_Click);
            // 
            // btnOperationPlus
            // 
            this.btnOperationPlus.Location = new System.Drawing.Point(174, 147);
            this.btnOperationPlus.Name = "btnOperationPlus";
            this.btnOperationPlus.Size = new System.Drawing.Size(75, 23);
            this.btnOperationPlus.TabIndex = 7;
            this.btnOperationPlus.Text = "+";
            this.btnOperationPlus.UseVisualStyleBackColor = true;
            this.btnOperationPlus.Click += new System.EventHandler(this.btnOperationPlus_Click);
            // 
            // btnNumber9
            // 
            this.btnNumber9.Location = new System.Drawing.Point(174, 234);
            this.btnNumber9.Name = "btnNumber9";
            this.btnNumber9.Size = new System.Drawing.Size(75, 23);
            this.btnNumber9.TabIndex = 8;
            this.btnNumber9.Text = "9";
            this.btnNumber9.UseVisualStyleBackColor = true;
            this.btnNumber9.Click += new System.EventHandler(this.btnNumber9_Click);
            // 
            // btnNumber8
            // 
            this.btnNumber8.Location = new System.Drawing.Point(93, 234);
            this.btnNumber8.Name = "btnNumber8";
            this.btnNumber8.Size = new System.Drawing.Size(75, 23);
            this.btnNumber8.TabIndex = 9;
            this.btnNumber8.Text = "8";
            this.btnNumber8.UseVisualStyleBackColor = true;
            this.btnNumber8.Click += new System.EventHandler(this.btnNumber8_Click);
            // 
            // btnNumber7
            // 
            this.btnNumber7.Location = new System.Drawing.Point(12, 234);
            this.btnNumber7.Name = "btnNumber7";
            this.btnNumber7.Size = new System.Drawing.Size(75, 23);
            this.btnNumber7.TabIndex = 10;
            this.btnNumber7.Text = "7";
            this.btnNumber7.UseVisualStyleBackColor = true;
            this.btnNumber7.Click += new System.EventHandler(this.btnNumber7_Click);
            // 
            // btnNumber6
            // 
            this.btnNumber6.Location = new System.Drawing.Point(174, 205);
            this.btnNumber6.Name = "btnNumber6";
            this.btnNumber6.Size = new System.Drawing.Size(75, 23);
            this.btnNumber6.TabIndex = 11;
            this.btnNumber6.Text = "6";
            this.btnNumber6.UseVisualStyleBackColor = true;
            this.btnNumber6.Click += new System.EventHandler(this.btnNumber6_Click);
            // 
            // btnNumber5
            // 
            this.btnNumber5.Location = new System.Drawing.Point(93, 205);
            this.btnNumber5.Name = "btnNumber5";
            this.btnNumber5.Size = new System.Drawing.Size(75, 23);
            this.btnNumber5.TabIndex = 12;
            this.btnNumber5.Text = "5";
            this.btnNumber5.UseVisualStyleBackColor = true;
            this.btnNumber5.Click += new System.EventHandler(this.btnNumber5_Click);
            // 
            // btnNumber4
            // 
            this.btnNumber4.Location = new System.Drawing.Point(12, 205);
            this.btnNumber4.Name = "btnNumber4";
            this.btnNumber4.Size = new System.Drawing.Size(75, 23);
            this.btnNumber4.TabIndex = 13;
            this.btnNumber4.Text = "4";
            this.btnNumber4.UseVisualStyleBackColor = true;
            this.btnNumber4.Click += new System.EventHandler(this.btnNumber4_Click);
            // 
            // btnNumber3
            // 
            this.btnNumber3.Location = new System.Drawing.Point(174, 176);
            this.btnNumber3.Name = "btnNumber3";
            this.btnNumber3.Size = new System.Drawing.Size(75, 23);
            this.btnNumber3.TabIndex = 14;
            this.btnNumber3.Text = "3";
            this.btnNumber3.UseVisualStyleBackColor = true;
            this.btnNumber3.Click += new System.EventHandler(this.btnNumber3_Click);
            // 
            // btnNumber2
            // 
            this.btnNumber2.Location = new System.Drawing.Point(93, 176);
            this.btnNumber2.Name = "btnNumber2";
            this.btnNumber2.Size = new System.Drawing.Size(75, 23);
            this.btnNumber2.TabIndex = 15;
            this.btnNumber2.Text = "2";
            this.btnNumber2.UseVisualStyleBackColor = true;
            this.btnNumber2.Click += new System.EventHandler(this.btnNumber2_Click);
            // 
            // btnNumber0
            // 
            this.btnNumber0.Location = new System.Drawing.Point(93, 263);
            this.btnNumber0.Name = "btnNumber0";
            this.btnNumber0.Size = new System.Drawing.Size(75, 23);
            this.btnNumber0.TabIndex = 16;
            this.btnNumber0.Text = "0";
            this.btnNumber0.UseVisualStyleBackColor = true;
            this.btnNumber0.Click += new System.EventHandler(this.btnNumber0_Click);
            // 
            // btnOperationEqual
            // 
            this.btnOperationEqual.Location = new System.Drawing.Point(174, 263);
            this.btnOperationEqual.Name = "btnOperationEqual";
            this.btnOperationEqual.Size = new System.Drawing.Size(75, 23);
            this.btnOperationEqual.TabIndex = 17;
            this.btnOperationEqual.Text = "=";
            this.btnOperationEqual.UseVisualStyleBackColor = true;
            this.btnOperationEqual.Click += new System.EventHandler(this.btnOperationEqual_Click);
            // 
            // txtbOperation
            // 
            this.txtbOperation.Location = new System.Drawing.Point(237, 66);
            this.txtbOperation.Name = "txtbOperation";
            this.txtbOperation.Size = new System.Drawing.Size(21, 22);
            this.txtbOperation.TabIndex = 18;
            this.txtbOperation.Enter += new System.EventHandler(this.txtbOperation_Enter);
            this.txtbOperation.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbOperation_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 19;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(256, 147);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(20, 23);
            this.btnClear.TabIndex = 20;
            this.btnClear.Text = "c";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(22, 22);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(301, 31);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(47, 27);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(238, 28);
            this.closeToolStripMenuItem.Text = "close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informationToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(57, 27);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // informationToolStripMenuItem
            // 
            this.informationToolStripMenuItem.Name = "informationToolStripMenuItem";
            this.informationToolStripMenuItem.Size = new System.Drawing.Size(238, 28);
            this.informationToolStripMenuItem.Text = "Information";
            this.informationToolStripMenuItem.Click += new System.EventHandler(this.informationToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 450);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbOperation);
            this.Controls.Add(this.btnOperationEqual);
            this.Controls.Add(this.btnNumber0);
            this.Controls.Add(this.btnNumber2);
            this.Controls.Add(this.btnNumber3);
            this.Controls.Add(this.btnNumber4);
            this.Controls.Add(this.btnNumber5);
            this.Controls.Add(this.btnNumber6);
            this.Controls.Add(this.btnNumber7);
            this.Controls.Add(this.btnNumber8);
            this.Controls.Add(this.btnNumber9);
            this.Controls.Add(this.btnOperationPlus);
            this.Controls.Add(this.btnOperationMinus);
            this.Controls.Add(this.btnOperationDivision);
            this.Controls.Add(this.btnOperationMultiplication);
            this.Controls.Add(this.btnNumber1);
            this.Controls.Add(this.txtbDenominator);
            this.Controls.Add(this.txtbNumerator);
            this.Controls.Add(this.txtbIntegerPart);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbIntegerPart;
        private System.Windows.Forms.TextBox txtbNumerator;
        private System.Windows.Forms.TextBox txtbDenominator;
        private System.Windows.Forms.Button btnNumber1;
        private System.Windows.Forms.Button btnOperationMultiplication;
        private System.Windows.Forms.Button btnOperationDivision;
        private System.Windows.Forms.Button btnOperationMinus;
        private System.Windows.Forms.Button btnOperationPlus;
        private System.Windows.Forms.Button btnNumber9;
        private System.Windows.Forms.Button btnNumber8;
        private System.Windows.Forms.Button btnNumber7;
        private System.Windows.Forms.Button btnNumber6;
        private System.Windows.Forms.Button btnNumber5;
        private System.Windows.Forms.Button btnNumber4;
        private System.Windows.Forms.Button btnNumber3;
        private System.Windows.Forms.Button btnNumber2;
        private System.Windows.Forms.Button btnNumber0;
        private System.Windows.Forms.Button btnOperationEqual;
        private System.Windows.Forms.TextBox txtbOperation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informationToolStripMenuItem;
    }
}

