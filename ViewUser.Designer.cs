
namespace UserBudgetingApp
{
    partial class ViewUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewUser));
            this.lbViewUsers = new System.Windows.Forms.ListBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbTotalMonthlyExpenses = new System.Windows.Forms.TextBox();
            this.tbMonthlyIncome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelRent = new System.Windows.Forms.Label();
            this.tbMontlyRent = new System.Windows.Forms.TextBox();
            this.labelHL = new System.Windows.Forms.Label();
            this.tbMonthlyLoan = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbMoneyLeft = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.labelHLR = new System.Windows.Forms.Label();
            this.labelRentR = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbTaxDeducted = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbViewUsers
            // 
            this.lbViewUsers.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbViewUsers.FormattingEnabled = true;
            this.lbViewUsers.ItemHeight = 17;
            this.lbViewUsers.Location = new System.Drawing.Point(25, 95);
            this.lbViewUsers.Name = "lbViewUsers";
            this.lbViewUsers.Size = new System.Drawing.Size(123, 378);
            this.lbViewUsers.TabIndex = 0;
            this.lbViewUsers.SelectedIndexChanged += new System.EventHandler(this.lbViewUsers_SelectedIndexChanged);
            // 
            // tbName
            // 
            this.tbName.Enabled = false;
            this.tbName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(468, 105);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(215, 30);
            this.tbName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(219, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(219, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Total Monthly Expenses :";
            // 
            // tbTotalMonthlyExpenses
            // 
            this.tbTotalMonthlyExpenses.Enabled = false;
            this.tbTotalMonthlyExpenses.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTotalMonthlyExpenses.Location = new System.Drawing.Point(468, 210);
            this.tbTotalMonthlyExpenses.Name = "tbTotalMonthlyExpenses";
            this.tbTotalMonthlyExpenses.Size = new System.Drawing.Size(215, 30);
            this.tbTotalMonthlyExpenses.TabIndex = 11;
            // 
            // tbMonthlyIncome
            // 
            this.tbMonthlyIncome.Enabled = false;
            this.tbMonthlyIncome.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMonthlyIncome.Location = new System.Drawing.Point(468, 156);
            this.tbMonthlyIncome.Name = "tbMonthlyIncome";
            this.tbMonthlyIncome.Size = new System.Drawing.Size(215, 30);
            this.tbMonthlyIncome.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(219, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Gross Monthly Income : ";
            // 
            // labelRent
            // 
            this.labelRent.AutoSize = true;
            this.labelRent.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRent.Location = new System.Drawing.Point(219, 319);
            this.labelRent.Name = "labelRent";
            this.labelRent.Size = new System.Drawing.Size(113, 20);
            this.labelRent.TabIndex = 14;
            this.labelRent.Text = "Monthly Rent :";
            // 
            // tbMontlyRent
            // 
            this.tbMontlyRent.Enabled = false;
            this.tbMontlyRent.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMontlyRent.Location = new System.Drawing.Point(468, 314);
            this.tbMontlyRent.Name = "tbMontlyRent";
            this.tbMontlyRent.Size = new System.Drawing.Size(215, 30);
            this.tbMontlyRent.TabIndex = 13;
            // 
            // labelHL
            // 
            this.labelHL.AutoSize = true;
            this.labelHL.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHL.Location = new System.Drawing.Point(219, 370);
            this.labelHL.Name = "labelHL";
            this.labelHL.Size = new System.Drawing.Size(205, 20);
            this.labelHL.TabIndex = 16;
            this.labelHL.Text = "Monthly Loan Installments :";
            // 
            // tbMonthlyLoan
            // 
            this.tbMonthlyLoan.Enabled = false;
            this.tbMonthlyLoan.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMonthlyLoan.Location = new System.Drawing.Point(468, 365);
            this.tbMonthlyLoan.Name = "tbMonthlyLoan";
            this.tbMonthlyLoan.Size = new System.Drawing.Size(215, 30);
            this.tbMonthlyLoan.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(213, 423);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(184, 28);
            this.label6.TabIndex = 18;
            this.label6.Text = "Total Money Left :";
            // 
            // tbMoneyLeft
            // 
            this.tbMoneyLeft.Enabled = false;
            this.tbMoneyLeft.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMoneyLeft.Location = new System.Drawing.Point(446, 425);
            this.tbMoneyLeft.Name = "tbMoneyLeft";
            this.tbMoneyLeft.Size = new System.Drawing.Size(215, 30);
            this.tbMoneyLeft.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(421, 433);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(19, 17);
            this.label9.TabIndex = 22;
            this.label9.Text = "R";
            // 
            // labelHLR
            // 
            this.labelHLR.AutoSize = true;
            this.labelHLR.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.labelHLR.Location = new System.Drawing.Point(443, 373);
            this.labelHLR.Name = "labelHLR";
            this.labelHLR.Size = new System.Drawing.Size(19, 17);
            this.labelHLR.TabIndex = 23;
            this.labelHLR.Text = "R";
            // 
            // labelRentR
            // 
            this.labelRentR.AutoSize = true;
            this.labelRentR.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.labelRentR.Location = new System.Drawing.Point(443, 322);
            this.labelRentR.Name = "labelRentR";
            this.labelRentR.Size = new System.Drawing.Size(19, 17);
            this.labelRentR.TabIndex = 24;
            this.labelRentR.Text = "R";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(443, 218);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(19, 17);
            this.label12.TabIndex = 25;
            this.label12.Text = "R";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(443, 164);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(19, 17);
            this.label13.TabIndex = 26;
            this.label13.Text = "R";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Verdana", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(266, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(212, 40);
            this.label14.TabIndex = 27;
            this.label14.Text = "USER LIST";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(443, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 17);
            this.label4.TabIndex = 30;
            this.label4.Text = "R";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(219, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 20);
            this.label5.TabIndex = 29;
            this.label5.Text = "Monthly Tax Deducted :";
            // 
            // tbTaxDeducted
            // 
            this.tbTaxDeducted.Enabled = false;
            this.tbTaxDeducted.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTaxDeducted.Location = new System.Drawing.Point(468, 261);
            this.tbTaxDeducted.Name = "tbTaxDeducted";
            this.tbTaxDeducted.Size = new System.Drawing.Size(215, 30);
            this.tbTaxDeducted.TabIndex = 28;
            // 
            // ViewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 514);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbTaxDeducted);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.labelRentR);
            this.Controls.Add(this.labelHLR);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbMoneyLeft);
            this.Controls.Add(this.labelHL);
            this.Controls.Add(this.tbMonthlyLoan);
            this.Controls.Add(this.labelRent);
            this.Controls.Add(this.tbMontlyRent);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbTotalMonthlyExpenses);
            this.Controls.Add(this.tbMonthlyIncome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbViewUsers);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewUser";
            this.Text = "ViewUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbViewUsers;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbTotalMonthlyExpenses;
        private System.Windows.Forms.TextBox tbMonthlyIncome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelRent;
        private System.Windows.Forms.TextBox tbMontlyRent;
        private System.Windows.Forms.Label labelHL;
        private System.Windows.Forms.TextBox tbMonthlyLoan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbMoneyLeft;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelHLR;
        private System.Windows.Forms.Label labelRentR;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbTaxDeducted;
    }
}