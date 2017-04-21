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
    public partial class Form10 : Form
    {
        public string User_Name { set; get; }
        public string PassWord { set; get; }
        Client newClient = new Client();
        public Form10(string UN, string PW)
        {
            InitializeComponent();
            this.User_Name = UN;
            this.PassWord = PW;
            Registration RClient = new Registration();
            newClient = RClient.Log_in(this.User_Name, this.PassWord);
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            
            this.Visible = false;
            Form8 F8 = new Form8(newClient.UserName, newClient.Password);
            F8.Visible = true;

        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            double amount;
            amount = double.Parse(txtEnter.Text);
            if(newClient.Deposit(amount)==true)
            {
                MessageBox.Show("Done");
                this.Close();
            }
            else
            {
                MessageBox.Show("Your Amount is not valid.");
                return;
            }
            newClient.update();
            File.Delete("Client.txt");
            File.Copy("NewClient.txt", "Client.txt");
            File.Delete("NewClient.txt");
            this.Visible = false;
            Form8 F8 = new Form8(newClient.UserName, newClient.Password);
            F8.Visible = true;
        }

        private void txtEnter_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch!='.' )
            {
                e.Handled = true;
            }
        }
    

    }
}
