using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loan_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnMortagege_Click(object sender, EventArgs e)
        {
            // create some local variables
            double loanAmount = 0;
            double downPayment = 0;
            double interestRate = 0;
            double monthlyPayment = 0;
            int terms = 0;


            //validation
            
                if (!String.IsNullOrEmpty(textLoanAmount.Text))
                    loanAmount = Convert.ToDouble(textLoanAmount.Text);

                if (!String.IsNullOrEmpty(textDownPayment.Text))
                    downPayment = Convert.ToDouble(textDownPayment.Text);

                if (!String.IsNullOrEmpty(textInterestRate.Text))
                    interestRate = Convert.ToDouble(textInterestRate.Text);

                if (!String.IsNullOrEmpty(textTermsinYears.Text))
                    terms = Convert.ToInt32(textTermsinYears.Text);
           

               
           
         


            int termsinMonths = terms * 12;
            monthlyPayment = (loanAmount - downPayment) * (Math.Pow((1 + interestRate / 12),
            termsinMonths) * interestRate) / (12 * (Math.Pow((1 + interestRate / 12), termsinMonths) - 1));
            monthlyPayment = Math.Round(monthlyPayment, 2);
            lblMothlyPayment.Text = String.Format("Monthly Payment: R {0}", monthlyPayment.ToString());



        }

        private void btnAuto_Click(object sender, EventArgs e)
        {

            // create some local variables
            double loanAmount = 0;
            double downPayment = 0;
            double interestRate = 0;
            double monthlyPayment = 0;
            int terms = 0;


            //validation

            if (!String.IsNullOrEmpty(textLoanAmount.Text))
                loanAmount = Convert.ToDouble(textLoanAmount.Text);

            if (!String.IsNullOrEmpty(textDownPayment.Text))
                downPayment = Convert.ToDouble(textDownPayment.Text);

            if (!String.IsNullOrEmpty(textInterestRate.Text))
                interestRate = Convert.ToDouble(textInterestRate.Text);

            if (!String.IsNullOrEmpty(textTermsinYears.Text))
                terms = Convert.ToInt32(textTermsinYears.Text);


            int termsinMonths = terms * 12;
            monthlyPayment = (loanAmount - downPayment) * (Math.Pow((1 + interestRate / 12),
            termsinMonths) * interestRate) / (12 * (Math.Pow((1 + interestRate / 12), termsinMonths) - 1));
            monthlyPayment = Math.Round(monthlyPayment, 2);
            lblMothlyPayment.Text = String.Format( monthlyPayment.ToString());
        }
    }
}
