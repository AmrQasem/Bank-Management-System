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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtID.Text.Any() == false || txtName.Text.Any() == false)
            {
                MessageBox.Show("Please enter a valid User Name and ID!");
                return;
            }
            string name;
            int id;
            name = txtName.Text;
            id =int.Parse( txtID.Text);
            Registration register = new Registration();
            Employee ay_7aga = register.Log_in(name, id);
            if(ay_7aga.Name==name&&ay_7aga.ID==id)
            {
                if (ay_7aga.Position == "Manager")
                {
                    this.Visible = false;
                    Form14 f14 = new Form14();
                    f14.Visible = true;
                }
                else
                {
                    this.Visible = false;
                    Form3 f3 = new Form3();
                    f3.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("You have Entered incorrect User Name or ID ");
                return;
            }
        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form1 F1 = new Form1();
            F1.Visible = true;
        }
    }
}
