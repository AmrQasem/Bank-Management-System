using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_Mangement_System
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text.Any() == false || txtPassword.Text.Any() == false)
            {
                MessageBox.Show("Please enter a valid Name and ID!");
                return;
            }
            string username, password;
            username = txtUserName.Text;
            password = txtPassword.Text;
            Registration RClient = new Registration();
            Client user = RClient.Log_in(username, password);
            if(user.IsActive()==true && user.Name!= null)
            {
                this.Visible = false;
                Form_8 f8 =new Form_8(user.UserName,user.Password);
                f8.Visible = true;
            }
            else if(user.IsActive()==false)
            {
                MessageBox.Show("Your account is closed");
                return;
            }
            else
            {
                MessageBox.Show("No data found!");
                return;
            }
            
        }

        private void btnCreateaccount_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form7 f7 = new Form7();
            f7.Visible = true;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form1 f1 = new Form1();
            f1.Visible = true;
        }

        
    }
}
