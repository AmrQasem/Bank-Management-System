using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Bank_Mangement_System
{
    public partial class Form_8 : Form
    {
        public string User_Name { set; get; }
        public string PassWord { set; get; }
        Client newClient = new Client();
        public Form_8(string UN, string PW)
        {
            InitializeComponent();
            this.User_Name = UN;
            this.PassWord = PW;
            Registration RClient = new Registration();
            newClient = RClient.Log_in(this.User_Name, this.PassWord);
            dataGridView1.Rows.Clear();
            dataGridView1.Rows.Add(newClient.Name, newClient.Address, newClient.Phone, newClient.Balance, Client.Account_Number, newClient.OldLoan);
        }
        
       
        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form1 f1 = new Form1();
            f1.Visible = true;
        }

        private void btnWithdrow_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form9 f9 = new Form9(newClient.UserName,newClient.Password);
            f9.Visible = true;
            
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form10 f10 = new Form10(newClient.UserName, newClient.Password);
            f10.Visible = true;
        }

        private void btnLoan_Click(object sender, EventArgs e)
        {
            if (newClient.OldLoan == 0)
            {
                this.Visible = false;
                Form11 f11 = new Form11(newClient.UserName, newClient.Password);
                f11.Visible = true;
            }
            else
            {
                MessageBox.Show("Sorry you can't take loan.!");
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(newClient.OldLoan>0)
            {
                this.Visible=false;
                Form13 f13 = new Form13(newClient.UserName, newClient.Password);
                f13.Visible=true;
            }
            else
            {
                MessageBox.Show("You Do not have loan to pay");
            }
        }
    }
}
