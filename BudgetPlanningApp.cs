//Kunal Goyal
//18021553
//POE Task 1

using System;
using System.Windows.Forms;

namespace UserBudgetingApp
{ //start of namespace
    public partial class BudgetPlanningApp : Form
    {//start of class
        public BudgetPlanningApp()
        {
            InitializeComponent();
        }

        //Upon cicking the Add User button A form is popped up to user to fill in data.
        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            AddUser form = new AddUser();
            form.Show(); //Shows the AddUser Form

        }

        //Upon clicking the View User button a form is popper up for the user to View the stored data.
        private void buttonViewUsers_Click(object sender, EventArgs e)
        {
            ViewUser form = new ViewUser();
            form.Show(); //Shows the ViewUser Form
        }

        //This button in the menu bar restarts the Application
        private void menuItemRestart_Click(object sender, EventArgs e)
        {
            Application.Restart(); //Restarts the Application
        }

        //This button in the menu bar exits the Application
        private void menuItemExit_Click(object sender, EventArgs e)
        {
            Application.Exit(); //Exits the Application
        }

    
        
    } //end of class

} //end of namespace
