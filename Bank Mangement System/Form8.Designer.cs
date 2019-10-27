namespace Bank_Mangement_System
{
    partial class Form_8
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Adress = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Balance = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.AccountNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Loan = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnWithdrow = new System.Windows.Forms.Button();
			this.btnLoan = new System.Windows.Forms.Button();
			this.btnDeposit = new System.Windows.Forms.Button();
			this.btnLogout = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.Adress,
            this.Phone,
            this.Balance,
            this.AccountNumber,
            this.Loan});
			this.dataGridView1.Location = new System.Drawing.Point(12, 12);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(645, 94);
			this.dataGridView1.TabIndex = 0;
			// 
			// Name
			// 
			this.Name.HeaderText = "Name";
			this.Name.Name = "Name";
			// 
			// Adress
			// 
			this.Adress.HeaderText = "Adress";
			this.Adress.Name = "Adress";
			// 
			// Phone
			// 
			this.Phone.HeaderText = "Phone";
			this.Phone.Name = "Phone";
			// 
			// Balance
			// 
			this.Balance.HeaderText = "Balance";
			this.Balance.Name = "Balance";
			// 
			// AccountNumber
			// 
			this.AccountNumber.HeaderText = "Account Number";
			this.AccountNumber.Name = "AccountNumber";
			// 
			// Loan
			// 
			this.Loan.HeaderText = "Loan";
			this.Loan.Name = "Loan";
			// 
			// btnWithdrow
			// 
			this.btnWithdrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnWithdrow.Location = new System.Drawing.Point(22, 243);
			this.btnWithdrow.Name = "btnWithdrow";
			this.btnWithdrow.Size = new System.Drawing.Size(92, 34);
			this.btnWithdrow.TabIndex = 1;
			this.btnWithdrow.Text = "Withdrow";
			this.btnWithdrow.UseVisualStyleBackColor = true;
			this.btnWithdrow.Click += new System.EventHandler(this.btnWithdrow_Click);
			// 
			// btnLoan
			// 
			this.btnLoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLoan.Location = new System.Drawing.Point(173, 243);
			this.btnLoan.Name = "btnLoan";
			this.btnLoan.Size = new System.Drawing.Size(92, 34);
			this.btnLoan.TabIndex = 2;
			this.btnLoan.Text = "Loan";
			this.btnLoan.UseVisualStyleBackColor = true;
			this.btnLoan.Click += new System.EventHandler(this.btnLoan_Click);
			// 
			// btnDeposit
			// 
			this.btnDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDeposit.Location = new System.Drawing.Point(339, 243);
			this.btnDeposit.Name = "btnDeposit";
			this.btnDeposit.Size = new System.Drawing.Size(92, 34);
			this.btnDeposit.TabIndex = 3;
			this.btnDeposit.Text = "Deposit";
			this.btnDeposit.UseVisualStyleBackColor = true;
			this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
			// 
			// btnLogout
			// 
			this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLogout.Location = new System.Drawing.Point(570, 300);
			this.btnLogout.Name = "btnLogout";
			this.btnLogout.Size = new System.Drawing.Size(87, 34);
			this.btnLogout.TabIndex = 4;
			this.btnLogout.Text = "Log Out";
			this.btnLogout.UseVisualStyleBackColor = true;
			this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(490, 243);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(92, 34);
			this.button1.TabIndex = 5;
			this.button1.Text = "Pay loan";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Form_8
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.SeaShell;
			this.ClientSize = new System.Drawing.Size(669, 346);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.btnLogout);
			this.Controls.Add(this.btnDeposit);
			this.Controls.Add(this.btnLoan);
			this.Controls.Add(this.btnWithdrow);
			this.Controls.Add(this.dataGridView1);
			this.Name = "Form8";
			this.Text = "Choose";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnWithdrow;
        private System.Windows.Forms.Button btnLoan;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adress;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Balance;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Loan;
        private System.Windows.Forms.Button button1;
        //private System.Windows.Forms.DataGridViewTextBoxColumn Name;
    }
}