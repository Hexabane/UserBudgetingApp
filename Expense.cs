//Kunal Goyal
//18021553
//POE Task 1

namespace UserBudgetingApp
{//start of namespace
    abstract class Expense //This class is A Parent Class therfore, Abstract.
    {//start of Class Expense

        //private variables created.
        private string name;
        private double grossMonthlyIncome;
        private double monthlyTaxDeducted;
        private double[] monthlyExpenses;


        //A constructor that takes in values from the Child Classes Like rent And HomeLoan.
        protected Expense(string name, double grossMonthlyIncome, double monthlyTaxDeducted, double[] monthlyExpenses)
        {
            this.Name = name;
            this.GrossMonthlyIncome = grossMonthlyIncome;
            this.MonthlyTaxDeducted = monthlyTaxDeducted;
            this.MonthlyExpenses = monthlyExpenses;
        }


        //Get And Set Variables
        public string Name { get => name; set => name = value; }
        public double GrossMonthlyIncome { get => grossMonthlyIncome; set => grossMonthlyIncome = value; }
        public double MonthlyTaxDeducted { get => monthlyTaxDeducted; set => monthlyTaxDeducted = value; }
        public double[] MonthlyExpenses { get => monthlyExpenses; set => monthlyExpenses = value; }

        //Get Variable to Store the Method Calculated Values.
        public double TotalMonthlyExpenses { get => totalMonthlyExpensesCalc(); }

        //totalMonthlyExpensesCalc() is a method that calculates the total Regular monthly expenses by the user.
        private double totalMonthlyExpensesCalc()
        {//start of method

            double totalMonthlyExpenses = 0;

            //for loop is created to add all the values stored in the  MonthlyExpenses Array.
            for (int i = 0; i < MonthlyExpenses.Length; i++)
            {
                totalMonthlyExpenses += MonthlyExpenses[i];
            }

            return totalMonthlyExpenses;

        }//end of method

    }//end of Class Expense

}//end of Namespace
