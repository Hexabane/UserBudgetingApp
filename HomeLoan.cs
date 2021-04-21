//Kunal Goyal
//18021553
//POE Task 1

using System;

namespace UserBudgetingApp
{//start of namespace

    class HomeLoan : Expense //This class inherits from Expense Class
    {//start of class

        //private variables created.
        private double propertyPrice;
        private double depositMade;
        private double interestRate;
        private double months;

        private bool check = true;

        //A constructor that takes in values from the addUser Class. and the inherited variables from the Expense Class.
        public HomeLoan(string name, double monthlyIncome, double monthlyTaxDeducted, double[] monthlyExpenses, double propertyPrice, double depositMade, double interestRate, double months) : base (name, monthlyIncome, monthlyTaxDeducted, monthlyExpenses)
        {
            this.PropertyPrice = propertyPrice;
            this.DepositMade = depositMade;
            this.InterestRate = interestRate;
            this.Months = months;
        }

        //Get And Set Variables
        public double PropertyPrice { get => propertyPrice; set => propertyPrice = value; }
        public double DepositMade { get => depositMade; set => depositMade = value; }
        public double InterestRate { get => interestRate; set => interestRate = value; }
        public double Months { get => months; set => months = value; }
        public bool Check { get => check; set => check = value; }

        //Get Variable to Store the Method Calculated Values.
        public double MonthlyHomeLoanRepayments { get => monthlyHomeLoanRepaymentsCalc(); }
        public double FinalAmount { get => displayFinalAmountCalc(); }
        public string AlertMessage { get => displayAlertMessage(); }


        //monthlyHomeLoanRepaymentsCalc() calculates the installments based on the values entered by the user.
        public double monthlyHomeLoanRepaymentsCalc()
        {//start of monthlyHomeLoanRepaymentsCalc() method.

            double propertyPriceAfterDeposit = PropertyPrice - DepositMade;
            double numberOfYears = Months / 12.0;
            double calculationOfLoanRepayment = propertyPriceAfterDeposit * (1 + (InterestRate / 100) * (numberOfYears));
            double monthlyInstallments = calculationOfLoanRepayment / Months;
            
            //this if statement checks if the monthlyInstallments are 3rd of the grossMonthlyIncome.
            if(monthlyInstallments > (GrossMonthlyIncome/3))
            {
                Check = false; //if it is the 3rd of the grossMonthlyIncome then it sets this vairable to false in turn prompts a error to the user.
                monthlyInstallments = 0;
            }

            //returning a 2 decimal format value  
            //(C# Cookbook, 2021),  Reference in ReferenceList textfile
            return Math.Round(monthlyInstallments, 2);  

        }//end of monthlyHomeLoanRepaymentsCalc() method.


        //displayAlertMessage() is a method that displays a warning message if the variable 'Check' is false.
        public string displayAlertMessage()
        {//start of displayAlertMessage() method.

            string alert = "";

            if(Check == false)
            {
                alert = "Your Home Loan Installments are more than the 3rd of your Gross Income Therefore, Home Loan is not possible!";
            }
            return alert;
        }//end of displayAlertMessage() method.


        //displayFinalAmountCalc() is a method that calculates the final amount/money that the user will be left with monthly.
        public double displayFinalAmountCalc()
        {//start of displayFinalAmountCalc() method.
            double moneyLeft = GrossMonthlyIncome - MonthlyTaxDeducted - TotalMonthlyExpenses - MonthlyHomeLoanRepayments;
            

            return moneyLeft;
        }//end of displayFinalAmountCalc() method.

    }//end of HomeLoan Class.

}//end of namespace.
