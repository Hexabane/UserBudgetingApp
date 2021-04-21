//Kunal Goyal
//18021553
//POE Task 1

namespace UserBudgetingApp
{//start of namespace 
    class Rent : Expense //This Class Inherits from Expense Class
    {//start of Rent Class.

        
        private double monthlyRent; 

        //A constructor that takes in values from the addUser Class. and the inherited variables from the Expense Class.
        public Rent(string name, double monthlyIncome, double monthlyTaxDeducted, double[] monthlyExpenses, double monthlyRent) : base(name, monthlyIncome, monthlyTaxDeducted, monthlyExpenses)
        {
            this.MonthlyRent = monthlyRent;
        }

        //Get And Set Variables
        public double MonthlyRent { get => monthlyRent; set => monthlyRent = value; }

        //Get Variable to Store the Method Calcs.
        public double FinalAmount { get => displayFinalAmountCalc(); }

       
        //displayFinalAmountCalc() is a method that calculates the final amount/money that the user will be left with monthly.
        public double displayFinalAmountCalc()
        {
            double moneyLeft = GrossMonthlyIncome - MonthlyTaxDeducted - TotalMonthlyExpenses - MonthlyRent;
            

            return moneyLeft;
        }

    }//end of Rent Class.

}//end of namespace.
