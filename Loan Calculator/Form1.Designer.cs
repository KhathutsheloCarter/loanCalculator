
namespace Loan_Calculator
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
            this.lblLoanAmount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textLoanAmount = new System.Windows.Forms.TextBox();
            this.textTermsinYears = new System.Windows.Forms.TextBox();
            this.textInterestRate = new System.Windows.Forms.TextBox();
            this.textDownPayment = new System.Windows.Forms.TextBox();
            this.btnMortagege = new System.Windows.Forms.Button();
            this.btnAuto = new System.Windows.Forms.Button();
            this.lblMothlyPayment = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblLoanAmount
            // 
            this.lblLoanAmount.AutoSize = true;
            this.lblLoanAmount.Location = new System.Drawing.Point(206, 42);
            this.lblLoanAmount.Name = "lblLoanAmount";
            this.lblLoanAmount.Size = new System.Drawing.Size(124, 25);
            this.lblLoanAmount.TabIndex = 0;
            this.lblLoanAmount.Text = "Loan Amount:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(206, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Down Payment:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(206, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Interest Rate:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(206, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Terms in Years";
            // 
            // textLoanAmount
            // 
            this.textLoanAmount.Location = new System.Drawing.Point(405, 36);
            this.textLoanAmount.Name = "textLoanAmount";
            this.textLoanAmount.Size = new System.Drawing.Size(150, 31);
            this.textLoanAmount.TabIndex = 4;
            // 
            // textTermsinYears
            // 
            this.textTermsinYears.Location = new System.Drawing.Point(405, 223);
            this.textTermsinYears.Name = "textTermsinYears";
            this.textTermsinYears.Size = new System.Drawing.Size(150, 31);
            this.textTermsinYears.TabIndex = 5;
            // 
            // textInterestRate
            // 
            this.textInterestRate.Location = new System.Drawing.Point(405, 164);
            this.textInterestRate.Name = "textInterestRate";
            this.textInterestRate.Size = new System.Drawing.Size(150, 31);
            this.textInterestRate.TabIndex = 7;
            // 
            // textDownPayment
            // 
            this.textDownPayment.Location = new System.Drawing.Point(405, 99);
            this.textDownPayment.Name = "textDownPayment";
            this.textDownPayment.Size = new System.Drawing.Size(150, 31);
            this.textDownPayment.TabIndex = 8;
            // 
            // btnMortagege
            // 
            this.btnMortagege.Location = new System.Drawing.Point(354, 293);
            this.btnMortagege.Name = "btnMortagege";
            this.btnMortagege.Size = new System.Drawing.Size(112, 34);
            this.btnMortagege.TabIndex = 9;
            this.btnMortagege.Text = "Mortgage";
            this.btnMortagege.UseVisualStyleBackColor = true;
            this.btnMortagege.Click += new System.EventHandler(this.btnMortagege_Click);
            // 
            // btnAuto
            // 
            this.btnAuto.Location = new System.Drawing.Point(522, 293);
            this.btnAuto.Name = "btnAuto";
            this.btnAuto.Size = new System.Drawing.Size(112, 34);
            this.btnAuto.TabIndex = 10;
            this.btnAuto.Text = "Auto";
            this.btnAuto.UseVisualStyleBackColor = true;
            this.btnAuto.Click += new System.EventHandler(this.btnAuto_Click);
            // 
            // lblMothlyPayment
            // 
            this.lblMothlyPayment.AutoSize = true;
            this.lblMothlyPayment.Location = new System.Drawing.Point(187, 376);
            this.lblMothlyPayment.Name = "lblMothlyPayment";
            this.lblMothlyPayment.Size = new System.Drawing.Size(175, 25);
            this.lblMothlyPayment.TabIndex = 11;
            this.lblMothlyPayment.Text = "Monthly Payment $ :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 456);
            this.Controls.Add(this.lblMothlyPayment);
            this.Controls.Add(this.btnAuto);
            this.Controls.Add(this.btnMortagege);
            this.Controls.Add(this.textDownPayment);
            this.Controls.Add(this.textInterestRate);
            this.Controls.Add(this.textTermsinYears);
            this.Controls.Add(this.textLoanAmount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblLoanAmount);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLoanAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textLoanAmount;
        private System.Windows.Forms.TextBox textTermsinYears;
        private System.Windows.Forms.TextBox textInterestRate;
        private System.Windows.Forms.TextBox textDownPayment;
        private System.Windows.Forms.Button btnMortagege;
        private System.Windows.Forms.Button btnAuto;
        private System.Windows.Forms.Label lblMothlyPayment;
    }
}

