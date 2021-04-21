//Kunal Goyal
//18021553
//Prog Task 1

using System;
using System.Windows.Forms;

namespace UserBudgetingApp
{//start of namespace
    public partial class AddUser : Form
    {//start of class
        public AddUser()
        {
            InitializeComponent();
            hideComponents(); //hides the components on initial launch
        }

        //if the user selects the Renting Porperty radio button then it will make the related fields appear
        private void rbRentingProperty_CheckedChanged(object sender, EventArgs e)
        {

            gbRenting.Visible = true;
            gbHomeLoan.Visible = false;
            buttonSubmit.Visible = true;
        }

        //if the user selects the Homeloan radio button then it will make the related fields appear
        private void rbBuyingProperty_CheckedChanged(object sender, EventArgs e)
        {
            gbHomeLoan.Visible = true;
            gbRenting.Visible = false;
            buttonSubmit.Visible = true;
        }

        /*
        |=====================================================================================================================|
        | This Is a method for the action that takes place when the user clicks on the Submit button after inputting all data |
        | This Action Method involves of Taking in the user data and storing them in the Respective classes and then into the |
        | List and throws Errors and Exception upon wrong input. Then Finally gives a Report based on the data the user has   |
        | entered.                                                                                                            |
        |=====================================================================================================================|
        */
        private void buttonSubmit_Click(object sender, EventArgs e)
        {//start of buttonSubmit Method

            try
            {//start of try statement

                if (rbRentingProperty.Checked == true) //If statment chekcks if the user selects the rent Radio button
                { //start of first if statement

                    tbPriceOfProp.ResetText();
                    tbDepositMade.ResetText();
                    tbInterestRate.ResetText();
                    tbRepaymentMonths.ResetText();

                    //Stores the data from text boxes that the user has entered into variables
                    string rentName = tbName.Text;
                    double rentMonthlyIncome = Convert.ToDouble(tbMonthlyIncome.Text);
                    double rentMonthlyTaxDeducted = Convert.ToDouble(tbTaxDeducted.Text);

                    //stores the regular monthly expenses into an Array
                    double[] rentMonthlyExpense = new double[5];
                    rentMonthlyExpense[0] = Convert.ToDouble(tbGroceries.Text);
                    rentMonthlyExpense[1] = Convert.ToDouble(tbWaterAndLights.Text);
                    rentMonthlyExpense[2] = Convert.ToDouble(tbTravelCosts.Text);
                    rentMonthlyExpense[3] = Convert.ToDouble(tbTelecommunications.Text);
                    rentMonthlyExpense[4] = Convert.ToDouble(tbOtherExpenses.Text);

                    
                    double rent = Convert.ToDouble(tbMonthlyRent.Text);

                    //the Variables with values are passed through the object to the Rent Class
                    Rent rentData = new Rent(rentName, rentMonthlyIncome, rentMonthlyTaxDeducted, rentMonthlyExpense, rent);

                    //This if statment checks whether the Final amount/ money left for the month is negative
                    if (rentData.FinalAmount < 0)
                    {//start of if statment

                        throw new NegativeValueException(); //throws a new custom exception in a case of negative monthly balance.

                    }//end of if statment

                    ListHandler.rentList.Add(rentData); //Adding the Rent Object to the RentList in the ListHandler Class

                   
                    //storing the display message in a string variable.
                    string output = ("===========================" + "\n" +
                                     "NAME  : " + rentData.Name.ToUpper() + "\n" +
                                     "------------------------------------------------------" + "\n" +
                                     "Gross Monthly Income \t : R" + rentData.GrossMonthlyIncome + "\n" +
                                     "Monthly Tax And Expenses \t : R" + (rentData.MonthlyTaxDeducted + rentData.TotalMonthlyExpenses) + "\n" +
                                     "Monthly Rent \t\t : R" + rentData.MonthlyRent + "\n" +
                                     "------------------------------------------------------" + "\n" +
                                     "Net Income After Deductions : R" + rentData.FinalAmount + "\n" +
                                     "===========================");

                    //the display of a report after the user clicks on the submit button.
                    MessageBox.Show(output, "REPORT", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close(); //closes the Adduser Form in the end.


                }//end of first if statment.

                if (rbBuyingProperty.Checked == true) //If statment chekcks if the user selects the rent Buying property button.
                {//start of second if statement.



                    //Stores the data from text boxes that the user has entered into variables
                    string hlName = tbName.Text;
                    double hlMonthlyIncome = Convert.ToDouble(tbMonthlyIncome.Text);
                    double hlMonthlyTaxDeducted = Convert.ToDouble(tbTaxDeducted.Text);

                    //stores the regular monthly expenses into an Array
                    double[] hlMonthlyExpense = new double[5];
                    hlMonthlyExpense[0] = Convert.ToDouble(tbGroceries.Text);
                    hlMonthlyExpense[1] = Convert.ToDouble(tbWaterAndLights.Text);
                    hlMonthlyExpense[2] = Convert.ToDouble(tbTravelCosts.Text);
                    hlMonthlyExpense[3] = Convert.ToDouble(tbTelecommunications.Text);
                    hlMonthlyExpense[4] = Convert.ToDouble(tbOtherExpenses.Text);

                    //stores the Home Loan related data into the variables below
                    double propertyPrice = Convert.ToDouble(tbPriceOfProp.Text);
                    double deposit = Convert.ToDouble(tbDepositMade.Text);
                    double interestRate = Convert.ToDouble(tbInterestRate.Text);
                    double repaymentMonths = Convert.ToDouble(tbRepaymentMonths.Text);

                    //the Variables with values are passed through the object to the HomeLoan Class
                    HomeLoan hlData = new HomeLoan(hlName, hlMonthlyIncome, hlMonthlyTaxDeducted, hlMonthlyExpense, propertyPrice, deposit, interestRate, repaymentMonths);

                    //This if statment checks whether the Final amount/ money left for the month is negative
                    if (hlData.FinalAmount < 0)
                    {//start of if statement

                        throw new NegativeValueException(); //throws a new custom exception in a case of negative monthly balance.

                    }//end of if statement

                    ListHandler.homeLoanList.Add(hlData); //Adding the HomeLoan Object to the HomeLoanList in the ListHandler Class.

                    //this if statement checks whether the monthly home loan installments are third of the gross monthly income after getting a boolean check in the homeloan class.
                    if (hlData.Check == false)
                    {//start of if statement

                        MessageBox.Show(hlData.AlertMessage, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }//end of if statement

                    //storing the display message in a string variable.
                    string output = ("================================" + "\n" +
                                     "NAME  : " + hlData.Name.ToUpper() + "\n" +
                                     "-------------------------------------------------------------" + "\n" +
                                     "Gross Monthly Income \t : R" + hlData.GrossMonthlyIncome + "\n" +
                                     "Monthly Tax And Expenses \t : R" + (hlData.MonthlyTaxDeducted + hlData.TotalMonthlyExpenses) + "\n" +
                                     "Monthly Loan Installments    : R" + hlData.MonthlyHomeLoanRepayments + "\n" +
                                     "-------------------------------------------------------------" + "\n" +
                                     "Net Income After Deductions : R" + hlData.FinalAmount + "\n" +
                                     "================================");

                    //the display of a report after the user clicks on the submit button.
                    MessageBox.Show(output, "REPORT", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close(); //closes the Adduser Form in the end.

                }//end of second if statement

            }//end of try statment

            //this catch statement throws an error and resets the text fields if the user has inputted wrong syntax or the text boxes have been left empty.
            catch (FormatException)
            {//start of first catch statement

                MessageBox.Show("Please Enter A Correct Syntax!!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                resetTextBoxes();
                hideComponents();

            }//end of the first catch statement

            catch (NegativeValueException output)
            {//start of seconf catch statement

                MessageBox.Show(output.Message, "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                resetTextBoxes();
                hideComponents();
               
            } //end of second catch statement.
            

        }//end of buttonSubmit Method.


        //hides the Rent and homeloan related components on the Add User Form
        public void hideComponents()
        {//start of hideComponents() method

            gbRenting.Visible = false;
            gbHomeLoan.Visible = false;
            buttonSubmit.Visible = false;

        }//end of hideComponents() method


        //resets all the text fields.
        public void resetTextBoxes()
        {//start of resetTextBoxes() method

            tbMonthlyIncome.ResetText();
            tbTaxDeducted.ResetText();
            tbGroceries.ResetText();
            tbWaterAndLights.ResetText();
            tbTelecommunications.ResetText();
            tbTravelCosts.ResetText();
            tbOtherExpenses.ResetText();
            tbPriceOfProp.ResetText();
            tbDepositMade.ResetText();
            tbInterestRate.ResetText();
            tbRepaymentMonths.ResetText();
            tbMonthlyRent.ResetText();
            rbBuyingProperty.Checked = false;
            rbRentingProperty.Checked = false;
            

        }//end of resetTextBoxes() method

    }//end of class

}//end of namespace
