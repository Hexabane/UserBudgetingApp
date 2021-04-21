using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserBudgetingApp
{//start of namespace
    public partial class ViewUser : Form
    {//start of calss
        public ViewUser()
        {
            InitializeComponent();
            populateListBox(); //populates list box when the form launches.
            hideComponents(); //hides the relative components when the form launcheds.
        }

        /*
        |=====================================================================================================================|
        | populateListBox() is a method that populates the listbox by using a foreach loop that loops through the wanted data |
        | which is stored in the List.                                                                                        |      
        |=====================================================================================================================|
        */
        public void populateListBox()
        {//start of populateListBox() method

            foreach(HomeLoan item in ListHandler.homeLoanList)
            {//start of first foreachloop

                lbViewUsers.Items.Add(item.Name.ToUpper());

            }//end of first foreachloop

            foreach (Rent item in ListHandler.rentList)
            {//start of second foreachloop

                lbViewUsers.Items.Add(item.Name.ToUpper());

            }//end of second foreachloop

        }//end of populateListBox() method

        /*
       |=====================================================================================================================|
       | This action method stores in the textfields to display data based on what the user has selected from the ListBox, It|
       | Uses Linq to search and sort the GenericList which has data for multiple users and display accordingly.             |      
       |=====================================================================================================================|
       */
        private void lbViewUsers_SelectedIndexChanged(object sender, EventArgs e)
        {//start of method

            try
            {//start of try statement

                string selectedItem = lbViewUsers.SelectedItem.ToString(); //gets the selected item by the user from the listbox


                List<HomeLoan> homeLoanUserData = ListHandler.homeLoanList; //a new homeLoanList is created to store the main list with homeLoanData.

                //** (Corey, 2017). Reference in ReferenceList TextFile. **
                homeLoanUserData = homeLoanUserData.Where(x => x.Name.ToUpper() == selectedItem).ToList(); //LINQ statement to sort through the list and look  for the selected user and respective data and store it with that data.

                foreach (var HomeLoan in homeLoanUserData)
                {//start of first foreach loop for Homeloan Data.

                    labelHL.Visible = true;
                    labelHLR.Visible = true;
                    tbMonthlyLoan.Visible = true;
                    labelRent.Visible = false;
                    labelRentR.Visible = false;
                    tbMontlyRent.Visible = false;

                    tbName.Text = HomeLoan.Name.ToString();
                    tbMonthlyIncome.Text = HomeLoan.GrossMonthlyIncome.ToString();
                    tbTotalMonthlyExpenses.Text = HomeLoan.TotalMonthlyExpenses.ToString();
                    tbTaxDeducted.Text = HomeLoan.MonthlyTaxDeducted.ToString();
                    tbMonthlyLoan.Text = HomeLoan.MonthlyHomeLoanRepayments.ToString("F");
                    tbMoneyLeft.Text = HomeLoan.FinalAmount.ToString();

                }//end of fist foreach loop for Homeloan data.


                List<Rent> rentData = ListHandler.rentList; //a new rentList is created to store the main list with rentData.

                //** (Corey, 2017). Reference in ReferenceList TextFile.**
                rentData = rentData.Where(x => x.Name.ToUpper() == selectedItem).ToList(); //LINQ statement to sort through the list and look  for the selected user and respective data and store it with that data.

                foreach (var Rent in rentData)
                {//start of second foreach loop.

                    labelHL.Visible = false;
                    labelHLR.Visible = false;
                    tbMonthlyLoan.Visible = false;
                    labelRent.Visible = true;
                    labelRentR.Visible = true;
                    tbMontlyRent.Visible = true;

                    tbName.Text = Rent.Name.ToString();
                    tbMonthlyIncome.Text = Rent.GrossMonthlyIncome.ToString();
                    tbTotalMonthlyExpenses.Text = Rent.TotalMonthlyExpenses.ToString();
                    tbTaxDeducted.Text = Rent.MonthlyTaxDeducted.ToString();
                    tbMontlyRent.Text = Rent.MonthlyRent.ToString();
                    tbMoneyLeft.Text = Rent.FinalAmount.ToString();

                }//end of second foreach loop.

            }//end of try statement

            catch(NullReferenceException)
            {
                //ignore exception for whenever a blank area is clicked on the ListBox.
            }

        }//end of method.



        //hides the Rent and homeloan related components on the Add User Form
        public void hideComponents()
        {//start of hideComponents() method

            labelHL.Visible = false;
            labelHLR.Visible = false;
            tbMonthlyLoan.Visible = false;
            labelRent.Visible = false;
            labelRentR.Visible = false;
            tbMontlyRent.Visible = false;

        }//end of hideComponents() method


    }//end of class


}//end of namespace
