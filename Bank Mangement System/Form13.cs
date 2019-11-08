using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Bank_Mangement_System
{
    public partial class Form13 : Form
    {
        public string User_Name { set; get; }
        public string PassWord { set; get; }
        Client newClient = new Client();
        public Form13(string UN, string PW)
        {
            InitializeComponent();
            this.User_Name = UN;
            this.PassWord = PW;
            Registration RClient = new Registration();
            newClient = RClient.Log_in(this.User_Name, this.PassWord);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch!='.')
            {
                e.Handled = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form_8 F8 = new Form_8(newClient.UserName, newClient.Password);
            F8.Visible = true;
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (newClient.PayLoan(double.Parse(txtAmount.Text)) == true)
            {
                MessageBox.Show("Done");
            }
            else
            {
                MessageBox.Show("The amount is too large for your loan "+newClient.OldLoan);
                return;
            }
            newClient.update();
            File.Delete("Client.txt");
            File.Copy("NewClient.txt", "Client.txt");
            File.Delete("NewClient.txt");
            this.Visible = false;
            Form_8 F8 = new Form_8(newClient.UserName, newClient.Password);
            F8.Visible = true;
        }
    }
}
