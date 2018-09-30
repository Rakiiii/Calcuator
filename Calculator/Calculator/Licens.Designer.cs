namespace Calculator
{
    partial class Licens
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
            this.txtbLicens = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtbLicens
            // 
            this.txtbLicens.Location = new System.Drawing.Point(12, 12);
            this.txtbLicens.Multiline = true;
            this.txtbLicens.Name = "txtbLicens";
            this.txtbLicens.ReadOnly = true;
            this.txtbLicens.Size = new System.Drawing.Size(324, 95);
            this.txtbLicens.TabIndex = 0;
            this.txtbLicens.TabStop = false;
            this.txtbLicens.Text = "Developed by Evgeniy \"Rakiiii\" Sudarskiy\r\nSudaru2@gmail.com\r\nBug reports https://" +
    "github.com/Rakiiii/Calcuator/issues \r\n©BSD 3-Clause \"New\" or \"Revised\" License";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(683, 402);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Licens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtbLicens);
            this.Name = "Licens";
            this.Text = "Licens";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbLicens;
        private System.Windows.Forms.Button btnExit;
    }
}