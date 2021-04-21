//Kunal Goyal
//18021553
//POE Task 1

using System;
using System.Windows.Forms;

namespace UserBudgetingApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new BudgetPlanningApp());
        }
    }
}
