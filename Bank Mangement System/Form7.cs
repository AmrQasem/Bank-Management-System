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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string username; string password; string name; string phone; string address; double balance;
            if( txtUserName.Text.Any()==false || txtPassword.Text.Any()==false||txtName.Text.Any()==false||txtPhone.Text.Any()==false||txtAddress.Text.Any()==false||txtBalance.Text.Any()==false)
            {
                MessageBox.Show("Make sure you enter all data");
                return;
            }
            username = txtUserName.Text;
            password = txtPassword.Text;
            name = txtName.Text;
            phone = txtPhone.Text;
            address = txtAddress.Text;
            balance = double.Parse(txtBalance.Text);
            //bool newACcState = true;

            Client user = new Client ();
            user.UserName = username;
            user.Password = password;
            user.Name = name;
            user.Phone = phone;
            user.Address = address;
            user.Balance = balance;
            user.add();
            MessageBox.Show("Successfully Added");
            this.Visible = false;
            Form6 F6 = new Form6();
            F6.Visible = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form6 f6 = new Form6();
            f6.Visible = true;
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void txtBalance_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != '.')
            {
                e.Handled = true;
            }
        }
    }
}
